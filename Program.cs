// See https://aka.ms/new-console-template for more information
using EspacioCalculadora; 

Calculadora NuevaCalc = new Calculadora();

do
{
    
Console.WriteLine("Ingrese que desea hacer");
Console.WriteLine("Sumar");
Console.WriteLine("Restar");
Console.WriteLine("Dividir");
Console.WriteLine("Multiplicar");
Console.Read();
NuevaCalc.sumar(10);
NuevaCalc.dividir(5);
Console.WriteLine(NuevaCalc.Resultado);

} while (opcion<=6);