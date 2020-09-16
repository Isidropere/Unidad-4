using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Validar_Estudiante_DataAnnotations.Models
{
    public class Estudiante
    {
        [Key]
        public int ID_Estudiante { get; set; }

        [Required(ErrorMessage ="El nombre del estudiante es obligatorio")]
        [MinLength(3,ErrorMessage ="El nombre del estudiante debe terner al menos 3 caracteres")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "El apellido del estudiante es obligatorio")]
        [MinLength(3, ErrorMessage = "El apellido del estudiante debe terner al menos 3 caracteres")]
        public String Apellidos { get; set; }

        [Range(14,56,ErrorMessage ="La edad del estudiante debe estar entre 14 y 65")]
        [Required(ErrorMessage = "La edad es requerida")]
        public int  Edad { get; set; }

        [EmailAddress(ErrorMessage ="Debe ingresar un Email valido")]
        public String Email { get; set; }

        [RegularExpression("[MmFf]",ErrorMessage ="Solo puede ingresar una M =Masculino o F= Femenino")]
        public String Genero { get; set; }

        [RegularExpression("[CcSsUuDd]", ErrorMessage = "Solo puede ingresar una C = Casado, S = Soltero, U = Union libre o D = Divorciado")]
        public String EstadoCivil { get; set; }

    }
}