using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        //criando a relação com lanches, um para muitos
        public List<Lanche> Lanches { get; set; }


    }
}
