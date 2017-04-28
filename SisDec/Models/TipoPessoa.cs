using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SisDec.Models
{
    public enum TipoPessoa
    {
        [Display(Name = "Pessoa Fisica")]
        pessoaFisica = 1,
        [Display(Name = "Pessoa Fisica")]
        pessoaJuridica = 2

    }
}