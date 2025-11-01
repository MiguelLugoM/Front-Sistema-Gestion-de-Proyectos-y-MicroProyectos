using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Producto
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El tipo de producto es obligatorio.")]
        public int IdTipoProducto { get; set; }

        [StringLength(50)]
        public string? Codigo { get; set; }

        [Required(ErrorMessage = "El título es obligatorio.")]
        [StringLength(255)]
        public string Titulo { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaFinPrevista { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaModificacion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaFinalizacion { get; set; }

        [StringLength(int.MaxValue)]
        public string? RutaLogo { get; set; }
    }

    public class RespuestaApiProducto<T>
    {
        public string? Tabla { get; set; }
        public string? Esquema { get; set; }
        public int? Total { get; set; }
        public T? Datos { get; set; }
    }
}
