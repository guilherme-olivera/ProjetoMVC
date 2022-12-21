using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    //para criar as tabelas de acordo com o desenvolvimento usar os comandos do .schema
    [Table("Lanches")] //criando a tabela de acordo com a classe
    public class Lanche
    {
        [Key] //criando uma PK
        public int LancheId { get; set; }

        //required  não aceita nulo + o ErroMessege faz com que apareça uma mensaggem 
        [Required(ErrorMessage = "O nome do Lanche deve ser Informado")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength =10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do Lanche deve ser Informada")]
        [Display(Name = "Descrição do Lanche")]
        //min e max determina tamanho quantidade de caracteres
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição não pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }


        //[NotMapped] // quando você não quer que variavel se torne um campo no banco
        [Required(ErrorMessage = "A descrição detalhada do Lanche deve ser Informada")]
        [Display(Name = "Descrição detalhada do Lanche")]        
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada não pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }


        [Required(ErrorMessage ="Informe o preço do lanche")]
        [Display(Name ="Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no mínimo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no mínimo {1} caracteres")]
        public string imagemThumbnailUrl { get; set; }


        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }


        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        //criando a relação com a categoria, como se fosse uma chave estrangeira
        //propriedade de navegação 
        public int CategoriaID { get; set; }//FK
        // categoria vai definir o relacionamento com a tabela lanches
        public virtual Categoria Categoria { get; set; }



    }


}
