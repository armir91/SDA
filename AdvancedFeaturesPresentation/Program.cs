namespace AdvancedFeaturesPresentation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("We have best class ever!");

        // This is a child oblect created from child
        var child = new Child();
        child.MethodOne();
        child.Method();
        child.virtualMethod();

        // underscore perdoret per variabla qe nuk do perdoren
        _ = Console.ReadLine();
    }
}

public abstract class Base
{
    public void Method()
    {
        Console.WriteLine("This is coming from base class");
    }

    // this method will be hidden in child
    public void HideMethod()
    {
        Console.WriteLine("Hide method from BAse");
    }


    public virtual void virtualMethod()
    {
        Console.WriteLine("This is virtual methd and is coming from base class");
    }

    /*public abstract void OverrideItem();*/
}

public class Child : Base
{
    public void MethodOne()
    {
        Console.WriteLine("This is comind from child class");
    }

    // This is intended to be hidden with new keyword.
    public new void HideMethod(){}

    public override void virtualMethod()
    {
        Console.WriteLine("No no i am a child");
        base.virtualMethod();
    }
}