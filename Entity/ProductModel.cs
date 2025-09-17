using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity;

public class ProductModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("Name", TypeName = "NVARCHAR(70)")]
    public string Name { get; set; } = string.Empty;
    [Column("Description", TypeName = "NVARCHAR(200)")]
    public string Description { get; set; } = string.Empty;
    [Column("Validate",TypeName = "NVARCHAR(20)")]
    public string Validate { get; set; } = String.Empty;
    [Column("price",TypeName = "DECIMAL")]
    public decimal price { get; set; }
}

public class OriginProduct
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("OriginName", TypeName = "NVARCHAR(70)")]
    public string Name { get; set; } = string.Empty;
    [ForeignKey(nameof(ProductModel))]
    public int ProcutId { get; set; }
    public ProductModel ProductModel { get; set; }
}