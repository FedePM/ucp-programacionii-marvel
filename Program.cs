namespace Trabajo_Practico_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Superpoder superfuerza = new Superpoder(true, 3);

            Superheroe ironman = new Superheroe("Iron Man",1963,"Marvel",100,5, superfuerza);

            Villano thanos = new Villano("Thanos",1973,"Marvel",100);
            
            Combate combate = new Combate(ironman,thanos,2);
        }
    }
}
