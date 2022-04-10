namespace AnimalProject
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("Each Animal Makes Sound");
        }
    }
}