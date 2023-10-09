namespace Ejercicio1Operadores;

/// <summary>
/// Aquí irá la suma de los números, aparte de darles valor.
/// </summary>
class Program
{
    public static void Main(string[] args)
    {


        int seleccion1, seleccion2, resultado; 
       
        

        Console.WriteLine("Elige un número: ");
        seleccion1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escoge otro número: ");
        seleccion2 = int.Parse(Console.ReadLine());
        resultado = seleccion1 + seleccion2;
        Console.WriteLine("El resultado es: " +  resultado);
        Console.ReadLine();

    }
}