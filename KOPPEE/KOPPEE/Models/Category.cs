﻿using System.Collections.Generic;

namespace KOPPEE.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public bool IsDeactive { get; set; }
    }
}
