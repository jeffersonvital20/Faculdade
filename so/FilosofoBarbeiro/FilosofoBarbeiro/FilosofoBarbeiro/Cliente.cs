using System;
using System.Collections.Generic;
using System.Text;

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
            while (cortar)
            {
                try
                {
                    int sleepTime;
                    do
                    {
                        sleepTime = ((int)(Math.random() * 5000));
                    } while (sleepTime < 1000);

                    Thread.sleep(sleepTime);
                    barbearia.aguardaVez(this);
                }
                catch (Exception e)
                {
                }
            }

        }
        public String nomeCliente()
        {
            return nomeCliente;
        }
    }
}
