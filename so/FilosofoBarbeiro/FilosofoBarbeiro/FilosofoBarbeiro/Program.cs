using System;
using System.Threading;

namespace FilosofoBarbeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Thread threadPrincipal = new Thread(new ThreadStart(Start));
            threadPrincipal.Start();
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
                        SituacaoDaMesa();
                        Thread.Sleep(3000);
                    }
                    
                case 2:
                    Console.WriteLine("Barbeiro");
                    break;


                default:
                    break;
            }
            




        }

        public static void CriarFilosofo(int n)
        {
            Filosofo[] filosofo = new Array
        }

        static Filosofo filosofo1 = new Filosofo();

        static Filosofo filosofo2 = new Filosofo();

        static Filosofo filosofo3 = new Filosofo();

        static Filosofo filosofo4 = new Filosofo();

        static Filosofo filosofo5 = new Filosofo();

        static Garfo garfo1 = new Garfo();

        static Garfo garfo2 = new Garfo();

        static Garfo garfo3 = new Garfo();

        static Garfo garfo4 = new Garfo();

        static Garfo garfo5 = new Garfo();

        static Random rand = new Random();

        static void Filosofo1Come()

        {

            if (garfo1.EstaEmUso || garfo5.EstaEmUso)

                return;

            garfo1.EstaEmUso = true;

            garfo5.EstaEmUso = true;

            int tempoComendo = rand.Next(2000, 5000);

            filosofo1.EstaPensando = false;

            Thread.Sleep(tempoComendo);

            filosofo1.EstaPensando = true;

            garfo1.EstaEmUso = false;

            garfo5.EstaEmUso = false;

        }
        static void Filosofo2Come()

        {

            if (garfo1.EstaEmUso || garfo2.EstaEmUso)

                return;

            garfo1.EstaEmUso = true;

            garfo2.EstaEmUso = true;

            int tempoComendo = rand.Next(2000, 5000);

            filosofo2.EstaPensando = false;

            Thread.Sleep(tempoComendo);

            filosofo2.EstaPensando = true;

            garfo1.EstaEmUso = false;

            garfo2.EstaEmUso = false;

        }

        static void Filosofo3Come()

        {

            if (garfo2.EstaEmUso || garfo3.EstaEmUso)

                return;

            garfo2.EstaEmUso = true;

            garfo3.EstaEmUso = true;

            int tempoComendo = rand.Next(2000, 5000);

            filosofo3.EstaPensando = false;

            Thread.Sleep(tempoComendo);

            filosofo3.EstaPensando = true;

            garfo2.EstaEmUso = false;

            garfo3.EstaEmUso = false;

        }

        static void Filosofo4Come()

        {

            if (garfo3.EstaEmUso || garfo4.EstaEmUso)

                return;

            garfo3.EstaEmUso = true;

            garfo4.EstaEmUso = true;

            int tempoComendo = rand.Next(2000, 5000);

            filosofo4.EstaPensando = false;

            Thread.Sleep(tempoComendo);

            filosofo4.EstaPensando = true;

            garfo3.EstaEmUso = false;

            garfo4.EstaEmUso = false;

        }

        static void Filosofo5Come()

        {

            if (garfo4.EstaEmUso || garfo5.EstaEmUso)

                return;

            garfo4.EstaEmUso = true;

            garfo5.EstaEmUso = true;

            int tempoComendo = rand.Next(2000, 5000);

            filosofo5.EstaPensando = false;

            Thread.Sleep(tempoComendo);

            filosofo5.EstaPensando = true;

            garfo4.EstaEmUso = false;

            garfo5.EstaEmUso = false;

        }

        static void Start()

        {

            Thread threadFilosofo1 = new Thread(new ThreadStart(Filosofo1Come));

            Thread threadFilosofo2 = new Thread(new ThreadStart(Filosofo2Come));

            Thread threadFilosofo3 = new Thread(new ThreadStart(Filosofo3Come));

            Thread threadFilosofo4 = new Thread(new ThreadStart(Filosofo4Come));

            Thread threadFilosofo5 = new Thread(new ThreadStart(Filosofo5Come));

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
        static void SituacaoDaMesa()

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
