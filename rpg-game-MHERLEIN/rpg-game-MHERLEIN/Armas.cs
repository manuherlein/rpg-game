using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame_ManuelHerlein
{
    class Armas
    {
        private int espada;
        private int armaEnem;

        public void GetEspada()
        {
            Console.WriteLine("Conseguiste una Espada!");
        }
        public void AtaqueEspada()
        {
            espada = 25;
            Console.WriteLine("Hiciste un daño de 25");
        }
        public void AtaqueEnemigo()
        {
            armaEnem = 10;
            Console.WriteLine("El enemigo hizo un dañ de 10");
        }
    }
}
