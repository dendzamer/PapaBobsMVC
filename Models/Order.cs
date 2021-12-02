using System;
using System.ComponentModel.DataAnnotations;

namespace PapaBob.Models
{
    public class Order
    {
        public int OrderId {get;set;}

        public string Size { get; set; }

        public string Crust {get; set;}



        [Display(Name = "Sausage (+ $2)")]
        public bool Sausage {get; set;}

        [Display(Name = "Pepperoni (+ $1.50)")]
        public bool Pepperoni {get; set;}

        [Display(Name = "Green Peppers (+ $1)")]
        public bool GreenPeppers {get; set;}

        [Display(Name = "Onions (+ $1)")]
        public bool Onions {get; set;}

        public string Name {get; set;}

        public string Address {get; set;}

        public int Zip {get; set;}

        public string Phone {get; set;}

        public string Payment {get; set;}

        public double Price {get; set;}
    }
}