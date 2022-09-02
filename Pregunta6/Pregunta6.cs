using System;

public class Pregunta6
{
    public static void Main()
    {
        //�Cu�l es la diferencia entre la sentencia for y foreach? �Cu�ndo se debe utilizar cada una de ellas?


        // La instrucci�n for: ejecuta su cuerpo mientras una expresi�n booleana especificada se eval�e como true.
        // El bucle for se puede utilizar cuando en el cuerpo es necesario obtener la posicion del array
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i);
        }

        // La instrucci�n foreach: enumera los elementos de una colecci�n y ejecuta su cuerpo para cada elemento de la colecci�n.
        // foreach mantiene una sintaxis mas clara a la hora de poder analizarlo
        var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
        foreach (int element in fibNumbers)
        {
            Console.Write($"{element} ");
        }
    }
}