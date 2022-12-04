using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVentasBienes.Models
{
    public class Condicion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Condicion { get; set; }
        public string? Desc_Condicion { get; set; }
        //public virtual ICollection<Venta>? Ventas { get; set; }

    }
}
