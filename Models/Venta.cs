using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVentasBienes.Models
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Venta { get; set; }
        public string? Desc_Venta { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Total_Venta { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Total_Iva { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Total_General { get; set; }
        public DateTime Fecha_Venta { get; set; }

        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public int FormaPagoId { get; set; }
        [ForeignKey("FormaPagoId")]
        public int CondicionId { get; set; }
        [ForeignKey("CondicionId")]
        public int InmuebleId { get; set; }
        [ForeignKey("InmuebleId")]

        public virtual Cliente? Cliente { get; set; }
        public virtual Forma_Pago? Forma_Pago { get; set; }
        public virtual Condicion? Condicion { get; set; }
        public virtual Inmueble? Inmueble { get; set; }
    }
}
