using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poc_API_Relatorios_TBFG.Model;
[Table("Produtos")]
public class Produtos
{
    [Key]
    public int ProdutoId { get; set; }
    [Required]
    [StringLength(100)]

    public string? Nome { get; set; }
    [Required]
    [StringLength(300)]

    public string? Descricao { get; set; }
    [Required]
    [Column(TypeName = "decimal(10,2)")]

    public decimal preco { get; set; }
    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    public float Estoque { get; set; }

    public DateTime DataCadastro { get; set; }
    public int CategoriaId { get; set; }

    public Categorias? Produto { get; set; }

}
