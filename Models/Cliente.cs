using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVentasBienes.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Cliente { get; set; }
        //[JsonIgnore]
        //public virtual Cliente? cliente { get; set; }
        public string? Nombre_Cliente { get; set; }
        public string? Dir_Cliente   { get; set; }
        public string? Correo_Cliente { get; set; }
        public uint Telefono_Cliente { get; set; }
        //public virtual ICollection<Venta>? Ventas { get; set; }

    }
}
