﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Application.InputModels.Catalogo
{
    public class ProdutoInputModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Categoria deve ser informado!")]
        public Guid CategoriaId { get; set; }

        [Required(ErrorMessage = "O campo Nome deve ser informado!")]
        [MinLength(2, ErrorMessage = "O campo Nome deve ter no minímo 2 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Preço deve ser informado!")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor do Preço não poder ser Zero!")]
        public double Preco { get; set; }

        public bool Estocavel { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "O Estoque Minimo deve ter o valor minimo de {1}!")]
        public int EstoqueMinimo { get; set; }

        [Required(ErrorMessage = "Selecione uma Imagem para o produto!")]
        public string Imagem { get; set; }

        public string Descricao { get; set; }
    }
}
