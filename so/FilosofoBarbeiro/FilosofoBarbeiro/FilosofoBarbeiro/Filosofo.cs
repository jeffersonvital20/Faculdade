using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FilosofoBarbeiro
{
    class Filosofo
    {
        public bool EstaPensando { get; set; }
        private Random rand = new Random();

        public Filosofo()
        {
            EstaPensando = true;
        }

        public Filosofo[] CriarFilosofo(int n)
        {
            Filosofo[] filosofo = new Filosofo[n];
            return filosofo;
        }
         

        void Filosofo1Come(Filosofo[] filo,Garfo[] garfo)
        {
            if (garfo[1].EstaEmUso || garfo[garfo.Length].EstaEmUso)
                return;

            garfo[1].EstaEmUso = true;

            garfo[garfo.Length].EstaEmUso = true;

            int tempoComendo = rand.Next(2000, 5000);

            filo[1].EstaPensando = false;

            Thread.Sleep(tempoComendo);

            filo[1].EstaPensando = true;

            garfo[1].EstaEmUso = false;

            garfo[garfo.Length].EstaEmUso = false;

        }

        void Filosofo2Come(Filosofo[] filo, Garfo[] garfo, int n)
        {

            if (garfo[1].EstaEmUso || garfo[n].EstaEmUso)
                return;

            garfo[1].EstaEmUso = true;

            garfo[n].EstaEmUso = true;

            int tempoComendo = rand.Next(2000, 5000);

            filo[n].EstaPensando = false;

            Thread.Sleep(tempoComendo);

            filo[n].EstaPensando = true;

            garfo[1].EstaEmUso = false;

            garfo[n].EstaEmUso = false;

        }

        //static void Filosofo3Come()

        //{

        //    if (garfo2.EstaEmUso || garfo3.EstaEmUso)

        //        return;

        //    garfo2.EstaEmUso = true;

        //    garfo3.EstaEmUso = true;

        //    int tempoComendo = rand.Next(2000, 5000);

        //    filosofo3.EstaPensando = false;

        //    Thread.Sleep(tempoComendo);

        //    filosofo3.EstaPensando = true;

        //    garfo2.EstaEmUso = false;

        //    garfo3.EstaEmUso = false;

        //}

        //static void Filosofo4Come()

        //{

        //    if (garfo3.EstaEmUso || garfo4.EstaEmUso)

        //        return;

        //    garfo3.EstaEmUso = true;

        //    garfo4.EstaEmUso = true;

        //    int tempoComendo = rand.Next(2000, 5000);

        //    filosofo4.EstaPensando = false;

        //    Thread.Sleep(tempoComendo);

        //    filosofo4.EstaPensando = true;

        //    garfo3.EstaEmUso = false;

        //    garfo4.EstaEmUso = false;

        //}

        //static void Filosofo5Come()

        //{

        //    if (garfo4.EstaEmUso || garfo5.EstaEmUso)

        //        return;

        //    garfo4.EstaEmUso = true;

        //    garfo5.EstaEmUso = true;

        //    int tempoComendo = rand.Next(2000, 5000);

        //    filosofo5.EstaPensando = false;

        //    Thread.Sleep(tempoComendo);

        //    filosofo5.EstaPensando = true;

        //    garfo4.EstaEmUso = false;

        //    garfo5.EstaEmUso = false;

        //}

       

    }
}
