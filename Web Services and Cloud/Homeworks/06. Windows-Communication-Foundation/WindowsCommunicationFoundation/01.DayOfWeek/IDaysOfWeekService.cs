namespace _01.DayOfWeek
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    [ServiceContract]
    public interface IDaysOfWeekService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Day")]
        string GetData(DateTime dateTime);
    }
}
