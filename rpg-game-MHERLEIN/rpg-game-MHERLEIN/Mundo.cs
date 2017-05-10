using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame_ManuelHerlein
{
    class Mundo
    {
        Player p = new Player();
        Enemigo e = new Enemigo();

        private int mundo;
        private int dimensionX;
        private int dimensionY;

        public void SetDimension()
        {
            dimensionX = 100;
            dimensionY = 100;
            Console.WriteLine("El mundo tiene un tamaño de " + dimensionX + "X" + dimensionY);
        }

        public void CrearMundo()
        {
            Console.WriteLine("El mundo ha sido creado");
            return;
        }

    }
}
