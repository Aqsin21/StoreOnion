﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

    }
}
