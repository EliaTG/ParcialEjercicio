using System;
using System.Linq;

class Program{
static void Main(string[] args)
{
 
String [] nombres;
int [] salariomayor; 
void cargar(){
nombres = new String [6];
salariomayor = new int [6];
for (int i = 1; i <= 5; i++){
Console.WriteLine("Ingrese los nombres de los empleados ({0}) ",i);
nombres[i] =  Console.ReadLine();
//Salarios
Console.WriteLine("Ingrese los salarios de los empleados ({0}) ",i);
string pru;
pru = Console.ReadLine();
salariomayor[i] = int.Parse(pru);
} 
} 
void mostrar(){
Console.WriteLine("El empleado con el salario mayor es {0} ",nombres.Max());
Console.WriteLine("Tiene un salario de: {0}",salariomayor.Max());
} 
cargar();
mostrar();
}
}
