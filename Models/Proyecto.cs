using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Proyecto
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        public int? IdProyectoPadre { get; set; }
        public int? IdEstado { get; set; }


        [Required(ErrorMessage = "Debe seleccionar un responsable.")]
        public int IdResponsable { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un tipo de proyecto.")]
        public int IdTipoProyecto { get; set; }

        [StringLength(50)]
        public string? Codigo { get; set; }

        [Required, StringLength(255)]
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

        public string? RutaLogo { get; set; }
    }

    public class RespuestaApiProyecto<T>
    {
        public T? Datos { get; set; }
    }
}
