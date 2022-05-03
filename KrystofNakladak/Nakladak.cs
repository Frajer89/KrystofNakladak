using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrystofNakladak
{
    public class Nakladak
    {
        public int nosnost;
        public int objemnadrze;
        public int spotrebapaliva;
        public int celkovaujetavzdalenost;
        public int naklad;

        public string Jmeno { get; set; }
        public int Nosnost { get; set; }
        public int ObjemNadrze { get; set; }
        public int SpotrebaPaliva { get; set; }
        public int CelkovaUjetaVzdalenost { get; set; }
        public int Naklad { get => naklad; }
        
        public Nakladak()
        {
            Jmeno = " ";
            Nosnost = 25000;
            ObjemNadrze = 1000;
            SpotrebaPaliva = 35;
            CelkovaUjetaVzdalenost = 2000;
            naklad = 0;

        }

        public void Nalozit()
        {
            naklad += 1000;
            if (naklad > 25000)
            {
                naklad = 25000;
            }

            
        }

        public void Vylozit()
        {
            naklad -= 1000;
            if (naklad < 0)
            {
                naklad = 0;
            } 
        }

    }
    

    

}
