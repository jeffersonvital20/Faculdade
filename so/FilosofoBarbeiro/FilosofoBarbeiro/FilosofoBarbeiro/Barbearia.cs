using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FilosofoBarbeiro
{
    class Barbearia
    {
        private int qtdeCadeiras = 5;
        private bool dormindo = true;
        private LinkedBlockingQueue<Cliente> clientesNaFila = new LinkedBlockingQueue<>();
        private int qtdeClienteAtendidos = 0;
        private List<Cliente> clientesJaAtendidos = new List<Cliente>();
        bool cortando = false;

        public synchronized void cortarCabelo()
        {
            Random rand = new Random();
            try
            {
                while (clientesNaFila.size() == 0)
                {
                    Console.WriteLine("Não tem nenhum cliente esperando, o barbeiro resolveu dormir");
                    wait();
                    Console.WriteLine("Barbeiro continua seu trabalho..........");
                }

                String nameCli = clientesNaFila.peek().nomeCliente();
                if (clientesNaFila.size() > 0)
                {
                    clientesNaFila.poll();
                    cortando = true;
                    Console.WriteLine("Aguarde enquando o " + nameCli + " é atendido......");
                    Thread.Sleep(rand.Next(0,5000));     //((int)(Math.random() * 5000));
                    qtdeClienteAtendidos++;
                    Console.WriteLine("Foram atendidos " + qtdeClienteAtendidos + " clientes");
                }
                notifyAll();
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public synchronized void aguardaVez(Cliente cliente)
        {
            try
            {
                if (!clientesJaAtendidos.contains(cliente))
                {
                    if (clientesNaFila.size() < qtdeCadeiras)
                    {
                        clientesNaFila.offer(cliente);
                        clientesJaAtendidos.add(cliente);
                        System.out.println("Quantidade clientes esperando para cortar = " + clientesNaFila.size());
                    }
                    else
                    {
                        System.out.println("Um Cliente chegou mas não existem cadeiras vazias, ele voltará em breve.");
                        Thread.sleep((int)(Math.random() * 3000));
                    }
                }

                while (clientesNaFila.size() < qtdeCadeiras)
                {
                    if (dormindo)
                    {
                        System.out.println("Acordando o barbeiro...");
                        notify();
                        dormindo = false;
                    }
                    wait();
                }
                notifyAll();

            }
            catch (InterruptedException e)
            {
                e.printStackTrace();
            }
        }

        public LinkedBlockingQueue<Cliente> getFilaClientes()
        {
            return clientesNaFila;
        }

        public boolean isCortando()
        {
            return cortando;
        }

        public boolean isDormindo()
        {
            return dormindo;
        }
        public int getAtendidos()
        {
            return qtdeClienteAtendidos;
        }

    }
}
