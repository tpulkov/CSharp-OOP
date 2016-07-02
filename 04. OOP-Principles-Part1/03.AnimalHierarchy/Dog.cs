﻿namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal, ISoundable
    {
        public Dog(string name, Gender sex, int age)
            : base(name, sex, age)
        {
            this.Species = Species.Dog;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bau-bau, Waf-waf!");
        }
    }
}
