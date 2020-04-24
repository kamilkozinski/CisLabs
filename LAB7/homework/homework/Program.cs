using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classes UsageCommand, BreakCommand, Refill Command, Repair Command and Reset Command inherit from Icommand interface
            //Thanks to Game class which works as invoker we could call different commands on classes Handgun or SniperRifle(receivers)
            Weapon glock18 = new Handgun(150, 200, 100);
            Weapon ak47 = new SniperRifle(100, 200, 50);
            
            Game invoker = new Game(glock18);
            invoker.AddToStart(new RepairCommand()); 
            invoker.AddToStart(new RefillCommand());

            invoker.AddOnGoing(new UsageCommand());

            invoker.AddToFinish(new ResetCommand()); 
            invoker.AddToFinish(new BreakCommand());

            //We can see how game is simulated and some attributes are changing

            Console.WriteLine(glock18);

            invoker.StartRound(); 

            Console.WriteLine(glock18);

            invoker.PlayRound();

            Console.WriteLine(glock18);

            invoker.FinishRound();

            Console.WriteLine(glock18);


            //Conductance - original class, IResistance - incompatible interface, ConductanceAdapter - adapter class
            Conductance wire = new Conductance(2, 10, 6);
            ConductanceAdapter adapter = new ConductanceAdapter(wire);
            Console.WriteLine($"\r\nResistance is: {adapter.CalculateResistance():N3}");

        }
    }
}
