using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContaCorrente_02.Models
{
    public class Cliente
    {

            public int Id { get; set; }

            [Display(Name = "Nome cliente")]
            [Required(ErrorMessage = "Preenchimento obrigatório")]
            [StringLength(100, ErrorMessage = "Máximo 100 carateres.")]
            public string NomeCliente { get; set; }


            [Display(Name = "Ref.")]
            //[Required(ErrorMessage = "Preenchimento obrigatório")]
            [StringLength(50, ErrorMessage = "Máximo 50 carateres.")]
            public string Referencia { get; set; }

            public string Marcador { get; set; }

            public virtual ICollection<Movimento> Movimentos { get; set; }
        }
}