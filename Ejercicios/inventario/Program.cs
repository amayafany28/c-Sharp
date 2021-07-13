using System;

namespace inventario
{
    class Program
    {
        static string[,] productos = new string[5,3]
        {
            { "001", "iPhone xPlus", "0" },
            { "002", "Laptop Dell Latitud", "15" },
            { "003", "Monitor Samsung", "2" },
            { "004", "Mouse", "100" },
            { "005", "Headset ", "25" },
        };

        static void listarProductos() {
            Console.Clear();
            Console.WriteLine("");
         
            Console.WriteLine("*      - Listado de Productos -     *");
        
            Console.WriteLine("*  - Codigo, Descripcion y Existencia - *");
  

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(productos[i, 0] + " | " + productos[i, 1] + " | " + productos[i, 2]);
            }

            Console.ReadLine();
        }

        static void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
            for (int i = 0; i < 5; i++)
            {
                if (productos[i, 0] == codigo) {
                    if (tipoMovimiento == "+") {
                        productos[i, 2] = (Int32.Parse(productos[i, 2]) + cantidad).ToString();
                    } else {
                        productos[i, 2] = (Int32.Parse(productos[i, 2]) - cantidad).ToString();
                    }
                }
            }
        }

        static void ingresoDeInventario() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

      
            Console.WriteLine("* Ingreso de Productos al Inventario *");
      
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "+");
        }

        static void salidaDeInventario() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("* Salida de Productos del Inventario *");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "-");
        }
        
        static void ajusteNegativoDelInventario() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("*   Ajuste Negativo del Inventario   *");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "-");
        }

        static void ajustePositivoDelInventario() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("*   Ajuste Positivo del Inventario   *");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "+");
        }

        static void Main(string[] args)
        {
            string opcion = "";

            while (true)
            {
                Console.Clear();
               
                Console.WriteLine("*        Sistem of Inventory       *");
        
                Console.WriteLine("");
                Console.WriteLine("1 - /Productos");
                Console.WriteLine("2 - Ingreso de Inventario");
                Console.WriteLine("3 - Salida de Inventario");
                Console.WriteLine("4 - Ajuste Negativo del Inventario");
                Console.WriteLine("5 - Ajuste Positivo del Inventario");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        listarProductos();
                        break;
                    case "2":
                        ingresoDeInventario();
                        break;
                    case "3":
                        salidaDeInventario();
                        break;
                    case "4":
                        ajusteNegativoDelInventario();
                        break;
                    case "5":
                        ajustePositivoDelInventario();
                        break;

                    default:
                    break;
                }

                if (opcion == "0") {
                    break;
                }
            }            
        }
    }
}