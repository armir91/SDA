namespace AdvancedFeaturesSubclasses;

internal class Program
{
    public static void Main(string[] args)
    {
        Trumpet t1 = new Trumpet("trumpet", true, false);
    }

    public class Instrument
    {
        string type;
        bool clean;

        public Instrument(string type, bool clean)
        {
            this.type = type;
            this.clean = clean;
        }
    }

    public class Trumpet : Instrument
    {
        bool oiled;

        public Trumpet(string type, bool clean, bool oiled) : base( type,  clean)
        {
            this.oiled = oiled;
        }
    }
}