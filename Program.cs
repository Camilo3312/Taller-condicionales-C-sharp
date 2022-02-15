namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            var ejecutar = true;
            while(ejecutar) {
                Console.WriteLine("Ingrese una opcion para el ejercicio");

                var opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CondicionalSimple();
                        break;
                    case 2:
                        CondicionalDoble();
                        break;
                    case 3:
                        CondicionalMultiple();
                        break;
                    case 4:
                        CondicionalAnidado();
                        break;
                    case 5:
                        DependiendoOSegun();
                        break;

                    case 6:
                        Ciclos();
                        break;

                    case 7:
                        CondicionalesYCiclos();
                        break;
                    default:
                        break;
                }
            }
        }

        public static void CondicionalSimple()
        {
            Console.WriteLine("Ingrese una cantidad en bodega");
            int cantidadBodega = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad minima requerida");
            int cantidadMinima = Convert.ToInt32(Console.ReadLine());

            var result = SistemaInvetario(cantidadBodega, cantidadMinima);

            string message = "Cantidad minima en bodega " + cantidadBodega + " Cantidad minima requerida " + cantidadMinima + ". ";
            if (result)
            {
                message += "Entonces no es necesario realizar el pedido al proveedor";
            }
            else
            {
                message += "Entonces si es necesario realizar el pedido al proveedor";
            }
            Console.WriteLine(message);
        }

        public static void CondicionalDoble()
        {
            Console.WriteLine("Ingrese una cantidad en bodega");
            int cantidadBodega = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad minima requerida");
            int cantidadMinima = Convert.ToInt32(Console.ReadLine());

            string message = "Cantidad minima en bodega " + cantidadBodega + " Cantidad minima requerida " + cantidadMinima + ". ";
            if ((cantidadBodega - cantidadMinima) > 0)
            {
                message += "Entonces no es necesario realizar el pedido al proveedor";
            }
            else if ((cantidadBodega - cantidadMinima) < 0)
            {
                message += "Entonces si es necesario realizar el pedido al proveedor";
            }
            Console.WriteLine(message);
        }

        public static void CondicionalMultiple()
        {
            Console.WriteLine("Ingrese una cantidad en bodega");
            int cantidadBodega = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad minima requerida");
            int cantidadMinima = Convert.ToInt32(Console.ReadLine());


            int unidadesPorVender = 0;
            string message = "Cantidad minima en bodega " + cantidadBodega + " Cantidad minima requerida " + cantidadMinima + ". ";
            if ((cantidadBodega - cantidadMinima) > 0)
            {
                unidadesPorVender = (cantidadMinima - cantidadBodega) / -1;
                message += "Entonces no es necesario realizar el pedido al proveedor. Unidades que hacen falta vender " + unidadesPorVender;          
            }
            else if (unidadesPorVender < 10)
            {
                message += "Alerta generada";
            }
            else if ((cantidadBodega - cantidadMinima) < 0)
            {
                message += "Entonces si es necesario realizar el pedido al proveedor.";
            }
            Console.WriteLine(message);
        }

        public static void CondicionalAnidado()
        {
            Console.WriteLine("Ingrese una cantidad en bodega");
            int cantidadBodega = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el dinero en caja");
            int valorEnCaja = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese valor unitario de los productos");
            int valorUnitario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad minima requerida");
            int cantidadMinima = Convert.ToInt32(Console.ReadLine());


            string message = "Cantidad minima en bodega " + cantidadBodega + " Cantidad minima requerida " + cantidadMinima + ". ";
            if ((cantidadBodega - cantidadMinima) > 0)
            {
                int unidadesPorVender = (cantidadMinima - cantidadBodega) / -1;
                message += "Entonces no es necesario realizar el pedido al proveedor. Unidades que hacen falta vender " + unidadesPorVender;
                if (unidadesPorVender < 10)
                {
                    message += "Alerta generada";
                }
            }
            else if ((cantidadBodega - cantidadMinima) < 0)
            {
                int unidadesPorComprar = cantidadMinima - cantidadBodega;
                if(unidadesPorComprar < 0) {
                    unidadesPorComprar = (unidadesPorComprar / -1);
                }

                int valorCompra = (valorUnitario * unidadesPorComprar) / -1;

                if(valorCompra < 0) {
                    valorCompra = (valorCompra / -1);
                }

                if(valorCompra > valorEnCaja) 
                    message += "Entonces si es necesario realizar el pedido al proveedor.\n Cantidades de compras deceada: " + unidadesPorComprar + ". Valor de compra: " + valorCompra + " Valor en caja " + valorEnCaja + " no es posible realizar el predido";
                else if(valorCompra <= valorEnCaja) {
                    message += "Entonces si es necesario realizar el pedido al proveedor.\n Cantidades de compras deceada: " + unidadesPorComprar + ". Valor de compra: " + valorCompra + " Valor en caja " + valorEnCaja + " si es posible realizar el predido";              
                }
            }
            Console.WriteLine(message);
        }

        public static void DependiendoOSegun() {
            Console.WriteLine("Ingrese el un dia de la semana");
            int diaSemana = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el total a pagar");
            int total = Convert.ToInt32(Console.ReadLine());
            
            var message = "";

            switch (diaSemana)
            {
                case 1:
                    message = "su descuento es de " + total * .5;
                    break;
                case 2:
                    message = "su descuento es de " + total * .3;
                    break;
                case 3:
                    message = "su descuento es de " + total * .10;
                    break;

                case 4:
                    message = "su descuento es de " + total * .4;
                    break;

                case 5:
                    message = "su descuento es de " + total * .6;
                    break;

                case 6:
                    message = "su descuento es de " + total * .2;
                    break;

                case 7:
                    message = "su descuento es de " + total * .1;
                    break;
                default:  
                    message = "El dia de la semana ingresado es incorrecto";
                    break;
            }

            Console.WriteLine(message);
        }
        
        public static void Ciclos() {
            Console.WriteLine("Ingrese la cantidad de tipos de productos");
            int cantidadTipoProductos = Convert.ToInt32(Console.ReadLine());
            
            int total = 0;
            var mensaje = $"Cantidad de tipo de productos {cantidadTipoProductos} \n";

            for (int i = 1; i <= cantidadTipoProductos; i++)
            {   
                Console.WriteLine($"Ingrese la cantidad de producto {i}:");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Valor del producto {i}:");
                int valorProducto = Convert.ToInt32(Console.ReadLine());

                total += cantidad * valorProducto;
                mensaje += $"Cantidad producto {i}: {cantidad}. Valor del producto {i}: {valorProducto}\n";
            }

            Console.WriteLine($"{mensaje}Total de la factura {total}");
        }

        public static void CondicionalesYCiclos() {
            var atenderClientes = true;
            int cantidadTipoProductos = 0;
            double total = 0;
            double totalFactura = 0;
            int cantidadClientes = 0;
            var mensaje = "";
            while(atenderClientes) {
                Console.WriteLine("Ingrese la opcion \n (1) para agregar un registro \n (2) para finalizar y dar el total");

                int opcion = Convert.ToInt32(Console.ReadLine());
                
                if(opcion == 1){ 
                    cantidadClientes++;
                    Console.WriteLine("Ingrese la cantidad de tipos de productos");
                    cantidadTipoProductos = Convert.ToInt32(Console.ReadLine());
                    mensaje += $"Cliente {cantidadClientes} \nCantidad de tipo de productos {cantidadTipoProductos} \n";
                    totalFactura = 0;
                    for (int i = 1; i <= cantidadTipoProductos; i++)
                    {   
                        Console.WriteLine($"Ingrese la cantidad de producto {i}:");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Valor del producto {i}:");
                        int valorProducto = Convert.ToInt32(Console.ReadLine());
                        double totalCantidadProducto = cantidad * valorProducto;
                        if(totalCantidadProducto < 0) {
                            totalCantidadProducto = totalCantidadProducto / -1;
                        }
                        if(totalCantidadProducto > 100000) {
                            totalCantidadProducto = (totalCantidadProducto * .10);
                        }
                        total += totalCantidadProducto;
                        totalFactura += totalCantidadProducto;
                        mensaje += $"Cantidad producto {i}: {cantidad}. Valor del producto {i}: {valorProducto}\n";
                    }
                    mensaje += $"Total de la factura {totalFactura} \n \n";

                }
                else if(opcion == 2) {
                    atenderClientes = false;
                    Console.WriteLine($"{mensaje}Total vendido {total}");
                }             
            }
        }

        public static bool SistemaInvetario(int cantidadBodega, int cantidadMinima)
        {
            if ((cantidadBodega - cantidadMinima) < 0)
                return false;
            return true;
        }

    }
}
