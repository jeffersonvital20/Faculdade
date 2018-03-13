using System;
using System.Collections.Generic;
using System.Text;

namespace FilosofoBarbeiro
{
    class Garfo
    {
        public bool EstaEmUso { get; set; }
        public Garfo()
        {
            EstaEmUso = false;
        }
        public Garfo[] CriarGarfo(int n)
        {
            Garfo[] garfo = new Garfo[n];
            return garfo;
        }

    }
}
