using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace AspCoreCrud.Models
{
    public class tblColdDrink 
    {
        [Key]
        public int  intColdDrinksId { get; set; }
        public string strColdDrinksName { get; set; }
        public double numQuantity { get; set; }
        public double numUnitPrice { get; set; }
    }
}
