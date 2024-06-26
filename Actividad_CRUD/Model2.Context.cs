﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Actividad_CRUD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class tiendaEntities1 : DbContext
    {
        public tiendaEntities1()
            : base("name=tiendaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }
    
        public virtual int AgregarCategoria(string nombreCategoria)
        {
            var nombreCategoriaParameter = nombreCategoria != null ?
                new ObjectParameter("NombreCategoria", nombreCategoria) :
                new ObjectParameter("NombreCategoria", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarCategoria", nombreCategoriaParameter);
        }
    
        public virtual int AgregarEmpleado(string nombreEmpleado, string cargo)
        {
            var nombreEmpleadoParameter = nombreEmpleado != null ?
                new ObjectParameter("NombreEmpleado", nombreEmpleado) :
                new ObjectParameter("NombreEmpleado", typeof(string));
    
            var cargoParameter = cargo != null ?
                new ObjectParameter("Cargo", cargo) :
                new ObjectParameter("Cargo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarEmpleado", nombreEmpleadoParameter, cargoParameter);
        }
    
        public virtual int AgregarInventario(Nullable<int> iDProducto, Nullable<int> cantidadEnStock)
        {
            var iDProductoParameter = iDProducto.HasValue ?
                new ObjectParameter("IDProducto", iDProducto) :
                new ObjectParameter("IDProducto", typeof(int));
    
            var cantidadEnStockParameter = cantidadEnStock.HasValue ?
                new ObjectParameter("CantidadEnStock", cantidadEnStock) :
                new ObjectParameter("CantidadEnStock", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarInventario", iDProductoParameter, cantidadEnStockParameter);
        }
    
        public virtual int AgregarProducto(string nombreProducto, Nullable<int> iDCategoria, Nullable<decimal> precioUnitario)
        {
            var nombreProductoParameter = nombreProducto != null ?
                new ObjectParameter("NombreProducto", nombreProducto) :
                new ObjectParameter("NombreProducto", typeof(string));
    
            var iDCategoriaParameter = iDCategoria.HasValue ?
                new ObjectParameter("IDCategoria", iDCategoria) :
                new ObjectParameter("IDCategoria", typeof(int));
    
            var precioUnitarioParameter = precioUnitario.HasValue ?
                new ObjectParameter("PrecioUnitario", precioUnitario) :
                new ObjectParameter("PrecioUnitario", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarProducto", nombreProductoParameter, iDCategoriaParameter, precioUnitarioParameter);
        }
    
        public virtual int AgregarUsuario(string nombreUsuario, string contraseña, string tipoUsuario)
        {
            var nombreUsuarioParameter = nombreUsuario != null ?
                new ObjectParameter("NombreUsuario", nombreUsuario) :
                new ObjectParameter("NombreUsuario", typeof(string));
    
            var contraseñaParameter = contraseña != null ?
                new ObjectParameter("Contraseña", contraseña) :
                new ObjectParameter("Contraseña", typeof(string));
    
            var tipoUsuarioParameter = tipoUsuario != null ?
                new ObjectParameter("TipoUsuario", tipoUsuario) :
                new ObjectParameter("TipoUsuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarUsuario", nombreUsuarioParameter, contraseñaParameter, tipoUsuarioParameter);
        }
    
        public virtual int AgregarVenta(Nullable<int> iDProducto, Nullable<System.DateTime> fechaVenta, Nullable<int> cantidad, Nullable<decimal> montoVenta)
        {
            var iDProductoParameter = iDProducto.HasValue ?
                new ObjectParameter("IDProducto", iDProducto) :
                new ObjectParameter("IDProducto", typeof(int));
    
            var fechaVentaParameter = fechaVenta.HasValue ?
                new ObjectParameter("FechaVenta", fechaVenta) :
                new ObjectParameter("FechaVenta", typeof(System.DateTime));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var montoVentaParameter = montoVenta.HasValue ?
                new ObjectParameter("MontoVenta", montoVenta) :
                new ObjectParameter("MontoVenta", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarVenta", iDProductoParameter, fechaVentaParameter, cantidadParameter, montoVentaParameter);
        }
    
        public virtual int EliminarCategoria(Nullable<int> iDCategoria)
        {
            var iDCategoriaParameter = iDCategoria.HasValue ?
                new ObjectParameter("IDCategoria", iDCategoria) :
                new ObjectParameter("IDCategoria", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarCategoria", iDCategoriaParameter);
        }
    
        public virtual int EliminarEmpleado(Nullable<int> iDEmpleado)
        {
            var iDEmpleadoParameter = iDEmpleado.HasValue ?
                new ObjectParameter("IDEmpleado", iDEmpleado) :
                new ObjectParameter("IDEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarEmpleado", iDEmpleadoParameter);
        }
    
        public virtual int EliminarInventario(Nullable<int> iDInventario)
        {
            var iDInventarioParameter = iDInventario.HasValue ?
                new ObjectParameter("IDInventario", iDInventario) :
                new ObjectParameter("IDInventario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarInventario", iDInventarioParameter);
        }
    
        public virtual int EliminarProducto(Nullable<int> iDProducto)
        {
            var iDProductoParameter = iDProducto.HasValue ?
                new ObjectParameter("IDProducto", iDProducto) :
                new ObjectParameter("IDProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarProducto", iDProductoParameter);
        }
    
        public virtual int EliminarUsuario(Nullable<int> iDUsuario)
        {
            var iDUsuarioParameter = iDUsuario.HasValue ?
                new ObjectParameter("IDUsuario", iDUsuario) :
                new ObjectParameter("IDUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarUsuario", iDUsuarioParameter);
        }
    
        public virtual int EliminarVenta(Nullable<int> iDVenta)
        {
            var iDVentaParameter = iDVenta.HasValue ?
                new ObjectParameter("IDVenta", iDVenta) :
                new ObjectParameter("IDVenta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarVenta", iDVentaParameter);
        }
    
        public virtual int ModificarCategoria(Nullable<int> iDCategoria, string nuevoNombreCategoria)
        {
            var iDCategoriaParameter = iDCategoria.HasValue ?
                new ObjectParameter("IDCategoria", iDCategoria) :
                new ObjectParameter("IDCategoria", typeof(int));
    
            var nuevoNombreCategoriaParameter = nuevoNombreCategoria != null ?
                new ObjectParameter("NuevoNombreCategoria", nuevoNombreCategoria) :
                new ObjectParameter("NuevoNombreCategoria", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModificarCategoria", iDCategoriaParameter, nuevoNombreCategoriaParameter);
        }
    
        public virtual int ModificarEmpleado(Nullable<int> iDEmpleado, string nuevoNombreEmpleado, string nuevoCargo)
        {
            var iDEmpleadoParameter = iDEmpleado.HasValue ?
                new ObjectParameter("IDEmpleado", iDEmpleado) :
                new ObjectParameter("IDEmpleado", typeof(int));
    
            var nuevoNombreEmpleadoParameter = nuevoNombreEmpleado != null ?
                new ObjectParameter("NuevoNombreEmpleado", nuevoNombreEmpleado) :
                new ObjectParameter("NuevoNombreEmpleado", typeof(string));
    
            var nuevoCargoParameter = nuevoCargo != null ?
                new ObjectParameter("NuevoCargo", nuevoCargo) :
                new ObjectParameter("NuevoCargo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModificarEmpleado", iDEmpleadoParameter, nuevoNombreEmpleadoParameter, nuevoCargoParameter);
        }
    
        public virtual int ModificarInventario(Nullable<int> iDInventario, Nullable<int> iDProducto, Nullable<int> nuevaCantidadEnStock)
        {
            var iDInventarioParameter = iDInventario.HasValue ?
                new ObjectParameter("IDInventario", iDInventario) :
                new ObjectParameter("IDInventario", typeof(int));
    
            var iDProductoParameter = iDProducto.HasValue ?
                new ObjectParameter("IDProducto", iDProducto) :
                new ObjectParameter("IDProducto", typeof(int));
    
            var nuevaCantidadEnStockParameter = nuevaCantidadEnStock.HasValue ?
                new ObjectParameter("NuevaCantidadEnStock", nuevaCantidadEnStock) :
                new ObjectParameter("NuevaCantidadEnStock", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModificarInventario", iDInventarioParameter, iDProductoParameter, nuevaCantidadEnStockParameter);
        }
    
        public virtual int ModificarProducto(Nullable<int> iDProducto, string nuevoNombreProducto, Nullable<int> nuevaIDCategoria, Nullable<decimal> nuevoPrecioUnitario)
        {
            var iDProductoParameter = iDProducto.HasValue ?
                new ObjectParameter("IDProducto", iDProducto) :
                new ObjectParameter("IDProducto", typeof(int));
    
            var nuevoNombreProductoParameter = nuevoNombreProducto != null ?
                new ObjectParameter("NuevoNombreProducto", nuevoNombreProducto) :
                new ObjectParameter("NuevoNombreProducto", typeof(string));
    
            var nuevaIDCategoriaParameter = nuevaIDCategoria.HasValue ?
                new ObjectParameter("NuevaIDCategoria", nuevaIDCategoria) :
                new ObjectParameter("NuevaIDCategoria", typeof(int));
    
            var nuevoPrecioUnitarioParameter = nuevoPrecioUnitario.HasValue ?
                new ObjectParameter("NuevoPrecioUnitario", nuevoPrecioUnitario) :
                new ObjectParameter("NuevoPrecioUnitario", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModificarProducto", iDProductoParameter, nuevoNombreProductoParameter, nuevaIDCategoriaParameter, nuevoPrecioUnitarioParameter);
        }
    
        public virtual int ModificarUsuario(Nullable<int> iDUsuario, string nuevoNombreUsuario, string nuevaContraseña, string nuevoTipoUsuario)
        {
            var iDUsuarioParameter = iDUsuario.HasValue ?
                new ObjectParameter("IDUsuario", iDUsuario) :
                new ObjectParameter("IDUsuario", typeof(int));
    
            var nuevoNombreUsuarioParameter = nuevoNombreUsuario != null ?
                new ObjectParameter("NuevoNombreUsuario", nuevoNombreUsuario) :
                new ObjectParameter("NuevoNombreUsuario", typeof(string));
    
            var nuevaContraseñaParameter = nuevaContraseña != null ?
                new ObjectParameter("NuevaContraseña", nuevaContraseña) :
                new ObjectParameter("NuevaContraseña", typeof(string));
    
            var nuevoTipoUsuarioParameter = nuevoTipoUsuario != null ?
                new ObjectParameter("NuevoTipoUsuario", nuevoTipoUsuario) :
                new ObjectParameter("NuevoTipoUsuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModificarUsuario", iDUsuarioParameter, nuevoNombreUsuarioParameter, nuevaContraseñaParameter, nuevoTipoUsuarioParameter);
        }
    
        public virtual int ModificarVenta(Nullable<int> iDVenta, Nullable<int> iDProducto, Nullable<System.DateTime> fechaVenta, Nullable<int> cantidad, Nullable<decimal> montoVenta)
        {
            var iDVentaParameter = iDVenta.HasValue ?
                new ObjectParameter("IDVenta", iDVenta) :
                new ObjectParameter("IDVenta", typeof(int));
    
            var iDProductoParameter = iDProducto.HasValue ?
                new ObjectParameter("IDProducto", iDProducto) :
                new ObjectParameter("IDProducto", typeof(int));
    
            var fechaVentaParameter = fechaVenta.HasValue ?
                new ObjectParameter("FechaVenta", fechaVenta) :
                new ObjectParameter("FechaVenta", typeof(System.DateTime));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var montoVentaParameter = montoVenta.HasValue ?
                new ObjectParameter("MontoVenta", montoVenta) :
                new ObjectParameter("MontoVenta", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModificarVenta", iDVentaParameter, iDProductoParameter, fechaVentaParameter, cantidadParameter, montoVentaParameter);
        }
    }
}
