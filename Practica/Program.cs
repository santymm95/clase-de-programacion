using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos*/

            //Console.Write("Numeros positivos\n");
            //Console.Write("Numero 1: ");
            //double numero1 = double.Parse(Console.ReadLine());

            //Console.Write("\nNumero 2: ");
            //double numero2 = double.Parse(Console.ReadLine());

            //Console.Write("\nNumero 3: ");
            //double numero3 = double.Parse(Console.ReadLine());

            //double resultado = numero1 + numero2+numero3;

            //if (numero1 == numero2 && numero2 == numero3 && numero3 == numero1)
            //{
            //    Console.WriteLine("Es triangulo rectanglo: ");
            //    Console.WriteLine(resultado);
            //}
            //else
            //{
            //    Console.WriteLine("No Es triaglo");
            //}


            /*Un vendedor recibe un sueldo base más un 10 % extra por comisión de sus ventas, 
            el vendedor desea saber cuánto dinero obtendrá por concepto de comisiones por
            las tres ventas que realiza en el mes y el total que recibirá en el mes tomando en
            cuenta su sueldo base y comisiones. */

            //double sueldo = 1000000;

            //double porcentaje = (1000000 * 10) / 100;

            //double ventas = 3;

            //double result = porcentaje * ventas;

            //double totalRecibido = result + sueldo;


            //Console.Write(totalRecibido);


            /*Escribir un algoritmo que dados 2 valores de entrada imprima siempre la división del 
            mayor entre el menor. Validar indeterminación.*/



            Console.Write("Ingrese el numero 1: ");
            
            int num1 = int.Parse(Console.ReadLine());

            Console.Write(" \nIngrese el numero 2: ");

            int num2 =int.Parse(Console.ReadLine());


            if (num1 > num2)
            {
                    
                 int resul = num1 / num2;
                Console.Write(resul);

            }else{ 
                int resul = num2 / num1;
                Console.Write(resul);
            }









        }
    }
}
