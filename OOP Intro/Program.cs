namespace OOP_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine myEngine = new("POWER 500");
            Train myTrain = new("Izu", ["Piccadilly", "District", "Circle"], ["Platform 1", "Platform 2"], myEngine);


            Console.WriteLine(myTrain.Name);
        }
    }
}
