using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftwarePartialView.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        //[Required]//Cuando Inserte en BD,va a ser requerido
        public string Titulo { get; set; }
        public bool EstaEnCartelera { get; set; }
        //[StringLength(120)]//Longitud del string que vas a insertar
        public string Genero { get; set; }
    }
}