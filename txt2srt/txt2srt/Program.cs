using System.Text;

namespace txt2srt
{    
    internal class Program
    {                       
        static void Main(string[] args)
        {
            List<string> L_Idoz = new();
            List<string> L_Fel = new();

            using StreamReader sr = new(@"..\..\..\src\feliratok.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                L_Idoz.Add(new IdozitettFelirat(sr.ReadLine()).Idozites);
                L_Fel.Add(new IdozitettFelirat(sr.ReadLine()).Felirat);
            }

            Console.WriteLine($"5. Feladat - Feliratok száma: {L_Fel.Count()}");
        }
    }
}