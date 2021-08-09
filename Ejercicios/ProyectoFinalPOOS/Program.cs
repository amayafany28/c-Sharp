using System;

namespace ProyectoFinalPOOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos datos = new Datos();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("   //Sistema POS// ");
                Console.WriteLine("");
                Console.WriteLine("1   Lista de Productoos ");
                Console.WriteLine("2 - Crear Venta");
                Console.WriteLine("3 - Lista de Clientes");
                Console.WriteLine("4 - Lista de Vendedores");
                Console.WriteLine("5 - Reporte de Ventas");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarProductos();
                        break;
                    case "2":
                        datos.CrearVenta();
                        break;
                    case "3":
                        datos.ListarClientes();
                        break;
                    case "4":
                        datos.ListarVendedores();
                        break;      
                    case "5":
                        datos.ListarVentas();
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