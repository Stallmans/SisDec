///////////////////////////////////////////////////////////
//  PessoaFisica.cs
//  Implementation of the Class PessoaFisica
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
	public class PessoaFisica : Pessoa {

        public string Nome { get; set; }
        public string Cpf { get; set; }

        

        
    }//end PessoaFisica

}//end namespace Model