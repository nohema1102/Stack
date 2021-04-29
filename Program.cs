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
           
            StackDeNotas stackDeNotas = new StackDeNotas();
            stackDeNotas.Push("Primer nota");
            stackDeNotas.Push("Segunda nota");
            stackDeNotas.Push("Tercer nota");

            string opcion = "";
            while( opcion != "9")
        {
            opcion = "";
            //pedir opcion
            while(opcion != "1" && opcion!= "2" && opcion!= "3" && opcion != "9")
          {
                Console.WriteLine("1) Imprimir notas");
                Console.WriteLine("2) Agregar nota (Push)");
                Console.WriteLine("3) Quitar nota (Pop)");
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
                stackDeNotas.PrintStack();
                
            }
            else if (opcion == "2")
            {
                //Push
                Console.WriteLine("Agrega nota:");
                string nota = Console.ReadLine();
                stackDeNotas.Push(nota);
            }
            else if(opcion == "3")
            {
                //Pop
                string nota = stackDeNotas.Pop();
                Console.WriteLine("Nota removida");
                Console.WriteLine(nota);
            }
            else if(opcion == "9")
            {
                Console.WriteLine("Hasta luego!");
            }
        }

           
           
        }
    }
}
