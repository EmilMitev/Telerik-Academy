namespace RealEstateWCF.Api
{
    using Common.Models;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Itop" in both code and config file together.
    [ServiceContract]
    public interface ITop
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/users", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<WcfUserResponseModel> GetAll();
    }
}
