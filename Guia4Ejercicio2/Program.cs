using System;


//Metodos utilizados CompareTo y Equals.
class CadenaEjer2
{
    public static void Main()
    {
        Console.WriteLine("Ingrese la primera cadena de caracteres: ");
        string? cadena1 = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Ingrese la segunda cadena de caracteres: ");
        string? cadena2 = Console.ReadLine();


        Console.WriteLine();

        //Usando metodo CompareTo
        int resultCompareTo = cadena1.CompareTo(cadena2);

        if (resultCompareTo == 0)
        {
            Console.WriteLine("Las cadenas son iguales según el metodo CompareTo().");
        }
        else if (resultCompareTo < 0)
        {
            Console.WriteLine("La primera cadena es menor que la segunda cadena según el metodo CompareTo().");
        }
        else
        {
            Console.WriteLine("La primera cadena es mayor que la segunda cadena según el metodo CompareTo().");
        }

        Console.WriteLine();
        //Usando el metodo Equals

        bool SonIguales = cadena1.Equals(cadena2, StringComparison.Ordinal);

        if (SonIguales)
        {
            Console.WriteLine("Las cadenas son iguales según el metodo Equals().");
        }
        else
        {
            Console.WriteLine("Las cadenas son diferentes según el metodo Equals().");
        }


    }
}