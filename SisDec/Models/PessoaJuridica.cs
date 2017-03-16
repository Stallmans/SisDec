///////////////////////////////////////////////////////////
//  PessoaJuridica.cs
//  Implementation of the Class PessoaJuridica
//  Generated by Enterprise Architect
//  Created on:      24-fev-2017 23:25:11
//  Original author: soare
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SisDec.Models
{
	public class PessoaJuridica : Pessoa {

        public string Cnpj { get; set; }
        public decimal InscricaoEstadual { get; set; }
        public decimal InscricaoMunicipal { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }

       

        
    }//end PessoaJuridica

}//end namespace Model