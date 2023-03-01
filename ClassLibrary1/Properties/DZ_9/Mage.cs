using System;

namespace ConsoleApplication1
{
    public class Mage : Unit
    {
        public int Magic { get; set; }
        
        public override void Attack()
        {
            Console.WriteLine($"The magician uses {Magic} magic and deals damage {Damage}");
        }
    }
}