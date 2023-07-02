namespace Association
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog("budly","eeew");
            Person p1 = new Person("ahmed",23,d1);
        }
    }
}