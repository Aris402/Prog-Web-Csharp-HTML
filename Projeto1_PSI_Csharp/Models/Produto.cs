﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto1_PSI_Csharp.Models
{
    public class Produto
    {
        public long? ProdutoId { get; set; }
        public string Nome { get; set; }
        public long? CategoriaId { get; set; }
        public long? FabricanteId { get; set; }
        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}