using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseObjeto
{
    internal class Pessoa
    {   
        // Atributos  | Campos
        public string nome;
        public string sobrenome;
        public int anoNacimento;

        // Métodos simples 
        public void Cumprimentar()
        {
            Console.WriteLine("Olá eu sou " + nome + " " + sobrenome + " nacido em " + anoNacimento);
        }
    }
}
