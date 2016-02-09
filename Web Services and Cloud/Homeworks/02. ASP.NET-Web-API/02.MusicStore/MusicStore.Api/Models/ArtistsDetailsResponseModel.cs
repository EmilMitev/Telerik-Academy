namespace MusicStore.Api.Models
{
    using MusicStore.Models;
    using System;
    using System.Linq.Expressions;

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

        public string Name { get; set; }

        public string Country { get; set; }
    }
}
