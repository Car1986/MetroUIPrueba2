﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Cliente
    {
        public int Id { get; set; }        
        [Required]
        [StringLength(35, MinimumLength = 3)]
        public string Nombres { get; set; }
        [Required]
        [StringLength(35, MinimumLength = 3)]
        public string Apellidos { get; set; }
        [Required]        
        public string Correo { get; set; }
        [Required]       
        public int Telefono { get; set; }
        [Required]       
        public string Rut { get; set; }

        //puesto alreves de lo que dice la logica con el cliente usuario
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}