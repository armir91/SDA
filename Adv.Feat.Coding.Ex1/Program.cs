using Advanced.Features.Coding.Shared;
using System.Linq;
using System.Net;

namespace Adv.Feat.Coding.Ex1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> nameList = new List<string>();

            nameList.Add("Armir");
            nameList.Add("armir");
            nameList.Add("serin");
            nameList.Add("Reni");
            nameList.Add("Kastriot");
            nameList.Add("taulant");
            nameList.Add("Bledi");

            var orderedList =  Helpers.ListMethod(nameList);

            foreach (var element in orderedList)
            {
               Console.WriteLine(element);
            }

        }
    }
}