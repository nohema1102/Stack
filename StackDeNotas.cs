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

        public void Push(string nota)
        {
            //La parte de arriba del stack es el final de la lista
            this.notas.Add(nota);
        }
        public string Peek()
        {
           return this.notas[this.notas.Count - 1];
        }
    }
}