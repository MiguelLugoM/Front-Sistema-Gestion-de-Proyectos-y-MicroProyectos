using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Archivo
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un usuario.")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "La ruta del archivo es obligatoria.")]
        public string Ruta { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre del archivo es obligatorio.")]
        [StringLength(255)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(50)]
        public string? Tipo { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Fecha { get; set; }
    }

    // Respuesta de la API genérica
    public class RespuestaApiArchivo<T>
    {
        public string? Tabla { get; set; }
        public string? Esquema { get; set; }
        public int? Total { get; set; }
        public T? Datos { get; set; }
    }
}
