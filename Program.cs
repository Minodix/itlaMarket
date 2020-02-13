using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {

        private struct Productos
        {
            public string nombreProducto { get; set; }
            public double precioProducto { get; set; }
            public int cantidadProducto { get; set; }

        }
        private struct Ventas       
        {
            public string nombreCliente { get; set; }
            public string Producto { get; set; }
            public int cantidadProducto { get; set; }

        }


        private static  List<Productos> LProductos = new List<Productos>();

        private static List<string> LClientes = new List<string>();

        private static List<Ventas> LVentas = new List<Ventas>();

        static void Main(string[] args)
           
        {

            while (true)
            {
                Console.Clear();
                Menu();
            }
        }


        private static void Menu()
        {
            

            Console.WriteLine("----------ItlaMarket----------\nSeleccione una opcion:\n1-Productos\n2-Clientes\n3-Vender\n4-Salir");
           
           
            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
               
                case 1:
                    Console.Clear();
                    Console.WriteLine("----------Productos----------\n1-Agregar producto\n2-Modificar producto\n3-Listar producto\n4-Eliminar producto");
                    int agregarP = 0;
                    agregarP = Convert.ToInt32(Console.ReadLine());

                    switch (agregarP)
                    {
                        case 1:
                            agregarProductos();
                            break;
                        case 2:
                            editarProductos();
                            break;
                        case 3:
                            ListarP();
                            Console.ReadKey();
                            break;
                        case 4:
                            eliminarProductos();
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("----------Clientes----------\n1-Agregar cliente\n2-Modificar cliente\n3-Listar cliente\n4-Eliminar cliente");
                    int agregarC = 0;
                    agregarC = Convert.ToInt32(Console.ReadLine());
                    switch (agregarC)
                    {
                        case 1:
                            agregarClientes();
                            break;
                        case 2:
                            editarClientes();
                            break;
                        case 3:
                            List(LClientes);
                            Console.ReadKey();
                            break;
                        case 4:
                            eliminarClientes();
                            break;
                    }
                    break;
                case 3:
                    VentasP();
                    break;
                case 4:
                    Console.ReadKey();
                    break;
            }
                


}


        private static void agregarClientes()
        {
            Console.WriteLine("Introduzca el nombre del cliente:");
            string nombre = Console.ReadLine();
            Add(LClientes, nombre);
        }
        private static void agregarProductos()
        {
            Productos item = new Productos();
            

            Console.WriteLine("Introduzca el nombre del producto:");
           string nombreP = Console.ReadLine();
            Console.WriteLine("Introduzca el precio del producto:");
            double precioP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la cantidad del producto:");
            int cantidadP = Convert.ToInt32( Console.ReadLine());
            item.nombreProducto = nombreP;
            item.precioProducto = precioP;
            item.cantidadProducto = cantidadP;
            Add(LProductos, item);
           

    }

      
        private static void Add<T>(List<T> listado, T item)
        
        {
            listado.Add(item);

        }

        public static void ListarP()
        {
            int contador = 1;
            foreach (Productos item in LProductos)
            {
                Console.WriteLine(contador + "-" + "Nombre : " + item.nombreProducto + "\nPrecio : " + item.precioProducto + "\n Cantidad : " + item.cantidadProducto);
                contador++;
            }
        }

        
        private static void List<T>(List<T> listado)
        {
            int contador = 1;

            foreach (T item in listado)
            {
                Console.WriteLine(contador + "-" + item);
                contador++;


            }

        }

      


        private static void Edit<T>(List<T> listado, int index, T value)

        {
            listado[index] = value ;
        }
        private static void Delete<T>(List<T> listado, int index)

        {
            listado.RemoveAt(index);
        }

        private static void editarClientes()
        {
            Console.WriteLine("Seleccione el cliente que desea editar:");
            List(LClientes);
           
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el nuevo nombre del cliente:");
            string nombre = Console.ReadLine();
            Add(LClientes,nombre);
        }
        private static void editarProductos()
        {
            Productos item = new Productos();
            Console.WriteLine("Seleccione el producto que desea editar:");
            ListarP();

            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el nuevo nombre del producto:");
            string nombreP = Console.ReadLine();
            Console.WriteLine("Introduzca el nuevo precio del producto:");
            double precioP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la nueva cantidad del producto:");
            int cantidadP = Convert.ToInt32(Console.ReadLine());
            item.nombreProducto = nombreP;
            item.precioProducto = precioP;
            item.cantidadProducto = cantidadP;
           LProductos[index - 1] = item;
            
        }
        private static void eliminarClientes()
        {
            Console.WriteLine("Seleccione el cliente que desea  Eliminar:");
            List(LClientes);
            int index = Convert.ToInt32(Console.ReadLine());
            
            Delete(LClientes, (index - 1));
        }
        private static void eliminarProductos()
        {
            Console.WriteLine("Seleccione el producto que desea  Eliminar:");
            ListarP();
            int index = Convert.ToInt32(Console.ReadLine());

            LProductos.RemoveAt(index - 1);
        }
        private static void Venta(List<Ventas> listado)
        {
            int contador = 1;
            
            foreach (Ventas item in listado)
            {
                
                Console.WriteLine("El nombre del cliente es: " + item.nombreCliente);
                Console.WriteLine("Escogio los siguientes productos:");
                int contador2 = 1;
                foreach (int Ventas in item.Producto)
                {
                    Console.WriteLine(contador + "-" + Ventas);
                }
                contador++;
                contador2++;
            }
        }

        private static void VentasP()
        {
            List(LClientes);
            Console.Write("Seleccione el cliente que desea hacer la compra:");
                int indexCliente = Convert.ToInt32(Console.ReadLine()) - 1;
            ListarP();
            Console.Write("Seleccione el producto que desea hacer la comprar:");
            int indexProducto = Convert.ToInt32(Console.ReadLine()) - 1;
            ListarP();
            Console.Write("Seleccione la cantidad del producto que desaa comprar");
            int indexCant = Convert.ToInt32(Console.ReadLine()) - 1;
        }
    }
}


