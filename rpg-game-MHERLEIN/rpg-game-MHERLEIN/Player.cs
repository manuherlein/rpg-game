using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame_ManuelHerlein
{
    class Player
    {
        private string name;
        private int posX;
        private int posY;
        private float vidaActualf;
        private int vidaMax;
        private int vidaMin;
        Armas a = new Armas();

        public void SetPlayerName()
        {
            Console.WriteLine("Ingrese el nombre de su personaje, seguido de la tecla INTRO");
            name = Console.ReadLine();
            Console.WriteLine("Hola, " + name + "!");
            return;
        }
        public void SetPlayerPos()
        {
            posX = 10;
            posY = 10;
            return;
        }

        public void SetPlayerVida()
        {
            vidaActualf = 100;
            vidaMax = 100;
            vidaMin = 1;
            return; 
        }
        public void GetPlayerVida()
        {
            Console.WriteLine("Tu vida actual es de " + vidaActualf);
        }
        public void Ataque()
        {
            a.AtaqueEspada();

        }
        public void GetArma()
        {
            a.GetEspada();
        }
    }
}
