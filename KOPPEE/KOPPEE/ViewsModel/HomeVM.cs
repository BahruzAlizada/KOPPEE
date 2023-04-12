using KOPPEE.DAL;
using KOPPEE.Models;
using System.Collections.Generic;

namespace KOPPEE.ViewsModel
{
    public class HomeVM
    {
       public List<Product> Products { get; set; }
        public List<Category> Categories { get; set;}
    }
}
