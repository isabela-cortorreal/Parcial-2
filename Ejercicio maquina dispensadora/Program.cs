using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto pdt = new Producto();
            pdt.arrays();
            Bienvenido bienv = new Bienvenido();
            bienv.menu_principal();
        }
    }

    

    class Producto
    {
        string[] nombre = new string[5];
        int[] precio = new int[5];
        int[] exist = new int[5];

        public void arrays()
        {
            nombre[0] = "Papita de limon";
            nombre[1] = "Coca-Cola";
            nombre[2] = "Galletas de chocolate";
            nombre[3] = "Fresitas";
            nombre[4] = "Platanitos";

            precio[0] = 25;
            precio[1] = 25;
            precio[2] = 10;
            precio[3] = 5;
            precio[4] = 25;

            exist[0] = 10;
            exist[1] = 10;
            exist[2] = 10;
            exist[3] = 10;
            exist[4] = 10;
        }
        public void MostrarProductos()
        {
            arrays();

            Console.WriteLine("\n" + "¿Qué desea comprar?");
            Console.WriteLine("1. Papita de limon $25");
            Console.WriteLine("2. Coca-Cola $25");
            Console.WriteLine("3. Galletas de chocolate $10");
            Console.WriteLine("4. Fresitas $5");
            Console.WriteLine("5. Platanitos $25");

            Console.Write("\n" + "Ingrese una opcion: ");
            int menu_producto = int.Parse(Console.ReadLine());

            switch (menu_producto)
            {
                case 1:
                    Console.WriteLine("\n" + "¿Con que desea pagar?");
                    Console.WriteLine("1. Billetes" +
                               "\n" + "2. Monedas");

                    Console.Write("\n" + "Ingrese una opcion: ");
                    int menu_pago = int.Parse(Console.ReadLine());

                    switch (menu_pago)
                    {
                        case 1:
                            Console.Write("\n" + "Ingrese la cantidad de papitas que desea: ");
                            int cant1_prod1 = int.Parse(Console.ReadLine());

                            exist[0] = exist[0] - cant1_prod1;

                            Console.Write("\n" + "Ingrese los billetes: ");
                            int bil1_prod1 = int.Parse(Console.ReadLine());

                            if (bil1_prod1 > 50 && bil1_prod1 < 100)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else if (bil1_prod1 > 100 && bil1_prod1 < 200)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else if (bil1_prod1 > 200)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else
                            {
                                Console.WriteLine("\n" + "Gracias por su compra");
                                int multi1 = cant1_prod1 * precio[0];
                                int cambio1 = bil1_prod1 - multi1;
                                Console.WriteLine("\n" + "Su cambio es de: $" + cambio1);
                            }

                            break;

                        case 2:
                            Console.WriteLine("\n" + "Ingrese la cantidad de papitas que desea: ");
                            int cant2_prod1 = int.Parse(Console.ReadLine());

                            exist[0] = exist[0] - cant2_prod1;

                            Console.Write("\n" + "Ingrese las monedas: ");
                            int bil2_prod1 = int.Parse(Console.ReadLine());

                            if (bil2_prod1 > 5 && bil2_prod1 < 10)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else if (bil2_prod1 > 10 && bil2_prod1 < 25)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else if (bil2_prod1 > 25)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else
                            {
                                if (bil2_prod1 == precio[0])
                                {
                                    Console.WriteLine("\n" + "Gracias por su compra");
                                }
                                else
                                {
                                    Console.WriteLine("\n" + "No le alcanza el dinero para comprar el producto");
                                }
                                
                            }
                            break;

                        default:
                            Console.WriteLine("N/A");
                            break;
                    }
                            
                    break;

                case 2:
                    Console.WriteLine("\n" + "¿Con que desea pagar?");
                    Console.WriteLine("1. Billetes" +
                               "\n" + "2. Monedas");

                    Console.Write("\n" + "Ingrese una opcion: ");
                    int menu_pago2 = int.Parse(Console.ReadLine());

                    switch (menu_pago2)
                    {
                        case 1:
                            Console.Write("\n" + "Ingrese la cantidad de coca-cola que desea: ");
                            int cant1_prod2 = int.Parse(Console.ReadLine());

                            exist[1] = exist[1] - cant1_prod2;

                            Console.Write("\n" + "Ingrese los billetes: ");
                            int bil1_prod2 = int.Parse(Console.ReadLine());

                            if (bil1_prod2 > 50 && bil1_prod2 < 100)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else if (bil1_prod2 > 100 && bil1_prod2 < 200)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else if (bil1_prod2 > 200)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else
                            {
                                Console.WriteLine("\n" + "Gracias por su compra");
                                int multi2 = cant1_prod2 * precio[1];
                                int cambio2 = bil1_prod2 - multi2;
                                Console.WriteLine("\n" + "Su cambio es de: $" + cambio2);
                            }

                            break;

                        case 2:
                            Console.WriteLine("\n" + "Ingrese la cantidad de coca-cola que desea: ");
                            int cant2_prod2 = int.Parse(Console.ReadLine());

                            exist[1] = exist[1] - cant2_prod2;

                            Console.Write("\n" + "Ingrese las monedas: ");
                            int bil2_prod2 = int.Parse(Console.ReadLine());

                            if (bil2_prod2 > 5 && bil2_prod2 < 10)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else if (bil2_prod2 > 10 && bil2_prod2 < 25)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else if (bil2_prod2 > 25)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else
                            {
                                if (bil2_prod2 == precio[1])
                                {
                                    Console.WriteLine("\n" + "Gracias por su compra");
                                }
                                else
                                {
                                    Console.WriteLine("\n" + "No le alcanza el dinero para comprar el producto");
                                }

                            }
                            break;

                        default:
                            Console.WriteLine("N/A");
                            break;
                    }

                    break;

                case 3:
                    Console.WriteLine("\n" + "¿Con que desea pagar?");
                    Console.WriteLine("1. Billetes" +
                               "\n" + "2. Monedas");

                    Console.Write("\n" + "Ingrese una opcion: ");
                    int menu_pago3 = int.Parse(Console.ReadLine());

                    switch (menu_pago3)
                    {
                        case 1:
                            Console.Write("\n" + "Ingrese la cantidad de galletas de chocolate que desea: ");
                            int cant1_prod3 = int.Parse(Console.ReadLine());

                            exist[2] = exist[2] - cant1_prod3;

                            Console.Write("\n" + "Ingrese los billetes: ");
                            int bil1_prod3 = int.Parse(Console.ReadLine());

                            if (bil1_prod3 > 50 && bil1_prod3 < 100)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else if (bil1_prod3 > 100 && bil1_prod3 < 200)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else if (bil1_prod3 > 200)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else
                            {
                                Console.WriteLine("\n" + "Gracias por su compra");
                                int multi3 = cant1_prod3 * precio[2];
                                int cambio3 = bil1_prod3 - multi3;
                                Console.WriteLine("\n" + "Su cambio es de: $" + cambio3);
                            }

                            break;

                        case 2:
                            Console.WriteLine("\n" + "Ingrese la cantidad de galletas de chocolate que desea: ");
                            int cant2_prod3 = int.Parse(Console.ReadLine());

                            exist[2] = exist[2] - cant2_prod3;

                            Console.Write("\n" + "Ingrese las monedas: ");
                            int bil2_prod3 = int.Parse(Console.ReadLine());

                            if (bil2_prod3 > 5 && bil2_prod3 < 10)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else if (bil2_prod3 > 10 && bil2_prod3 < 25)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else if (bil2_prod3 > 25)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else
                            {
                                if (bil2_prod3 == precio[2])
                                {
                                    Console.WriteLine("\n" + "Gracias por su compra");
                                }
                                else
                                {
                                    Console.WriteLine("\n" + "No le alcanza el dinero para comprar el producto");
                                }

                            }
                            break;

                        default:
                            Console.WriteLine("N/A");
                            break;
                    }
                    break;

                case 4:
                    Console.WriteLine("\n" + "¿Con que desea pagar?");
                    Console.WriteLine("1. Billetes" +
                               "\n" + "2. Monedas");

                    Console.Write("\n" + "Ingrese una opcion: ");
                    int menu_pago4 = int.Parse(Console.ReadLine());

                    switch (menu_pago4)
                    {
                        case 1:
                            Console.Write("\n" + "Ingrese la cantidad de fresitas que desea: ");
                            int cant1_prod4 = int.Parse(Console.ReadLine());

                            exist[3] = exist[3] - cant1_prod4;

                            Console.Write("\n" + "Ingrese los billetes: ");
                            int bil1_prod4 = int.Parse(Console.ReadLine());

                            if (bil1_prod4 > 50 && bil1_prod4 < 100)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else if (bil1_prod4 > 100 && bil1_prod4 < 200)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else if (bil1_prod4 > 200)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else
                            {
                                Console.WriteLine("\n" + "Gracias por su compra");
                                int multi4 = cant1_prod4 * precio[3];
                                int cambio4 = bil1_prod4 - multi4;
                                Console.WriteLine("\n" + "Su cambio es de: $" + cambio4);
                            }

                            break;

                        case 2:
                            Console.WriteLine("\n" + "Ingrese la cantidad de fresitas que desea: ");
                            int cant2_prod4 = int.Parse(Console.ReadLine());

                            exist[3] = exist[3] - cant2_prod4;

                            Console.Write("\n" + "Ingrese las monedas: ");
                            int bil2_prod4 = int.Parse(Console.ReadLine());

                            if (bil2_prod4 > 5 && bil2_prod4 < 10)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else if (bil2_prod4 > 10 && bil2_prod4 < 25)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else if (bil2_prod4 > 25)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else
                            {
                                if (bil2_prod4 == precio[3])
                                {
                                    Console.WriteLine("\n" + "Gracias por su compra");
                                }
                                else
                                {
                                    Console.WriteLine("\n" + "No le alcanza el dinero para comprar el producto");
                                }

                            }
                            break;

                        default:
                            Console.WriteLine("N/A");
                            break;
                    }
                    break;

                case 5:
                    Console.WriteLine("\n" + "¿Con que desea pagar?");
                    Console.WriteLine("1. Billetes" +
                               "\n" + "2. Monedas");

                    Console.Write("\n" + "Ingrese una opcion: ");
                    int menu_pago5 = int.Parse(Console.ReadLine());

                    switch (menu_pago5)
                    {
                        case 1:
                            Console.Write("\n" + "Ingrese la cantidad de platanitos que desea: ");
                            int cant1_prod5 = int.Parse(Console.ReadLine());

                            exist[4] = exist[4] - cant1_prod5;

                            Console.Write("\n" + "Ingrese los billetes: ");
                            int bil1_prod5 = int.Parse(Console.ReadLine());

                            if (bil1_prod5 > 50 && bil1_prod5 < 100)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else if (bil1_prod5 > 100 && bil1_prod5 < 200)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else if (bil1_prod5 > 200)
                            {
                                Console.WriteLine("No aceptamos este billete");
                            }
                            else
                            {
                                Console.WriteLine("\n" + "Gracias por su compra");
                                int multi5 = cant1_prod5 * precio[4];
                                int cambio5 = bil1_prod5 - multi5;
                                Console.WriteLine("\n" + "Su cambio es de: $" + cambio5);
                            }

                            break;

                        case 2:
                            Console.WriteLine("\n" + "Ingrese la cantidad de fresitas que desea: ");
                            int cant2_prod5 = int.Parse(Console.ReadLine());

                            exist[4] = exist[4] - cant2_prod5;

                            Console.Write("\n" + "Ingrese las monedas: ");
                            int bil2_prod5 = int.Parse(Console.ReadLine());

                            if (bil2_prod5 > 5 && bil2_prod5 < 10)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else if (bil2_prod5 > 10 && bil2_prod5 < 25)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else if (bil2_prod5 > 25)
                            {
                                Console.WriteLine("No aceptamos esta moneda");
                            }
                            else
                            {
                                if (bil2_prod5 == precio[4])
                                {
                                    Console.WriteLine("Gracias por su compra");
                                }
                                else
                                {
                                    Console.WriteLine("\n" + "No le alcanza el dinero para comprar el producto");
                                }

                            }
                            break;

                        default:
                            Console.WriteLine("N/A");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Este producto no existe");
                    break;

            }
            Console.WriteLine("\n" + "Informe:");
            Informe();
            Console.ReadKey();
        }

        public void Informe()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Quedan " + exist[i] + " de " + nombre[i]);
            }
        }
    }

    class Bienvenido
    {
        int menu;

        public void menu_principal()
        {
            do
            {
                Console.WriteLine("\n" + "Bienvenido");
                Console.WriteLine("Seleccione la accion que desea realizar");
                Console.WriteLine("1. Comprar" +
                           "\n" + "3. Salir");

                Console.Write("\n" + "Ingrese la opcion: ");
                menu = int.Parse(Console.ReadLine());

                Producto produc = new Producto();

                switch (menu)
                {
                    case 1:
                        produc.MostrarProductos();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Programa Finalizado");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("N/A");
                        break;

                }
                Console.ReadKey();

            } while (menu != 2);
        }
    }
}
