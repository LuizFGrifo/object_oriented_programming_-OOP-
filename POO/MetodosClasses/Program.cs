using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            #region Métodos Simples
            //m.Cumprimentar();
            #endregion

            #region Métodos com parâmetro
            //m.Somar(10,9);
            //m.Apresentar("Luiz Grifo", 18);
            #endregion

            #region Passagem de parâmetro por valor e por referência
            //int valor1 = 100;
            //int valor2 = 100;
            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2);
            #endregion

            #region Métodos com retorno de valores 
            //string nomeCompleto = m.MontaNome("Luiz Felipe", "Grifo");
            //int codigoChar = m.CodigoChar('a');
            //double pi = m.ValorPI();

            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(codigoChar);
            //Console.WriteLine(pi);
            #endregion

            #region Sobrecarga de método (Overloading) 
            //m.Cumprimentar();
            //m.Cumprimentar("Luiz");
            //m.Cumprimentar("Luiz ", 11);

            //bool res1 = m.Comparar(100, 50 * 2);
            //bool res2 = m.Comparar("Luiz","luiz");

            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            #endregion

            Console.ReadKey();
        }
    }
}
