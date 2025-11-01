using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Proyecto_Producto
    {
        [Required]
        public int IdProyecto { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaAsociacion { get; set; }
    }

    public class RespuestaApiProyectoProducto<T>
    {
        public string? Tabla { get; set; }
        public string? Esquema { get; set; }
        public int? Total { get; set; }
        public T? Datos { get; set; }
    }
}
