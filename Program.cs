using Capa_Logica.Lista_Simple;
using Capa_Modelo.Nodo;
using System;

class Program
{
    static void Main(string[] args)
    {
        Orquestador orquestador = new Orquestador();

        orquestador.Agregar_NodoInt(1);
        orquestador.Agregar_NodoInt(2);
        orquestador.Agregar_NodoInt(3);
        orquestador.Agregar_NodoInt(4);
        orquestador.Agregar_NodoInt(5);
        Console.WriteLine("Lista original:");
        orquestador.Mostrar_Lista_Simple();

        Console.WriteLine("Ingrese la cantidad de nodos que desea eliminar (hasta 5 nodos):");
        int cantidadNodos = Convert.ToInt32(Console.ReadLine());

        if (cantidadNodos >= 1 && cantidadNodos <= 5)
        {
            for (int i = 0; i < cantidadNodos; i++)
            {
                Console.WriteLine("Ingrese el valor del nodo que desea eliminar:");
                int valueToRemove = Convert.ToInt32(Console.ReadLine());
                orquestador.EliminarNodo(valueToRemove);

            }

            Console.WriteLine("Lista después de eliminar nodos:");
            orquestador.Mostrar_Lista_Simple();
        }
        else
        {
            Console.WriteLine("La cantidad de nodos a eliminar debe estar entre 1 y 5.");
        }
    }
}


