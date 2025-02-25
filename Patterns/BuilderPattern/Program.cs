using BuilderPattern;

class Program
{
    static void Main(string[] args)
    {
        IComputerBuilder gamingBuilder = new GamingComputerBuilder();
        ComputerDirector director = new ComputerDirector(gamingBuilder);

        director.ConstructComputer();
        Computer gamingComputer = gamingBuilder.GetComputer();
        Console.WriteLine(gamingComputer);

        IComputerBuilder officeBuilder = new OfficeComputerBuilder();
        director = new ComputerDirector(officeBuilder);

        director.ConstructComputer();
        Computer officeComputer = officeBuilder.GetComputer();
        Console.WriteLine(officeComputer);

    }
}