﻿using System; 

class minhaClasse 
{
    static void Main(string[] args) 
    { 

        double a, b, c, delta, r1, r2;
        string[] valor = Console.ReadLine().Split();

        a = Convert.ToDouble(valor[0]);
        b = Convert.ToDouble(valor[1]);
        c = Convert.ToDouble(valor[2]);
        
        delta = (Math.Pow(b, 2) - (4 * a * c));
        if (a == 0  || delta < 0)
        {
           System.Console.WriteLine("Impossivel calcular");
        }
        else
        {
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);
            System.Console.WriteLine($"R1 = {Math.Round(r1, 5)}");
            System.Console.WriteLine($"R2 = {Math.Round(r2, 5)}");
        }
    }
}