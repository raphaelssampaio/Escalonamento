using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processos
{
    class ClasseProcessos
    {

        // Variáveis do processo
        private int ordemChegada;
        private string nomeProcesso;
        private int tempoEspera;
        private int tempoExecucao;
        private double tempoEsperaMedio;
        private int tempoTurnAround;
        private double tempoTurnAroundMedio;

        // Construtor

        public ClasseProcessos(String nomeProcesso) {
            this.nomeProcesso = nomeProcesso;
        }

         // Gets e Sets
        public int OrdemChegada
        {
            get
            {
                return ordemChegada;
            }

            set
            {
                ordemChegada = value;
            }
        }
        public string NomeProcesso
        {
            get
            {
                return nomeProcesso;
            }

            set
            {
                nomeProcesso = value;
            }
        }
        public int TempoEspera
        {
            get
            {
                return tempoEspera;
            }

            set
            {
                tempoEspera = value;
            }
        }
        public int TempoExecucao
        {
            get
            {
                return tempoExecucao;
            }

            set
            {
                tempoExecucao = value;
            }
        }
        public double TempoEsperaMedio
        {
            get
            {
                return tempoEsperaMedio;
            }

            set
            {
                tempoEsperaMedio = value;
            }
        }
        public int TempoTurnAround
        {
            get
            {
                return tempoTurnAround;
            }

            set
            {
                tempoTurnAround = value;
            }
        }
        public double TempoTurnAroundMedio
        {
            get
            {
                return tempoTurnAroundMedio;
            }

            set
            {
                tempoTurnAroundMedio = value;
            }
        }

       
    }
}
