using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_M2C1_6
{
    class Filme : Arquivo
    {
        private string _nomeDiretor;
        public string nomeDiretor
        {
            get
            {
                return this._nomeDiretor;
            }
            set
            {
                this._nomeDiretor = value;
            }
        }

        private string _atorPrincipal;
        public string atorPrincipal
        {
            get
            {
                return this._atorPrincipal;
            }
            set
            {
                this._atorPrincipal = value;
            }
        }

        private string _atrizPrincipal;
        public string atrizPrincipal
        {
            get
            {
                return this._atrizPrincipal;
            }
            set
            {
                this._atrizPrincipal = value;
            }
        }

        public Filme(string p_codigo, string p_nome, string p_categoria, decimal p_tamanhoFisico, string p_nomeDiretor, string p_atorPrincipal, string p_atrizPrincipal) : base(p_codigo, p_nome, p_categoria, p_tamanhoFisico)
        {
            this.nomeDiretor = p_nomeDiretor;
            this.atorPrincipal = p_atorPrincipal;
            this.atrizPrincipal = p_atrizPrincipal;
        }


        public void Play()
        {
            //-- Play movie
        }

        public void RetrieveInformation()
        {
            //-- Connect internet - search information
        }
    }
}
