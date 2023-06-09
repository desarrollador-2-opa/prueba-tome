using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prueba_tome.Models;

public class TipoProducto
{
    [Key]
    [Column("TipoId", TypeName = ("bigint"))]
    public long TipoId { get; set; }

    [Required]
    [Column("Nombre", TypeName = ("Varchar(100)"))]
    public string? Nombre { get; set; }

    [Column("Descripcion", TypeName = ("Varchar(100)"))]
    public string? Descripcion { get; set; } = string.Empty;
}