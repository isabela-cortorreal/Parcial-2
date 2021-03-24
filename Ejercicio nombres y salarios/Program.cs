using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] empleados_ = new string[5];
            double[] sueldo_ = new double[5];

            Cargar(empleados_, sueldo_);
            SalarioMayor(empleados_, sueldo_);

            Console.ReadKey();
        }

        public static void Cargar(string[] nombre_empleados, double[] sueldo_empleados)
        {
            for(int e = 0; e < nombre_empleados.Length; e++)
            {
                Console.Write("Ingrese los nombres de los empleados: ");
                nombre_empleados[e] = Console.ReadLine();
            }

            Console.Write("\n");

            for (int s = 0; s < sueldo_empleados.Length; s++)
            {
                Console.Write("Ingrese el sueldo de los 5 empleados: ");
                sueldo_empleados[s] = double.Parse(Console.ReadLine());
            }
        }

        public static void SalarioMayor(string[] nombre_empleados, double[] sueldo_empleados)
        {
            string empleados_nombre = "";
            double sueldo_mayor = 0;

            for(int m = 0; m < sueldo_empleados.Length; m++)
            {
                if(sueldo_mayor < sueldo_empleados[m])
                {
                    sueldo_mayor = sueldo_empleados[m];
                    empleados_nombre = nombre_empleados[m];
                }
            }
            Console.Write("\n");
            Console.WriteLine("El empleado con el salario mayor es: {0}", empleados_nombre);
            Console.WriteLine("Tiene un salario de: {0}", sueldo_mayor);
        }
    }
}
