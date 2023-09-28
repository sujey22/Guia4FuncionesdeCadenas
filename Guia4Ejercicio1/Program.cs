using System;
class CadenaEjercicio1
{
    public static void Main()
    {
        Console.WriteLine("Ingrese una cadena de caracteres");
        string? inputString = Console.ReadLine();
        if (inputString?.Length < 25)
        {
            Console.WriteLine("Por donde quiere rellenar, si es por izquierda marque (1) y si es por la derecha marque  (2)");
            char num = Char.ToUpper(Console.ReadKey().KeyChar);

            if (num == '1')
            {
                int rellenoizq = 25 - inputString.Length;
                string Conrelle = new string('$', rellenoizq) + inputString;
                Console.WriteLine("\nSu resultado con relleno al lado izquierdo es: " + Conrelle);
            }
            else if (num == '2')
            {

                int rellenodere = 25 - inputString.Length;
                string Conrelle = inputString + new string('$', rellenodere);
                Console.WriteLine("\nSu resultado con relleno al lado derecho es: " + Conrelle);
            }
            else
            {
                Console.WriteLine("\nOpción no válida. Debe de elegir '1' o '2'.");
            }
        }
        else
        {
            Console.WriteLine("\nLa cadena ingresada tiene mas de 25 o 25 caracteres. Por lo que no es necesario rellenar.");
        }
    }
}

