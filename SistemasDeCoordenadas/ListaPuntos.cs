using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SistemasDeCoordenadas
{
    public class ListaPuntos: List<Punto>
    {
        StreamWriter escribe;
        StreamReader lee;

        public void guardar()
        {
            escribe = new StreamWriter("puntos.txt");
            foreach (Punto p in this)
            {
                escribe.WriteLine(p.ToString());
            }
            escribe.Close();
        }
    }
}
