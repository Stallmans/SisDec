///////////////////////////////////////////////////////////
//  Requisicao.cs
//  Implementation of the Class Requisicao
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
	public class Requisicao {

        public DateTime DataPedido { get; set; }
        public DateTime DataRequisicao { get; set; }
        public int NumeroRequisicao { get; set; }
        public int Estado { get; set; }

        public Cliente ObjCliente { get; set; }


    }//end Requisicao

}//end namespace Model