using System;
using System.Collections.Generic;

namespace BeanFiendAPI.Model
{
    public class Beaner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Coffee> Coffees
        {
            get; set;
        }
    }
}
