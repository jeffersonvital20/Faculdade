using System;
using System.Threading;

namespace FilosofoBarbeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Filosofo filo = new Filosofo();
            //Console.WriteLine("Hello World!");
            //Thread threadPrincipal = new Thread(new ThreadStart(filo.Start));
            //threadPrincipal.Start();
            Console.WriteLine(10 * '-');
            Console.WriteLine("| 1 | Filosofo ");
            Console.WriteLine("| 2 | Barbeiro ");
            Console.WriteLine(10* '-');
            Console.WriteLine("Escolha uma da opocões");
            var escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    while (true)
                    {
                        //filo.SituacaoDaMesa();
                        Thread.Sleep(3000);
                    }
                    
                case 2:
                    Console.WriteLine("Barbeiro");
                    break;


                default:
                    break;
            }
        }
        void Start(int n)
        {
            Thread threadFilosofo1 = new Thread(new ThreadStart(Filosofo1Come()));
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
        void SituacaoDaMesa()
        {
            string situacaoFilosofo1 = filosofo1.EstaPensando ? "PENSANDO" : "COMENDO";
            Console.WriteLine(string.Format("Filósofo 1 está: {0}", situacaoFilosofo1));
            string situacaoFilosofo2 = filosofo2.EstaPensando ? "PENSANDO" : "COMENDO";
            Console.WriteLine(string.Format("Filósofo 2 está: {0}", situacaoFilosofo2));
            string situacaoFilosofo3 = filosofo3.EstaPensando ? "PENSANDO" : "COMENDO";
            Console.WriteLine(string.Format("Filósofo 3 está: {0}", situacaoFilosofo3));
            string situacaoFilosofo4 = filosofo4.EstaPensando ? "PENSANDO" : "COMENDO";
            Console.WriteLine(string.Format("Filósofo 4 está: {0}", situacaoFilosofo4));
            string situacaoFilosofo5 = filosofo5.EstaPensando ? "PENSANDO" : "COMENDO";
            Console.WriteLine(string.Format("Filósofo 5 está: {0}", situacaoFilosofo5));
            Console.WriteLine("");
        }




    }
}
