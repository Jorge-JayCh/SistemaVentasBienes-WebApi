using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVentasBienes.Models
{
    public class Inmueble
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Inmueble { get; set; }
        public string? Desc_Inmueble { get; set; }
        public string? Ubic_Inmueble { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Costo_Inmueble { get; set; }


        public int TipoInmuebleId { get; set; }
        [ForeignKey("TipoInmuebleId")]
        public virtual Tipo_Inmueble? Tipo_Inmueble { get; set; }
        public Venta? Venta { get; set; }

    }
}
