using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte
{
    class Passageiro
    {

        #region atribultos
        private string nome;
        private int codigo;
        #endregion

        #region construtor
        public Passageiro(string nome, int codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
        }
        #endregion

        #region propriedades
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }
        #endregion

        #region metodos
        public String dadosCompletos()
        {
            return nome + "-" + codigo;
        }
        #endregion

    }
}
