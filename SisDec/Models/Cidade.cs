///////////////////////////////////////////////////////////
//  Cidade.cs
//  Implementation of the Class Cidade
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
	public class Cidade {
        public int CidadeId { get; set; }
        public string Nome { get; set; }

        public Estado enumEstado { get; set; }

   
    }//end Cidade

}//end namespace Model