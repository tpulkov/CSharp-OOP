namespace AnimalHierarchy
{
    using System;

    public class TomCat : Cat, ISoundable
    {
        public TomCat(string name, int age)
            : base(name, Gender.Male, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meaaaawww!");
        }
    }
}
