///////////////////////////////////////////////////////////
//  Concessionaria.cs
//  Implementation of the Class Concessionaria
//  Generated by Enterprise Architect
//  Created on:      24-fev-2017 23:25:10
//  Original author: soare
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SisDec.Models
{
	public class Concessionaria {

        public string Cnpj { get; set; }
        public int Dn { get; set; }
        public string Endereco { get; set; }
        public string Nome { get; set; }
        public int telefone { get; set; }

    }//end Concessionaria

}//end namespace Model