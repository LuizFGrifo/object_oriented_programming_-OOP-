using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            //    MinhaClasse minhaClasse = new MinhaClasse();
            //    MinhaClasse m2 = null;

            //    OutraClasse outra = new OutraClasse();
            //    OutraClasse outra2 = outra;
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Luiz Felipe";
            p1.sobrenome = "Grifo";
            p1.anoNacimento = 2003;

            Pessoa p2 = new Pessoa()
            {
                nome = "Afonso",
                sobrenome = "Batista",
                anoNacimento = 1996
            };

            Console.WriteLine("Pessoa 01 | nome: " + p1.nome);
            Console.WriteLine("Pessoa 01 | sobrenome: " + p1.sobrenome);
            Console.WriteLine("Pessoa 01 | ano nacimento: " + p1.anoNacimento);
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Pessoa 02 | nome: " + p2.nome);
            Console.WriteLine("Pessoa 02 | sobrenome: " + p2.sobrenome);
            Console.WriteLine("Pessoa 02 | ano nacimento: " + p2.anoNacimento);
            p2.Cumprimentar();

            Console.ReadKey();
        }
    }

    class MinhaClasse 
    {
        
    }
}
