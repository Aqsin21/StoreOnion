using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class Product : Entity
    {

        public string Name { get; set; }

        public int CategoryId { get; set; }


        public Category Category { get; set; }


    }


    public class Entity
    {
        public int Id { get; set; }
    }
}
