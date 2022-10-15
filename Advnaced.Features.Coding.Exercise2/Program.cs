namespace Advanced.Features.Coding.Shared;


    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();

            nameList.Add("ArmIr");
            nameList.Add("aRmir");
            nameList.Add("serin");
            nameList.Add("ReNi");
            nameList.Add("Kastriot");
            nameList.Add("tauLant");
            nameList.Add("Bledi");

            var orderedListCase = Helpers.ListMethod(nameList);

            foreach (var element in orderedListCase)
            {
                Console.WriteLine(element);
            }
        }
    }
