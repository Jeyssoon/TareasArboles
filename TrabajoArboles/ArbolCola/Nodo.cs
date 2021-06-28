using System;
using System.Collections.Generic;

namespace ArbolClass 
{
    public class Nodo
    {
        public int Id { get; set; }
        public string valor { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();
    }
}
