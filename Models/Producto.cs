using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prueba_tome.Models
{
    public class Producto
    {
        [Key]
        [Column("ProductoId", TypeName = ("bigint"))]
        public long ProductoId { get; set; }

        [Required]
        [Column("Nombre", TypeName = ("varchar(100)"))]
        public string? Nombre { get; set; }

        [Required]
        [Column("Valor", TypeName = ("decimal(18,2)"))]
        public int Valor { get; set; }

        [Required]
        [Column("TipoId", TypeName = ("numeric(18,0)"))]
        public int TipoId { get; set; }

        [Required]
        [Column("Cantidad", TypeName = ("numeric(18,0)"))]
        public int Cantidad { get; set; }
    }
}