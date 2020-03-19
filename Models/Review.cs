using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Food.Models
{
    public class Review 
    {
        public string UserName {get; set;}
        public int Id {get; set;}
        public string ReviewDescription {get; set;}
        public int Rating {get; set;}
        public int ResturantId { get; set; }
        public virtual Resturant Resturant { get; set; }
    }
    
}