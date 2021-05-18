using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContaCorrente_02.Models
{
    public class Movimento
    {
        public int Id { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataRegisto { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(100, ErrorMessage = "Máximo 30 carateres.")]
        public string Descricao { get; set; }

        [Display(Name = "Valor débito")]
        public double? ValorDebito { get; set; }

        [Display(Name = "Valor crédito")]

        public double? ValorCredito { get; set; }

        public int ClienteId { get; set; }//chave estrangeira

        public virtual Cliente Cliente { get; set; }
    }
}