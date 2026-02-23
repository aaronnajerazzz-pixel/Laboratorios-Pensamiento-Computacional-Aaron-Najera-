using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_AANM_1059726
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Escribe un numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("Tu numero es 0");
            }
            else
            {
                if (num > 0)
                {
                    Console.WriteLine("Tu numero es positivo");
                }
                else
                {
                    Console.WriteLine("Tu numero es negativo");
                }
            }
            //Ejercicio 2 
            int anniobis;
            Console.WriteLine("Escribe un annio");
            anniobis = Convert.ToInt32(Console.ReadLine());
            if ((anniobis % 4 == 0 && anniobis % 100 != 0 || anniobis % 400 == 0))
            {
                Console.WriteLine("El annio es bisiesto");
            }
            else
            {
                Console.WriteLine("El annio no es bisiesto");
            }
            //Ejercicio 
            Console.WriteLine("Ingresa tu salario Mensual");
            string Salario = Console.ReadLine();  
            double Salarioo = double.Parse(Salario);
            Console.WriteLine("Tienes alguna Multa? ans TRUE/FALSE");
            bool multa = bool.Parse(Console.ReadLine());
            if (Salarioo >= 500.01 && Salarioo <= 1000.00)
            {
                if (multa == true)
                {
                    Console.WriteLine("Usted pagara: " + (10 + 20));
                }
                else
                {
                    Console.WriteLine("Usted pagara: " + (10));
                }
            }
            else if (Salarioo >= 1000.01 && Salarioo <= 3000.00)
            {
                if (multa == true)
                {
                    Console.WriteLine("Usted pagara: " + (15 + 30));
                }
                else
                {
                    Console.WriteLine("Usted pagara: " + (15));
                }
            }
            else if (Salarioo >= 3000.01 && Salarioo <= 6000.00)
            {
                if (multa == true)
                {
                    Console.WriteLine("Usted pagara: " + (50 + 100));
                }
                else
                {
                    Console.WriteLine("Usted pagara: " + (50));
                }
            }
            else if (Salarioo >= 6000.01 && Salarioo <= 9000.00)
            {
                if (multa == true)
                {
                    Console.WriteLine("Usted pagara: " + (75 + 150));
                }
                else
                {
                    Console.WriteLine("Usted pagara: " + (75));
                }
            }
            else if (Salarioo >= 9000.01 && Salarioo <= 12000.00)
            {
                if (multa == true)
                {
                    Console.WriteLine("Usted pagara: " + (100 + 200));
                }
                else
                {
                    Console.WriteLine("Usted pagara: " + (100));
                }
            }
            else if (Salarioo >= 12000.01)
            {
                if (multa == true)
                {
                    Console.WriteLine("Usted pagara: " + (150 + 300));
                }
                else
                {
                    Console.WriteLine("Usted pagara: " + (150));
                }
            }
            else
            {
                Console.WriteLine("Usted no debe pagar nada");
            }
            //Ejercicio 4
            string horas;
            Console.WriteLine("Cuantas Horas estuviste en el parqueo?");
            horas = Console.ReadLine();
            int horass = int.Parse(horas);
            int pagoxhora = 10;
            int total = horass * pagoxhora;
            Console.WriteLine("Debe pagar " + total);
            Console.WriteLine("Ingrese la cantidad a pagar");
            string monto = Console.ReadLine();  
            int montoo = int.Parse(monto);
            int vuelto = (montoo - total);
            if (montoo < total)
            {
                Console.WriteLine("Esto no es suficiente");
            }
            else if (montoo == total)
            {
                Console.WriteLine("Muchas gracias por visitarnos");
            }
            else
            {
                Console.WriteLine("El cambio es " + vuelto);
                int billete100 = vuelto / 100;
                Console.WriteLine("Billetes de de Q100 SON: " + billete100);
                vuelto = (vuelto % 100);
                int billete50 = vuelto / 50;
                Console.WriteLine("Billetes de de Q50 SON: " + billete50);
                vuelto = (vuelto % 50);
                int billete20 = vuelto / 20;
                Console.WriteLine("Billetes de de Q20 SON: " + billete20);
                vuelto = (vuelto % 20);
                int billete10 = vuelto / 10;
                Console.WriteLine("Billetes de de Q10 SON: " + billete10);
                vuelto = (vuelto % 10);
                int billete5 = vuelto / 5;
                Console.WriteLine("Billetes de de Q5 SON: " + billete5);
                vuelto = (vuelto % 5);
                int billete1 = vuelto / 1;
                Console.WriteLine("Billetes de de Q1 SON: " + billete1);
                vuelto = (vuelto % 1);
            }

            }

    }
   
}


