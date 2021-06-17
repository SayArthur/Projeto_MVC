using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace Projeto_MVC.Models
{
    public class Produtos
    {
        [Required(ErrorMessage = "O campo código é obrigatório!")]
        public int Código { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira de 5 a 50 caracteres")]
        public string Descrição { get; set; }

        [Range(1, 100, ErrorMessage = "Insira um peso entre 1kg e 100kg")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "O campo categoria é obrigatório!")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "O campo valor unitário é obrigatório!")]
        [Range(1, 50, ErrorMessage = "Insira um valor entre R$1,00 e R$50,00")]
        public double Valor_Unitário { get; set; }
    }
}