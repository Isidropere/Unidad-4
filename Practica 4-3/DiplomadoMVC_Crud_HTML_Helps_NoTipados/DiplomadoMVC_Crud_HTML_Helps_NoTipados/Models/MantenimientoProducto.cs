using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;


namespace DiplomadoMVC_Crud_HTML_Helps_NoTipados.Models
{
    public class MantenimientoProducto
    {
        private SqlConnection con;
        private void Conectar()
        {
            string Conecta = ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();
            con = new SqlConnection(Conecta);
        }

        public int Agregar(Producto Produt)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("INSERT INTO dbo.Producto(Descripcion,Precio)  VALUES (@Descripcion, @Precio)", con);
            comando.Parameters.Add("@Codigo", SqlDbType.Int);
            comando.Parameters["@Codigo"].Value = Produt.Codigo;

            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            comando.Parameters["@Descripcion"].Value = Produt.Descripcion;
            comando.Parameters.Add("@Precio", SqlDbType.Float);
            comando.Parameters["@Precio"].Value = Produt.Precio;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public List<Producto> RecuperarTodo()
        {
            Conectar();
            List<Producto> productos = new List<Producto>();
            SqlCommand comando = new SqlCommand("SELECT Codigo, Descripcion ,Precio FROM  Producto ", con);
            con.Open();
            SqlDataReader Registro = comando.ExecuteReader();
            while (Registro.Read())
            {
                Producto product = new Producto
                {
                    Codigo = int.Parse(Registro["Codigo"].ToString()),
                    Descripcion = Registro["productos1"].ToString(),
                    Precio = float.Parse(Registro["Precio"].ToString())
                };
                productos.Add(product);
            }
            con.Close();
            return productos;


        }

        public Producto RecuperarUnRegistro(int Codigo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand(" SELECT Codigo, Descripcion,Precio FROM  Producto  WHERE Codigo = @codigo", con);
            comando.Parameters.Add("@Codigo", SqlDbType.Int);
            comando.Parameters["@codigo"].Value = Codigo;
            con.Open();
            SqlDataReader Registro = comando.ExecuteReader();
            Producto producto = new Producto();
            if (Registro.Read())
            {
                producto.Codigo = int.Parse(Registro["Codigo"].ToString());
                producto.Descripcion = Registro["Descripcion"].ToString();
                producto.Precio = float.Parse(Registro["Precio"].ToString());
            }
            else
                producto = null;
            con.Close();
            return producto;
        }

        public int Modificar(Producto producto)

        {
            Conectar();
            SqlCommand comando = new SqlCommand("UPDATE Producto SET Descripcion= @Descripcion,Precio = @Codigo where Codigo = @Codigo", con);
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar);
            comando.Parameters["@descripcion"].Value = producto.Descripcion;
            comando.Parameters.Add("@Precio", SqlDbType.Float);
            comando.Parameters["@Precio"].Value = producto.Precio;
            comando.Parameters.Add("@Codigo", SqlDbType.Int);
            comando.Parameters["@Codigo"].Value = producto.Codigo;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int Borrar(int Codigo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("DELETE FROM Producto WHERE Codigo= @Codigo)", con);
            comando.Parameters.Add("@Codigo", SqlDbType.Int);
            comando.Parameters["@Codigo"].Value = Codigo;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

    }
}