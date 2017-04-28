using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using SisDec.Models;

namespace SisDec.Models
{
    public class PecaRequisicao
    {
        public int PecaRequisicaoId { get; set; }

        
        public PecaRequisicao()
        {
            this.ObjPeca = ObjPeca;
            this.Quantidade = Quantidade;
            this.Valor = Valor;
        }

        public Peca ObjPeca { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }

    }
}