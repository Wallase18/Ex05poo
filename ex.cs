using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    interface IComparable
    {
        int CompareTo(object x);
    }
    class Candidato:IComparable
    {
        private string Nome;
        private DateTime Nascimento;
        private int Pontos;
        public Candidato(string N, DateTime Na,int P)
        {
            Nome = N;
            Nascimento = Na;
            Pontos = P;
        }
        public int CompareTo(object obj)
        {
            Candidato x = obj as Candidato;
            if (this.Pontos > x.Pontos) return 1;
            return this.Nome.CompareTo(x.Nome);
        }
        public override string ToString()
        {
            return $"{Nome} {Nascimento} {Pontos}";
        }
    }
    class Comcurso
    {
        private Candidato[] can = new Candidato[10];

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
