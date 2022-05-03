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

        public string Jmeno { get; set; }
        public int Nosnost { get; set; }
        public int ObjemNadrze { get; set; }
        public int SpotrebaPaliva { get; set; }
        public int CelkovaUjetaVzdalenost { get; set; }
        
        public Nakladak()
        {
            Jmeno = " ";
            Nosnost = 25000;
            ObjemNadrze = 1000;
            SpotrebaPaliva = 35;
            CelkovaUjetaVzdalenost = 2000;

        }

    }
    

    

}
