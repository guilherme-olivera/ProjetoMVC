﻿using LanchesMac.Models;

namespace LanchesMac.ViewModels
{
    public class LaancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
