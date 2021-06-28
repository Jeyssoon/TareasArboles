using System;
using System.Linq;

namespace ArbolClass
{
    public class ManejadorArbol
    {
        public string ImprimirArbol(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.valor;

            return $"({ ImprimirArbol(nodo.Hijos[0])} { nodo.valor} {ImprimirArbol(nodo.Hijos[1])})";
        }
        private bool SoyHoja(Nodo nodo)
        {
            return !nodo.Hijos.Any();
        }
        public int NumeroHojas(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;

            int totalHojas = 0;
            foreach (var hijoActual in nodo.Hijos)
            {
                totalHojas += NumeroHojas(hijoActual);
            }
            return totalHojas;
        }

        public int NumeroNodos(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;
            int totalNodos = 0;
            foreach (var nodoActual in nodo.Hijos)
            {
                totalNodos += NumeroNodos(nodoActual);
            }
            return totalNodos + 1;
        }

        public int NumeroNiveles(Nodo nodo)
        {
            if (nodo == null)
                return 0;

            var nivelHijos = 0;
            foreach (var nodoActual in nodo.Hijos)
            {
                var nivelActual = NumeroNiveles(nodoActual);
                if (nivelHijos < nivelActual)
                    nivelHijos = nivelActual;
            }
            return ++nivelHijos;
        }
    }
}
