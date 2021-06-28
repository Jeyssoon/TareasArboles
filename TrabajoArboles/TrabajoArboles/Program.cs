using System;
using System.Collections.Generic;
using ArbolClass;

namespace TrabajoArboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Arbol de expresion");

            var raiz = new Nodo()
            {
                valor = "-",
                Hijos =
                {
                    new Nodo
                    {
                        valor ="+",
                        Hijos =
                        {
                            new Nodo
                            {
                                valor ="/",
                                Hijos =
                                {
                                    new Nodo
                                    {
                                        valor ="*",
                                        Hijos =
                                        {
                                            new Nodo
                                            {
                                                valor ="6"
                                            },
                                            new Nodo
                                            {
                                                valor ="5"
                                            }
                                        }
                                    },
                                    new Nodo
                                    {
                                        valor ="5"
                                    }
                                }

                            },
                            new Nodo
                            {
                                valor ="*",
                                Hijos =
                                {
                                    new Nodo
                                    {
                                        valor ="/",
                                        Hijos =
                                        {
                                            new Nodo
                                            {
                                                valor ="6"
                                            },
                                            new Nodo
                                            {
                                                valor ="3"
                                            }
                                        }
                                    },
                                    new Nodo
                                    {
                                        valor ="8"
                                    }
                                }
                            }
                        }
                    },
                    new Nodo
                    {
                        valor ="*",
                        Hijos =
                        {
                            new Nodo
                            {
                                valor ="7"
                            },
                            new Nodo
                            {
                                valor ="8"
                            }
                        }
                    }
                }
            };

            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz));

            Console.WriteLine($"Numero de Hojas: {manejadorArbol.NumeroHojas(raiz)}");
            Console.WriteLine($"Numero de Nodos: {manejadorArbol.NumeroNodos(raiz)}");
            Console.WriteLine($"Numero de Niveles: {manejadorArbol.NumeroNiveles(raiz)}");

            Queue<string> cola = new Queue<string>();
            cola.Enqueue(manejadorArbol.ImprimirArbol(raiz));
            while (cola.Count > 0)
            {
                Console.WriteLine($"Entrada y salida de cola: {cola.Dequeue()}");
            };

        }

    }
}



