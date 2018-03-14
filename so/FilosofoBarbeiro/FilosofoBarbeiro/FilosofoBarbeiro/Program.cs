﻿using System;
using System.Threading;

namespace FilosofoBarbeiro
{
    class Program
    {
        public static Filosofo filosofo = new Filosofo();
        public static Filosofo[] filosofos;
        public static Garfo garfo = new Garfo();
        public static Garfo[] garfos;
        public static int numeroFilosofos { get; set; }
        static void Main(string[] args)
        {
           
            //Console.WriteLine("Hello World!");
            
            Console.WriteLine("----------------");
            Console.WriteLine("| 1 | Filosofo |");
            Console.WriteLine("| 2 | Barbeiro |");
            Console.WriteLine("----------------");
            Console.WriteLine("Escolha uma da opocões");
            var escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Thread threadPrincipal = new Thread(new ThreadStart(Start));
                    threadPrincipal.Start();

                    Console.WriteLine("Quantos filosofos vão participar do jantar?");
                    numeroFilosofos = Convert.ToInt32(Console.ReadLine());
                    
                    while (true)
                    {
                        SituacaoDaMesa(numeroFilosofos);
                        Thread.Sleep(3000);
                    }
                    
                case 2:
                    Console.WriteLine("Barbeiro");
                    break;


                default:
                    break;
            }
        }
       
        static void Start()
        {
            Thread[] threadFilosofo1 = new Thread(new ThreadStart(filosofos[0].Filosofo1Come(filosofos,garfos)));

            //Thread threadFilosofo2 = new Thread(new ThreadStart(Filosofo2Come));

            //Thread threadFilosofo3 = new Thread(new ThreadStart(Filosofo3Come));

            //Thread threadFilosofo4 = new Thread(new ThreadStart(Filosofo4Come));

            //Thread threadFilosofo5 = new Thread(new ThreadStart(Filosofo5Come));

            while (true)

            {

                if (!threadFilosofo1.IsAlive)

                {

                    threadFilosofo1 = new Thread(new ThreadStart(Filosofo1Come));

                    threadFilosofo1.Start();

                }

                if (!threadFilosofo2.IsAlive)

                {

                    threadFilosofo2 = new Thread(new ThreadStart(Filosofo2Come));

                    threadFilosofo2.Start();

                }

                if (!threadFilosofo3.IsAlive)

                {

                    threadFilosofo3 = new Thread(new ThreadStart(Filosofo3Come));

                    threadFilosofo3.Start();

                }

                if (!threadFilosofo4.IsAlive)

                {

                    threadFilosofo4 = new Thread(new ThreadStart(Filosofo4Come));

                    threadFilosofo4.Start();

                }

                if (!threadFilosofo5.IsAlive)

                {

                    threadFilosofo5 = new Thread(new ThreadStart(Filosofo5Come));

                    threadFilosofo5.Start();

                }

            }

        }
        static void SituacaoDaMesa(int n)
        {
            filosofos = filosofo.CriarFilosofo(n);
            garfos = garfo.CriarGarfo(n);
            for (int i = 0; i < n; i++)
            {
                string situacaoFilosofo = filosofos[n].EstaPensando ? "PENSANDO" : "COMENDO";
                Console.WriteLine(string.Format("Filósofo "+n +"está: {0}", situacaoFilosofo));

            }
            Console.WriteLine("");


            //string situacaoFilosofo2 = filosofo2.EstaPensando ? "PENSANDO" : "COMENDO";
            //Console.WriteLine(string.Format("Filósofo 2 está: {0}", situacaoFilosofo2));
            //string situacaoFilosofo3 = filosofo3.EstaPensando ? "PENSANDO" : "COMENDO";
            //Console.WriteLine(string.Format("Filósofo 3 está: {0}", situacaoFilosofo3));
            //string situacaoFilosofo4 = filosofo4.EstaPensando ? "PENSANDO" : "COMENDO";
            //Console.WriteLine(string.Format("Filósofo 4 está: {0}", situacaoFilosofo4));
            //string situacaoFilosofo5 = filosofo5.EstaPensando ? "PENSANDO" : "COMENDO";
            //Console.WriteLine(string.Format("Filósofo 5 está: {0}", situacaoFilosofo5));

        }




    }
}
