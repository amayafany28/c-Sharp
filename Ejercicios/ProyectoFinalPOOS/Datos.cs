using System;
using System.Collections.Generic;
public class Datos
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Venta> ListaVentas { get; set; }

    public Datos()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaVentas = new List<Venta>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Blusa Floreada", 2600);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Pantalon Jean Marca PEPE ", 3500);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Camisas Marca Peacer", 12000);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto(4, "Tenis de Hombre", 3450);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto(5, "Zapatos de Hombre", 4200);
        ListadeProductos.Add(p5);

        Producto p6 = new Producto(6, "Tenis de Mujer", 4000);
        ListadeProductos.Add(p6);

        Producto p7 = new Producto(7, "Zapato de Mujer",54800);
        ListadeProductos.Add(p7);

        Producto p8 = new Producto(8, "Ropa Interior de Mujer", 6600);
        ListadeProductos.Add(p8);

        Producto p9 = new Producto(9, "Ropa Interior de Hombre", 5100);
        ListadeProductos.Add(p9);

        Producto p10 = new Producto(10, "Maquillaje", 2500);
        ListadeProductos.Add(p10);


    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Maria De los Angeles Amaya", "1615-1955-00098");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Miguel Angel Luna Torrez", "1615-1950-00015");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, "Gladis Patricia Vasquez Lopez", "1615-1983-00063");
        ListadeClientes.Add(c3);

        Cliente c4 = new Cliente(4, "Kennggy Enrique Enamorado Perez", "0501-1997-00275");
        ListadeClientes.Add(c4);

        Cliente c5 = new Cliente(5, "Fabricio Perdomo Ayala", "0501-1998-00145");
        ListadeClientes.Add(c5);

        Cliente c6 = new Cliente(6, "Delmi Adeli Gavarrete Perez", "1516-1998-00075");
        ListadeClientes.Add(c6);

     
    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Wendy Pastora Ulloa Toro", "0502-1992-00102");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Sandy Maribel Enamorado Perez", "0502-1999-00098");
        ListadeVendedores.Add(v2);

        Vendedor v3 = new Vendedor(3, "Fany Karolina Amaya Vasquez ", "1615-1998-00149");
        ListadeVendedores.Add(v3);
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine(" Lista de Productos ");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine(" Listado de Clientes ");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine(" Lista de Vendedores ");
        Console.WriteLine("");
        
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }

        Console.ReadLine();
    }

    public void CrearVenta()
    {
        Console.WriteLine(" Creando Venta ");
        Console.WriteLine("");

        Console.WriteLine("Por Favor, Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("No se encuentra el cliente");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Por Favor, Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("Vendedor no disponible");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaVentas.Count + 1;

        Venta nuevaVenta = new Venta(nuevoCodigo, DateTime.Now, "Choloma,Cortes" + nuevoCodigo, cliente, vendedor);
        ListaVentas.Add(nuevaVenta);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaVenta.AgregarProducto(producto);
            }

            Console.WriteLine("Desea realizar otra compra? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("SubTotal de la venta es de: " + nuevaVenta.SubTotal);

        Console.WriteLine("Impuesto de la venta es de: " + nuevaVenta.Impuesto);

        Console.WriteLine("Total de la venta es de: " + nuevaVenta.Total);
        Console.ReadLine();
    }

    public void ListarVentas()
    {
        Console.Clear();
        Console.WriteLine(" Lista de Ventas ");
        Console.WriteLine("");  
        Console.WriteLine("= Codigo / Fecha /  SubTotal / Impuesto / Total =");
        Console.WriteLine("             Cliente / Vendedor              ");
        Console.WriteLine("");  

        foreach (var venta in ListaVentas)
        {
            Console.WriteLine(venta.Codigo + " / " + venta.Fecha + " / " + venta.SubTotal + " / " + venta.Impuesto + " / " + venta.Total);
            Console.WriteLine(venta.Cliente.Nombre + " / " + venta.Vendedor.Nombre);
            
            foreach (var detalle in venta.ListaVentaDetalle)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " / " + detalle.Cantidad + " /  " + detalle.Precio);
            }

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}