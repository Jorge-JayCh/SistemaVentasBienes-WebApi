using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVentasBienes.Models
{
    public class Tipo_Inmueble
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Tipo_Inmueble { get; set; }
        public string? Desc_Condicion { get; set; }


        //public virtual ICollection<Inmueble>? Inmuebles { get; set; }
    }
}
