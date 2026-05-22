namespace D11416214_W10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person p1=new Person();
           IName p2 = new Person();
           Console.WriteLine(p2.GetName());
            IName s1=new Student();
            Console.WriteLine(s1.GetNamber());
        }
    }
}
