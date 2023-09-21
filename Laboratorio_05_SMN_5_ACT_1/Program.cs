// See https://aka.ms/new-console-template for more information

//Escribir un programa que permita multiplixar dos numeros enteros sin usar el operador "*"

int num1 = 4;
int num2 = 2;
int Resultado = 0;

for (int  i = 0; i < num1; i++)
{
    Resultado = Resultado + num2;

}
Console.WriteLine("Ingrese el numero: " + num1);
Console.WriteLine("Ingrese el numero: " + num2);
Console.WriteLine("El producto es: " + Resultado);
Console.ReadKey();