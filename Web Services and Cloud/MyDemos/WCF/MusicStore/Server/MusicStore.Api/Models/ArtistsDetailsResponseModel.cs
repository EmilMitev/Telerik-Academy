namespace MusicStore.Api.Models
{
    using MusicStore.Models;
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;

    [DataContract]
    public class ArtistsDetailsResponseModel
    {
        public static Expression<Func<Artist, ArtistsDetailsResponseModel>> FromModel
        {
            get
            {
                return s => new ArtistsDetailsResponseModel
                {
                    Name = s.Name,
                    Country = s.Country,
                };
            }
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Country { get; set; }
    }
}
