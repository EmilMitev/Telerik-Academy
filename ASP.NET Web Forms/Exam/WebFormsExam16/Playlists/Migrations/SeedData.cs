
namespace Playlists.Migrations
{
    using Microsoft.AspNet.Identity;
    using Models;
    using System;
    using System.Collections.Generic;

    public class SeedData
    {
        public static Random Rand = new Random();

        public List<Category> Categories;

        public List<Playlist> Playlists;

        public List<Rating> Ratings;

        public List<Video> Videos;


        public SeedData()
        {
            this.Categories = new List<Category>();
            for (int i = 1; i <= 5; i++)
            {
                this.Categories.Add(new Category() { Name = $"Art{i}" });
                this.Categories.Add(new Category() { Name = $"Economy{i}" });
                this.Categories.Add(new Category() { Name = $"Technology{i}" });
                this.Categories.Add(new Category() { Name = $"Education{i}" });
                this.Categories.Add(new Category() { Name = $"Sports{i}" });
                this.Categories.Add(new Category() { Name = $"Science{i}" });
                this.Categories.Add(new Category() { Name = $"Weather{i}" });
            }
        }
    }
}
