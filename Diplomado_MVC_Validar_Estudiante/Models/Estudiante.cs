using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Diplomado_MVC_Validar_Estudiante.Models
{
    public class Estudiante
    {
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [MinLength(3, ErrorMessage = "El Nombre del estudiante debe tener al menos 3 caracteres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        [MinLength(3, ErrorMessage = "El Apellido del estudiante debe tener al menos 2 caracteres")]
        public string Apellidos { get; set; }

        [Range(14,65, ErrorMessage = "La Edad del Estudiante debe estar entre 14 y 65")]
        public int Edad { get; set; }

        [EmailAddress(ErrorMessage = "Debe tener un Email valido")]
        public string Email { get; set; }

        [RegularExpression("[MmFf]", ErrorMessage = "Solo se puede ingresar M=Masculino o F=Femenino")]
        public string Genero { get; set; }

        [RegularExpression("[CcSsUuDd]", ErrorMessage = "Solo se puede ingresar una C=Casado, S=Soltero, U=Union Libre o D=Divorciado")]
        public string EstadoCivil { get; set; }
    }
}