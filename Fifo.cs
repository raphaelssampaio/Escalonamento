using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processos
{
    public class Fifo
    {
        private double[] picos = new double[4];
        private double tempoEsperaMedio;
        private double tempoTurnAroundMedio;
        private static double tempoEsperaP2;
        private static double tempoEsperaP3;
        private static double tempoEsperaP4;

        // Gets e Sets
        public static double TempoEsperaP2
        {
            get
            {
                return tempoEsperaP2;
            }

            set
            {
                tempoEsperaP2 = value;
            }
        }
        public static double TempoEsperaP3
        {
            get
            {
                return tempoEsperaP3;
            }

            set
            {
                tempoEsperaP3 = value;
            }
        }
        public static double TempoEsperaP4
        {
            get
            {
                return tempoEsperaP4;
            }

            set
            {
                tempoEsperaP4 = value;
            }
        }



        public Fifo(double pico1, double pico2, double pico3, double pico4)
        {
            picos[0] = pico1;
            picos[1] = pico2;
            picos[2] = pico3;
            picos[3] = pico4;

        }
        
        public double EscalonaEspera()
        {
            double[] tempoEspera = new double[4];
            
            for(int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    tempoEspera[i] = 0;            
                }else if (i==1)
                { 
                    tempoEspera[i] = picos[i-1];
                }else
                {
                    tempoEspera[i] = tempoEspera[i - 1] + picos[i-1];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                tempoEsperaMedio += tempoEspera[i]; 
            }
                return (tempoEsperaMedio/4);
        }
        public double EscalonaTurnAround()
        {
            double[] tempoEspera = new double[4];
            double[] tempoTurnAround = new double[4];
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    tempoEspera[i] = 0;
                    tempoTurnAround[i] = picos[i];
                }
                else if (i == 1)
                {
                    tempoEspera[i] = picos[i-1];
                    tempoTurnAround[i] = (tempoEspera[i])*2 + picos[i];
                }
                else
                {
                    tempoEspera[i] = tempoEspera[i - 1] + picos[i - 1];
                    tempoTurnAround[i] = (tempoEspera[i])*2 + picos[i];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                tempoTurnAroundMedio += tempoTurnAround[i];
            }
            return (tempoTurnAroundMedio/4);
        }

        public double GuardarTempoEspera(int i)
        {
            TempoEsperaP2 = picos[0];
            TempoEsperaP3 = TempoEsperaP2 + picos[1];
            TempoEsperaP4 = TempoEsperaP3 + picos[2];

            switch (i)
            {
                case 1:
                    return 0;
                case 2:
                    return TempoEsperaP2;
                case 3:
                    return TempoEsperaP3;
                case 4:
                    return TempoEsperaP4;
                default:
                    return 0;
            }
           
        }
    }
}
