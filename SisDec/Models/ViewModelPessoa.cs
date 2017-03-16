using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisDec.Models
{
    public class ViewModelPessoa
    {
        public Pessoa objPessoa { get; set; }
        public PessoaFisica objPessoaFisica { get; set; }
        public PessoaJuridica objPessoaJuridica { get; set; }
    }
}