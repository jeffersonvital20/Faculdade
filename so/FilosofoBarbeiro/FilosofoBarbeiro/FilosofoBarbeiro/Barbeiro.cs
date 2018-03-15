﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FilosofoBarbeiro
{
    class Barbeiro
    {
        private Barbearia barbearia;
        private bool cortar = true;

        public Barbeiro(Barbearia barbearia)
        {
            this.barbearia = barbearia;
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
                    barbearia.cortarCabelo();
                }
                catch (Exception e)
                {
                }
            }
        }

    }
}
