using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SCApp.Models
{
    public class Usuario
    {
        [Required]
        public int id_usuario { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido { get; set; }
        [Required]
        public string usuario { get; set; }
        [Required]
        public string contraseña { get; set; }
        [Required]
        public string fecha_creacion { get; set; }
        [Required]
        public string estado { get; set; }

        public bool Done { get; set; }
    }
}
