using System;

namespace ConsoleApplication1
{
    public class Archer : Unit
    {
        public string ShootWithBow { get; set; }
        
        public override void Attack()
        {
            Console.WriteLine($"An archer shoots a bow at a distance {ShootWithBow} and deals damage {Damage}");
        }
    }
}