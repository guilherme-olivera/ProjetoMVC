namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string imagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }

        //criando a relação com a categoria, como se fosse uma chave estrangeira
        //propriedade de navegação 
        public int CategoriaID { get; set; }//FK
        public virtual Categoria Categoria { get; set; }



    }


}
