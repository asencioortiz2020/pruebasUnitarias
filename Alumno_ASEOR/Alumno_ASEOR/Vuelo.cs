using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno_ASEOR
{
    public class Vuelo
    {

        private int numPlazas;
        private string nif;



        public Vuelo()
        {

            //this.numPlazas = nplazas;
            //this.nif = dni;

        }

        //nif (8 caracteres y letra)
        //nplazas max 50 y min 1
        public int NumPlazas
        {
            get { return numPlazas; }
            set
            {
                numPlazas = value;
            }
        }
        public string Nif
        {
            get { return nif; }
            set
            {
                nif = value;
               
            }
        }


        public void Dni_Novalido(string dni)
        {
            if(nif.Length < 7)
            {
                
            
                throw new ArgumentOutOfRangeException("menos mal dni");
            }
            if (nif.Length > 7)
            {
               

                throw new Exception("mal dni");
            }
            if (nif == null)
            {
                

                throw new ArgumentNullException("NULO");
            }



        }
        public void SetPlazas(int plaza)
        {
            if(numPlazas >= 1 && numPlazas <= 50)
            {
                this.numPlazas = plaza;
            }
            else
            {
                throw new Exception("mal plaza");
            }
        }

    }
    
}
