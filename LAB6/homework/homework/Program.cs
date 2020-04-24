using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Composite presentation:");
            Console.WriteLine(" ");

            IAlterWeapon superzoom = new ZoomX4();
            IAlterWeapon magazine = new ExtraMagazine();
            IAlterWeapon silencer = new Silencer();

            SniperRifle ak47 = new SniperRifle(100, 250, superzoom);
            GranadeLauncher m203 = new GranadeLauncher(2, 20, magazine);
            Handgun colt1911 = new Handgun(10, 50, superzoom);

            Equipment eq = new Equipment();
            eq.Add(colt1911);
            eq.Add(m203);
            eq.Add(ak47);
            Console.WriteLine(eq);
            //Thank's to Composite we can refiil ammo in all weapons in our equipment using one object 
            eq.RefillAmmo();
            Console.WriteLine(eq);
            // Or set all stock to 0
            eq.ResetAmmo();
            Console.WriteLine(eq);

            Console.WriteLine(" ");
            Console.WriteLine("Decorator presentation:");
            Console.WriteLine(" ");

            //Using Decorator it's possible to "decorate" weapon with extra silencer, telescopic zoom and additional magazine at the same time
            silencer = new MagazineDecorator(silencer);
            silencer = new ZoomX4Decorator(silencer);
            SniperRifle m4a1s = new SniperRifle(100, 250, silencer);
            m4a1s.PrintAddonInfo();



        }
    }
}
