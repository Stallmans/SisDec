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

        
        public Requisicao objRequisicao { get; set; }
        public Peca ObjPeca { get; set; }
        public int Quantidade { get; set; }

        public PecaRequisicao(Requisicao req, Peca peca)
        {
            this.objRequisicao = req;
            this.ObjPeca = peca;
        }
    }
}