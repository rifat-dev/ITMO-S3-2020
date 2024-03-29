﻿using System;
namespace Code_of_lab_3
{
    public class Broom : AirTransportsRace
    {
        public Broom(string name, int speed)
                : base(name, speed)
        {}
        public override double distance_reducer(double distance)
                { return distance * (1 - (0.01 * Math.Truncate(distance / 1000))); }
    }
}
