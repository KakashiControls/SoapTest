using System.ServiceModel;

namespace WebAPI_2023.Models
{
    [ServiceContract]
    public interface ISampleService
    {

        [OperationContract]
        string Test(string s);

        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);

        [OperationContract]
        MyCustomModel myCustomModel(MyCustomModel customModel);
    }
}
