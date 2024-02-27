using Poc_API_Relatorios_TBFG.Model;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Poc_API_Relatorios_TBFG.Model
{
    public class Categorias
    {
        public Categorias()
        {
            Produtos = new Collection<Produtos>();
        }
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(300)]
        public string? ImagemUrl { get; set; }
        public ICollection<Produtos>? Produtos { get; set; }

        // public int CategoriaId { get; set; }
        // public string Nome { get; set; }
        // public string ImagemUrl { get; set; }
        // public bool SeAtivo { get; set; }
        //
        // public Categorias( string nome)
        // {
        //     Random randNum = new Random();
        //
        //         CategoriaId = randNum.Next();
        //         Nome = nome;
        //         ImagemUrl = string.Empty;   
        // }
    }
}
