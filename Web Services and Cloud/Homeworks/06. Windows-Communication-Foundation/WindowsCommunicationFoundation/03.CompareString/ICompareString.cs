namespace _03.CompareString
{
    using System.ServiceModel;

    [ServiceContract]
    public interface ICompareString
    {
        [OperationContract]
        int Contains(string firstString, string secondString);
    }
}
