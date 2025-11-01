using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Archivo_Entregable
    {
        [Required]
        public int IdArchivo { get; set; }

        [Required]
        public int IdEntregable { get; set; }
    }

    public class RespuestaApiArchivoEntregable<T>
    {
        public string? Tabla { get; set; }
        public string? Esquema { get; set; }
        public int? Total { get; set; }
        public T? Datos { get; set; }
    }
}
