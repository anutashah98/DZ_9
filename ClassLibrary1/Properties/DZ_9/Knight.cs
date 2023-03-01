using System;

namespace ConsoleApplication1
{
    public class Knight : Unit
    {
        public override void Attack()
        {
            Console.WriteLine($"The knight strikes with a sword: {Damage}");
        }
    }
}