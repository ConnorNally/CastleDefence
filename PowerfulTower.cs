using System;

namespace TreehouseDefense
{
    class PowerfulTower : Tower
    {
        protected override int Power {get; } = 2;

        public PowerfulTower(MapLocation location) : base(location)
        {}

        public override bool IsSuccessfulShot()
        {
            if(Random.NextDouble() < Accuracy)
            {
                Console.WriteLine("Archer charges up!");
                return true;
            }
            else            
            {
                return false;
            }
        }
    }
}