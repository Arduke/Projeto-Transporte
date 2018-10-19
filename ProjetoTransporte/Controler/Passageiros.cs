using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte
{
    class Passageiros
    {
        #region Atributos
        private int proximoId;
        private Queue<Passageiro> filaPassageiros;
        #endregion


        #region propriedades
        public int ProximoId
        {
            get
            {
                return proximoId;
            }

            set
            {
                proximoId = value;
            }
        }
        #endregion

        #region proteção
        public Queue<Passageiro> Filapassageiros
        {
            get { return filaPassageiros; }
        }

        
        #endregion

        #region construtor
        public Passageiros()
        {
            filaPassageiros = new Queue<Passageiro>();
            this.proximoId = 1;
        }
        #endregion

        #region metodo
        public void gerar(String nome)
        {
            Filapassageiros.Enqueue(new Passageiro(nome,proximoId));
            proximoId++;
        }
        #endregion
    }
}
