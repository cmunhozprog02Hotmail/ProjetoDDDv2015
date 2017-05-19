using ProjetoDDDv2015.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoDDDv2015.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage ="Campo Nome obrigatprio")]
        [MaxLength(250, ErrorMessage ="Máxino {0} catacteres")]
        [MinLength(2, ErrorMessage ="Mínimo de {2} catacteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        
        public decimal Valor { get; set; }

        public bool Disponivel { get; set; }

        public int ClienteId { get; set; }

    }
}