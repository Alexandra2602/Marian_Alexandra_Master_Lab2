﻿namespace Marian_Alexandra_Lab2.Models
{
    public class City
    {
        public int ID { get; set; }
        public string CityName { get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
