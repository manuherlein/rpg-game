using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame_ManuelHerlein
{
    class Enemigo
    {
        Armas a = new Armas();
        private int posX;
        private int posY;
        private float vidaActualf;
        private int vidaMax;
        private int vidaMin;

        public void SetEnemyPos()
        {
            posX = 10;
            posY = 10;
            return;
        }

        public void SetEnemyVida()
        {
            vidaActualf = 50;
            vidaMax = 50;
            vidaMin = 1;
            return;
        }
        public void Ataque()
        {
            a.AtaqueEnemigo();
        }

    }
}
