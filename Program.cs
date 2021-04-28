using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Decir "Hola mundo"
            // 2) Decir "Hola (nombre)"
            // 9) Salir

            //Mostrar el menú de opciones
            // Solicitar la opción al usuario
            string opcion = "";
            while( opcion != "9")
        {
            opcion = "";
            //pedir opcion
            while(opcion != "1" && opcion!= "2" && opcion != "9")
          {
                Console.WriteLine("1) Decir \"Hola Mundo!\" ");
                Console.WriteLine("2) Decir \"Hola (nombre)!\"");
                Console.WriteLine("9) Salir");

                Console.WriteLine("Por favor selecciona una opción ");
                opcion = Console.ReadLine();

            //Validar la opcion seleccionada hasta que se introduzca una opcion correcta 
            //o mietras no se haya introducido una opcion correcta
            if(opcion != "1" && opcion!= "2" && opcion != "9")
            {
                Console.WriteLine("La opcion seleccionada no es válida");
            }

          }
           //Manejar la opcion
            if (opcion == "1")
            {
                Console.WriteLine("Hola Mundo!");
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Introduce tu nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Hola " + nombre + "!");
            }
            else if(opcion == "9")
            {
                Console.WriteLine("Hasta luego!");
            }
        }

           
           
        }
    }
}
