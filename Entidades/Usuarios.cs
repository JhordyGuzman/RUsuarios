  
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RUsuarios.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuariosId { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string NombreUsuario { get; set; }

        public string Contrasena { get; set; }
    }
}