using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_M2C1_6
{
    class Arquivo
    {
        private string _codigo;
        public string codigo
        {
            get
            {
                return this._codigo;
            }
            set
            {
                this._codigo = value;
            }
        }

        private string _nome;
        public string nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }

        private string _categoria;
        public string categoria
        {
            get
            {
                return this._categoria;
            }
            set
            {
                this._categoria = value;
            }
        }

        private decimal _tamanho;
        public decimal tamanho
        {
            get
            {
                return this._tamanho;
            }
            set
            {
                this._tamanho = value;
            }
        }



        public Arquivo(string p_codigo, string p_nome, string p_categoria, decimal p_tamanho)
        {
            this._codigo = p_codigo;
            this._nome = p_nome;
            this._categoria = p_categoria;
            this._tamanho = p_tamanho;
        }


    }
}
