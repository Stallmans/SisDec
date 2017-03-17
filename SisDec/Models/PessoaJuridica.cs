using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SisDec.Models
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        [DisplayName("Inscricao Estadual")]
        public decimal InscricaoEstadual { get; set; }
        [DisplayName("Inscricao Municipal")]
        public decimal InscricaoMunicipal { get; set; }
        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }
    }
}