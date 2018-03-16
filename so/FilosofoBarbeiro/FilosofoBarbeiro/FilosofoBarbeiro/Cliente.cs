using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FilosofoBarbeiro
{
    class Cliente
    {
        private Barbearia barbearia;
        private bool cortar = true;
        private String nomeCliente { get; set; }

        public Cliente(Barbearia barbearia, String nome)
        {
            this.barbearia = barbearia;
            nomeCliente = nome;
        }

        public void run()
        {
            Random rand = new Random();
            while (cortar)
            {
                try
                {
                    int sleepTime;
                    do
                    {
                        sleepTime = rand.Next(0, 5000);   //((int)(Math.random() * 5000));
                    } while (sleepTime < 1000);

                    Thread.Sleep(sleepTime);
                    barbearia.aguardaVez(this);
                }
                catch (Exception e)
                {
                }
            }

        }
     }
}
