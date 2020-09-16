using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CRUD_DiplomadoUASD.Web.Models
{
    public class Pelicula
    {
            [Key]
            public int Codigo { get; set; }

            [Required(ErrorMessage = "El titulo de la pelicula es obligatorio.")]
            [MinLength(3, ErrorMessage = "El titulo de la pelicula debe tener al menos 3 caracteres.")]
            public string Titulo { get; set; }

            [Required(ErrorMessage = "El titulo de la pelicula es obligatorio.")]
            [MinLength(3, ErrorMessage = "El nombre del director debe tener al menos 3 caracteres.")]
            public string Director { get; set; }

            [Required(ErrorMessage = "El nombre del autor principal es obligatorio.")]
            [MinLength(3, ErrorMessage = "El nombre de autor principal debe tener al menos 3 caracteres.")]
            public string AutorPrincipal { get; set; }

            [Display(Name = "N:Autor")]
            [Range(1, 1000, ErrorMessage = "la cantidad de autores no puede ser nemos que 1 ni mayor que 1000")]
            [Required(ErrorMessage = "El nombre del autor es obligatorio.")]
            public Nullable<int> No_Autor { get; set; }

            [Display(Name = "Duracion de la pelicula")]
            [DataType(DataType.Time)]
            public Nullable<double> Duracion { get; set; }

            [Display(Name = "Fecha de estreno")]
            [DataType(DataType.DateTime)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
            public Nullable<DateTime> Estreno { get; set; }
        
    }
}