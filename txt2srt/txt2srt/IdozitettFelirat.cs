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

        public int Szavakszama => Felirat.Split().Length;

        public string SrtIdozites
        {
            get
            {
                var ti = Idozites.Split(" - ");

                var top = ti[0].Split(":");
                var iop = ti[1].Split(":");

                TimeSpan tol = new(hours: 0, minutes:  int.Parse(top[0]), seconds: int.Parse(top[1]));
                TimeSpan ig = new(hours: 0, minutes: int.Parse(iop[0]), seconds: int.Parse(iop[1]));

                return $"{tol} --> {ig}"; 
            }
        }
        public IdozitettFelirat(string idozites, string felirat)
        {
            Idozites = idozites;
            Felirat = felirat;            
        }



    }
}
