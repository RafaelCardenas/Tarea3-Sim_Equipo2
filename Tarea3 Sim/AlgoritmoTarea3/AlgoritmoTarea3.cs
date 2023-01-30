using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3_Sim.Clases3;

namespace Tarea3_Sim.AlgoritmoTarea3
{
    public class Algoritmotarea3
    {
        public List<Clase3> listaNumeros = new List<Clase3>();
        public Algoritmotarea3()
        {

        }
        public List<int> CalcularMetodo(int numeroDatos, int x, int y, int z)
        {
            int a = 0, b = 0, c = 0, semilla = 0;
            //Creo que tenemos que borrar int semilla arriba
            List<int> variables = new List<int>();
            for (int i = 0; i < numeroDatos; i++)
            {
                x = semilla;
                y = (a * x) + b;
                z = y % c;
                variables.Add(z);
            }
            return variables;


        }
    }
}