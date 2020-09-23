using System;

namespace Trabajo_Practico_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Superpoder superfuerza = new Superpoder(true, 3);

            Superheroe ironman = new Superheroe(5, superfuerza);

            Villano thanos = new Villano();
            
            Combate combate = new Combate(ironman,thanos,ironman,2);

            Juego juego = new Juego();

            System.Console.WriteLine(juego.GetCombates().ToString());
        }
    }
}
