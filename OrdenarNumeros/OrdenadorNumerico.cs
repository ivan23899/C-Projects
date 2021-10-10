using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarNumeros
{
    public class OrdenadorNumerico
    {
        public List<int> ordenarDescendente(List<int> listanumeros)
        {
            List<int> ordenados = listanumeros;
            ordenados.Sort((a,b)=>b.CompareTo(a));
            return ordenados;
        }
        public List<int> ordenarAscendente(List<int> listanumeros)
        {
            List<int> ordenados = listanumeros;
            ordenados.Sort((a, b) => a.CompareTo(b));
            return ordenados;
        }
    }
}
