using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Food.Models
{
    public class Cuisine
    {
        public string Name {get; set;}
        public int Id {get; set;}
        public virtual ICollection<Resturant> Resturants { get; set; }

        public Cuisine()
        {
        this.Resturants = new List   <Resturant>();
        }

    }

    
}