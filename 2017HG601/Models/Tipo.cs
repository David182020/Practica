using System;
using System.ComponentModel.DataAnnotations;

namespace _2017HG601.Models
{
    public class Tipo
    {
        [Key]
        public int id_tipo_equipo { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }    
    }
}