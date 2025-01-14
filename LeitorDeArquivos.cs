﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public  class LeitorDeArquivos: IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo) 
        {
            Arquivo = arquivo;

            //throw new FileNotFoundException();

            Console.WriteLine("Abrir arquivo: " + arquivo);
        }
        
        public string LerProximaLinha()
        {
            Console.WriteLine("lendo linha . . .");

            throw new IOException();

            return "Linha do arquivo";
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }

    }
}
