﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class InventarioInsumo
    {
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public int Critico { get; set; }
        [StringLength(100, MinimumLength = 5)]
        public string Observacion { get; set; }
        public int InsumoId { get; set; }
        public int AlmacenId { get; set; }
    }
}