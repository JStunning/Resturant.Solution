using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Food.Models
{
    public class Resturant 
    {
        
        public string Name {get; set;}
        public int Id {get; set;}
        public string Description {get; set;}
        public int CuisineId { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual Cuisine Cuisine { get; set; }

        public Resturant()
        {
        this.Reviews = new List<Review>();
        }
    }
}