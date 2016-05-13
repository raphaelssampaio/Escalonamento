using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processos
{
    public class Escalonamentos
    {
        // Variável do nome do escalonamento
        private String nomeEscalonamento;

        // Get e Set
        public string NomeEscalonamento
        {
            get
            {
                return nomeEscalonamento;
            }

            set
            {
                nomeEscalonamento = value;
            }
        }

        // Construtor
        public Escalonamentos(String nomeEscalonamento)
        {
            this.nomeEscalonamento = nomeEscalonamento;
        }
    }
}
