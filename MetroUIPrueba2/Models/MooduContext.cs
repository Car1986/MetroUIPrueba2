﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class MooduContext : DbContext
    {
        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Areas> Areas { get; set; }
        public DbSet<AsignaRoles> AsignaRoles { get; set; }
        public DbSet<CategoriaInsumo> CategoriaInsumo { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CompraInsumo> CompraInsumo { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Insumo> Insumo { get; set; }
        public DbSet<InventarioInsumo> InventarioInsumo { get; set; }
        public DbSet<InventarioProducto> InventarioProductos { get; set; }
        public DbSet<MedioPago> MedioPago { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<OrdenDetalle> OrdenDetalle { get; set; }
        public DbSet<Pago> Pago { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<ProveeInsumo> ProveeInsumo { get; set; }
        public DbSet<Recurso> Recurso { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioInterno> UsuarioInterno { get; set; }
        public DbSet<TipoProducto> TipoProducto { get; set; }

    }
}