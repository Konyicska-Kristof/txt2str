using System.Security.Cryptography;
using System.Text;

namespace txt2srt
{    
    internal class Program
    {                       
        static void Main(string[] args)
        {            
            List<IdozitettFelirat> feliratok = new();

            using StreamReader sr = new(@"..\..\..\src\feliratok.txt", Encoding.UTF8);            

            while (!sr.EndOfStream)
            {
                feliratok.Add(new IdozitettFelirat(idozites: sr.ReadLine(), felirat: sr.ReadLine()));
            }

            Console.WriteLine($"5. Feladat - Feliratok száma: {feliratok.Count()}");

            Console.WriteLine($"7. Feladat - Legtöbb szóból álló felirat:");

            var f7 = feliratok.MaxBy(f => f.Szavakszama);
            Console.WriteLine(f7.Felirat);

            using StreamWriter sw = new(@"..\..\..\src\felirat.srt", false);
            
            for (int i = 0; i < feliratok.Count; i++)
            {
                sw.Write($"{i + 1}\n{feliratok[i].SrtIdozites}\n{feliratok[i].Felirat}\n\n");
            }          
        }
    }
}