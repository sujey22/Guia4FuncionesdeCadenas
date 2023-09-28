using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

class CadenaEjercicio3
{
    public static void Main()
    {
        string texto = "MI MAMA ME MIMA, AMO A MI MAMA";
        string newtexto = texto.ToLower();
        Console.WriteLine("La cadena original es: " + texto);

        Console.WriteLine();
        Console.WriteLine("*****************************************");
        Console.WriteLine("Utilizando el Método ToLower");
        Console.WriteLine("*****************************************");
        Console.WriteLine("La nueva cadena utilizando el método de ponerlo en Minúsculas es: "+ newtexto);
        Console.WriteLine();


        Console.WriteLine("*****************************************");
        Console.WriteLine("Utilizando el Método Split");
        Console.WriteLine("*****************************************");

        string[] resultado1 = texto.Split(" ");
        string[] resultado2 = newtexto.Split(" ");

        Console.WriteLine("El resultado del texto en Mayúsculas es:  "  + texto);
        foreach(String str in resultado1) {
            Console.WriteLine(str); }
        Console.WriteLine();
        Console.WriteLine("El resultado del texto en Minúsculas es:  " + newtexto);
        foreach (String str2 in resultado2)
        {
            Console.WriteLine(str2);

        }

        Console.WriteLine();
        Console.WriteLine("*****************************************");
        Console.WriteLine("Longitud de Cadena");
        Console.WriteLine("*****************************************");


        for (int i = 0; i < resultado1.Length; i++)
        {
            
            if (resultado1[i].Length < 3)
            {
                
                resultado1[i] = resultado1[i] + "%";
            }
        }


        string ResultadoMa = string.Join(" ", resultado1);

        Console.WriteLine("Longitud de cadena en Mayúsculas:");
        Console.WriteLine(ResultadoMa);


        Console.WriteLine();
        for (int i = 0; i < resultado2.Length; i++)
        {

            if (resultado2[i].Length < 3)
            {

                resultado2[i] = resultado2[i] + "%";
            }
        }


        string ResultadoMi = string.Join(" ", resultado2);

 
        Console.WriteLine("Longitud de cadena en Minúsculas:");
        Console.WriteLine(ResultadoMi);

    }
}
