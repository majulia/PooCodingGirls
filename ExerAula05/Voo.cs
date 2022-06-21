using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerAula05
{
    internal class Voo
    {
        public int numeroPoltrona { get; set; }
        int[] lugares = new int[101];
        int lugaresVagos;
        string msg;

        public string OcuparPoltrona()
        {
            for (int i = 1; i < lugares.Length; i++)
            {
                if (lugares[i] == 0)
                {
                    lugares[i] = numeroPoltrona;
                    msg = "A Poltrona " + numeroPoltrona + " está livre";
                    lugaresVagos = i - 1;

                }
                else
                {
                    msg = "Lugar Ocupado";                   
                }

            }
            return msg;
        }

        public int VagasLivre()
        {
            return lugaresVagos;
        }       
    }
}
