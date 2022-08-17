using System;
using System.Collections.Generic;
public class DatosReservacion

{
    public List<Habitacion> ListadeHabitaciones { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Recepcionista> ListadeRecepcionista{ get; set; }
    public List<Reservacion> ListaReservacion { get; set; }

    public DatosReservacion()
    {
        ListadeHabitaciones = new List<Habitacion>();
        cargarHabitaciones();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeRecepcionista = new List<Recepcionista>();
        cargarRecepcionista();

        ListaReservacion = new List<Reservacion>();
    }

    private void cargarHabitaciones()
    {
        Habitacion p1 = new Habitacion(1, "Individual ", 500);
        ListadeHabitaciones.Add(p1);

        Habitacion p2 = new Habitacion(2, "Doble", 1000);
        ListadeHabitaciones.Add(p2);

        Habitacion p3 = new Habitacion(3, "Mediana", 2000);
        ListadeHabitaciones.Add(p3);

        Habitacion p4 = new Habitacion(4, "Grande", 3500);
        ListadeHabitaciones.Add(p4);

        Habitacion p5 = new Habitacion(5, "suite Presidencial", 5000);
        ListadeHabitaciones.Add(p5);

    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Dane Sabillon", "1611-1998-00129");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Diego Zuniga", "1601-2000-00691");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, "Oscar Zaldivar", "1601-2002-00313");
        ListadeClientes.Add(c3);
    }

    private void cargarRecepcionista()
    {
        Recepcionista v1 = new Recepcionista(1, "Yafeth Garmendia", "001");
        ListadeVendedores.Add(v1);

    }

    public void ListarHabitaciones()
    {
        Console.Clear();
        Console.WriteLine("= Lista de Habitaciones =");
        Console.WriteLine("");
        
        foreach (var Habitacion in ListadeHabitaciones)
        {
            Console.WriteLine(Habitacion.Codigo + " | " + Habitacion.Descripcion + " | " + Habitacion.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("= Lista de Clientes =");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarRecepcionista()
    {
        Console.Clear();
        Console.WriteLine("= Lista de Recepcionista =");
        Console.WriteLine("");
        
        foreach (var Recepcionista in ListadeRecepcionista)
        {
            Console.WriteLine(Recepcionista.Codigo + " | " + Recepcionista.Nombre + " | " + Recepcionista.CodigoRecepcionista);
        }

        Console.ReadLine();
    }

    public void CrearOrden()
    {
        Console.WriteLine("= Creando Orden =");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del Recepcionista: ");
        string CodigoRecepcionista = Console.ReadLine();

        Recepcionista Recepcionista = ListadeRecepcionista.Find(v => v.Codigo.ToString() == CodigoRecepcionista);
        if (Recepcionista == null) 
        {
            Console.WriteLine("Recepcionista no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Recepcionista: " + Recepcionista.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "Santa Barbara" + nuevoCodigo, cliente, Recepcionista);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.WriteLine("Ingrese La Habitacion: ");
            string codigoHabitacion = Console.ReadLine();
            Habitacion Habitacion = ListadeHabitaciones.Find(p => p.Codigo.ToString() == codigoHabitacion);        
            if (Habitacion == null)
            {
                Console.WriteLine("Habitacion no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Habitacion agregada: " + Habitacin.Descripcion + " con precio de: " +Habitacion.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("SubTotal de la Reservacion es de: " + nuevaReservacion.SubTotal);

        Console.WriteLine("Impuesto de la Reservacion es de: " + nuevaReservacion.Impuesto);

        Console.WriteLine("Total de la Reservacion es de: " + nuevaReservacion.Total);
        Console.ReadLine();
    }

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("= Lista de Reservacion =");
        Console.WriteLine("");  
        Console.WriteLine("= Codigo | Fecha | SubTotal | Impuesto | Total =");
        Console.WriteLine("=              Cliente | Recepcionista              =");
        Console.WriteLine("");  

        foreach (var Reservacion in ListaReservacion)
        {
            Console.WriteLine(Reservacion.Codigo + " | " + Reservacion.Fecha + " | " + coste.SubTotal + " | " + coste.Impuesto + " | " + coste.Total);
            Console.WriteLine(Reservacion.Cliente.Nombre + " | " + Reservacion.Recepcionista.Nombre);
            
            foreach (var detalle in orden.ListaDatosReservacion)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}