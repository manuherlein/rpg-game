using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame_ManuelHerlein
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            Enemigo e = new Enemigo();
            Mundo m = new Mundo();

            m.CrearMundo();
            m.SetDimension();
            p.SetPlayerName();
            p.SetPlayerPos();
            e.SetEnemyPos();
            p.SetPlayerVida();
            e.SetEnemyVida();
            p.GetPlayerVida();
            p.GetArma();
            p.Ataque();
            

            Console.Read();
        }
    }
}
