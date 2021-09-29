using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practiva.Models
{
    public class Persona
    {

        
        [Required(ErrorMessage = "Campo requerido")]
        public int Nombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        //[Range(0 - 100, int.MaxValue, ErrorMessage = "Edad no valida")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public int Sexo { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public int NivelEducativo { get; set; }


    }
}