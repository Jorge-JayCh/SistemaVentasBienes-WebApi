using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVentasBienes.Models
{
    public class Forma_Pago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Forma_Pago { get; set; }
        public string? Desc_Forma_Pago { get; set; }
        //public virtual ICollection<Venta>? Ventas { get; set; }

    }
}
