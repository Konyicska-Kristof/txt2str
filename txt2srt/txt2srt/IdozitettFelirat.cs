using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace txt2srt
{
    internal class IdozitettFelirat
    {
        public string Idozites;
        public string Felirat;
        public IdozitettFelirat(string Sor)
        {
            int i = 0;
            bool not_int = false;
            while (i<10 || not_int!=true)
            {
                if (Sor.First() != char.Parse(i.ToString()))
                {
                    not_int = true;
                }
                i++;
                
            }

            if (not_int==true)
            {
                Felirat = Sor;
            }
            else
            {
                 Idozites = Sor;
            }
            

        }

    }
}
