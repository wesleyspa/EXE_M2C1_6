using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_M2C1_6
{
    class Musica : Arquivo
    {
        private string _artista;
        public string artista
        {
            get
            {
                return this._artista;
            }
            set
            {
                this._artista = value;
            }
        }

        private int _segundos;
        public int segundos
        {
            get
            {
                return _segundos;
            }
            set
            {
                this._segundos = value;
            }
        }

        public Musica(string p_codigo, string p_nome, string p_categoria, decimal p_tamanhoFisico, string p_nomeAutor, int p_segundos) : base(p_codigo, p_nome, p_categoria, p_tamanhoFisico)
        {
            this.artista = p_nomeAutor;
            this.segundos = p_segundos;                        
        }

        public void Play()
        {
            //-- Play Music
        }

        public void RetrieveInformation()
        {
         
            //-- Connect internet - search information
        }


    }
}
