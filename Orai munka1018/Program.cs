using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Orai_munka1018
{
    class Program
    {
        static Dictionary<string, List<Jatekos>> csapatok;
        static void Main(string[] args)

        {
            Beolvas();
            Teszt();
            Console.ReadKey();
        }

        private static void Teszt()
        {
            foreach (var cs in csapatok.Keys)
            {
                Console.WriteLine(cs);
            }
        }

        private static void Beolvas()
        {
            csapatok = new Dictionary<string, List<Jatekos>>();
            var sr = new StreamReader($"NBA2003.csv", Encoding.UTF8);
        sr.ReadLine();
            while (!sr.EndOfStream)
            {
            var tmp = sr.ReadLine().Split(';');

                if (!csapatok.ContainsKey(tmp[0].Trim('"')))
                {

                    csapatok.Add(tmp[0].Trim('"'), new List<Jatekos>());
                }

                csapatok[tmp[0].Trim('"')].Add(new Jatekos(tmp[1].Trim('"'),

          int.Parse(tmp[2]),
          int.Parse(tmp[3])));

            }
            sr.Close();
}
      
    }
    }

