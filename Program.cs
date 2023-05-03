// See https://aka.ms/new-console-template for more information
Console.WriteLine("¡Hola! El siguiente programa solicitará dos números para sumar, restar, multiplicar y dividir ");
Console.WriteLine("Insertar el primer número");
var primernumero = Console.ReadLine();
int Numero1 = int.Parse(primernumero); 
Console.WriteLine("Insertar el segundo número");
var segundonumero = Console.ReadLine();
int Numero2 = int.Parse(segundonumero); 
        Console.WriteLine("La solución de sumar " + Numero1 + " y " + Numero2 + " es " + Sumar(Numero1, Numero2));
        Console.WriteLine("La solución de restar " + Numero1 + " y " + Numero2 + " es " + Restar(Numero1, Numero2));
        Console.WriteLine("La solución de multiplicar " + Numero1 + " y " + Numero2 + " es " + Multiplicar(Numero1, Numero2));
        Console.WriteLine("La solución de dividir " + Numero1 + " y " + Numero2 + " es " + Dividir(Numero1, Numero2));
        
        static int Sumar(int Sumando1, int Sumando2)
    {
        return Sumando1 + Sumando2;
    }

    static int Restar(int Minuendo, int Sustraendo)
    {
        return Minuendo - Sustraendo;
    }

    static int Multiplicar(int Factor1, int Factor2)
    {
        return Factor1 * Factor2;
    }

    static int Dividir(int Dividendo, int Divisor)
    {
            return Dividendo / Divisor;
    }