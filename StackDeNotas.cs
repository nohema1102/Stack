using System;
using System.Collections.Generic;
namespace Stack
{
    class StackDeNotas
    {
        List<string> notas = new List<string>();
        //push > Agregar elemento
        //peek > Ver elemento de arriba
        //Pop > ver + quitar

        //Imprimir stack
        public int Count
        {
            get => this.notas.Count;
        }
        public void Push(string nota)
        {
            //La parte de arriba del stack es el final de la lista
            this.notas.Add(nota);
        }

        public string Pop() //pop:Quitar el valor que esta arriba y devolverlo
        {
            //1 Devolver valor
            //2 Borrar

            //Paso 1 Respaldar valor
            string value = this.notas[this.notas.Count - 1];
            // Paso 2 Borrar de la lista
            this.notas.RemoveAt(this.notas.Count - 1);
            //Devolver el palor respaldado
            return value;
        }
        public string Peek()
        {
            if(this.notas.Count == 0)
            {
                Console.WriteLine("No hay elementos en el stack");
                return null;
            }
            else 
            {
                return this.notas[this.notas.Count - 1];
            }
           
        }
        public void PrintStack()
        
        {
           for (int i = this.notas.Count - 1  ; i >= 0; i--)
           {
               Console.WriteLine(notas[i]);
           }
        }

    }
}