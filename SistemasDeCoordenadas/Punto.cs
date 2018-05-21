using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeCoordenadas
{
    public class Punto
    {
        public int x;
        public int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Punto()
        {
            x = -1;
            y = -1;
        }

        public Punto(string dato)
        {
            string x = "";
            for (int i = 0; i < dato.Length; i++)
            {
                if (dato[i] == ',')
                {
                    this.x = Int32.Parse(x);
                    x = "";
                } else {
                    x += dato[i];
                }
            }
            this.y = Int32.Parse(x);
        }

        public int drawableX(int X_OFFSET)
        {
            return x + X_OFFSET;
        }

        public int drawableY(int Y_OFFSET)
        {
            return (y - Y_OFFSET) * -1;
        }

        public override string ToString()
        {
            return x+","+y;
        }
    }
}
