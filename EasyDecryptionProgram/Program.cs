﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDecryptionProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type your Command");
                switch (Console.ReadLine())
                {
                    default: return;


                    case "Decrypt":
                        Console.WriteLine("Seed:");
                        int SeedD = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Text:");
                        string TextD = Console.ReadLine();
                        Crypto cryptoD = new Crypto(SeedD);
                        Console.WriteLine(cryptoD.Decrypt(TextD));
                        break;

                    case "Encrypt":
                        Console.WriteLine("Seed:");
                        int SeedE = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Text:");
                        string TextE = Console.ReadLine();
                        Crypto cryptoE = new Crypto(SeedE);
                        Console.WriteLine(cryptoE.Encrypt(TextE));
                        break;

                    case "GenerateSeed":
                        Console.WriteLine(Crypto.GenerateSeed());
                        break;

                    case "Test":
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Convert.ToChar(i));
                        break;
                        
                }
            }

        }
    }
}
