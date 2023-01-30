using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_Sim.Clases3
{
    public class Clase3
    {
        public int IdDemanda { get; set; }
        public int CantidadRequerida { get; set; }
        public int CantidadProgramada { get; set; }
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        

        public int numeroDatos { get; set; }
        public Clase3()
        {
        }
        public Clase3(Clase3 demanda3   )
        {
            IdDemanda = demanda3.IdDemanda;
            CantidadRequerida = demanda3.CantidadRequerida;
            CantidadProgramada = demanda3.CantidadProgramada;
            numeroDatos = demanda3.numeroDatos;
            a = demanda3.a;
            b = demanda3.b;
            c = demanda3.c;
            x = demanda3.x;
            y = demanda3.y;
            z = demanda3.z;
        }
    }
}
