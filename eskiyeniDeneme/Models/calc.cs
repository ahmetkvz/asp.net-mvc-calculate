using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eskiyeniDeneme.Models
{
    public class calc
    {
        [Key]
        public int Id { get; set; }

       
        public double Sayi1 { get; set; }

      
        public double Sayi2 { get; set; }

        public string Islem { get; set; }

       
        public double Sonuc { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}