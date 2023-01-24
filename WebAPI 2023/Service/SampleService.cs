using System.Xml.Linq;
using WebAPI_2023.Models;

namespace WebAPI_2023.Services
{
    public class SampleService : ISampleService
    {
        public MyCustomModel myCustomModel(MyCustomModel customModel)
        {
           return customModel;
        }

        public string Test(string s)
        {
            Console.WriteLine("Test Done");
            return "Your message was : " + s;
        }

        public void XmlMethod(XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }
    }
}
