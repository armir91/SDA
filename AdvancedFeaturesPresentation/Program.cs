namespace AdvancedFeaturesPresentation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("We have best class ever!");

        var child = new Child();
        child.MethodOne();
        child.Method();
        // underscore perdoret per variabla qe nuk do perdoren
        _ = Console.ReadLine();
    }
}

public class Base
{
    public void Method()
    {
        Console.WriteLine("This is coming from base class");
    }

}

public class Child : Base
{
    public void MethodOne()
    {
        Console.WriteLine("This is comind from child class");
    }
}