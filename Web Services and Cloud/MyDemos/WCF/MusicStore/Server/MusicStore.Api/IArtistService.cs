namespace MusicStore.Api
{
    using MusicStore.Api.Models;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    [ServiceContract]
    public interface IArtistService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/api/artists", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<ArtistsDetailsResponseModel> GetAll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/api/artists/{id}", ResponseFormat = WebMessageFormat.Json)]
        ArtistsDetailsResponseModel GetById(string id);
    }
}
