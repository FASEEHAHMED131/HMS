using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HMS.Models
{
    public class AccomodationType
    {
        [Key]
        public int AcccomodationType_ID { get; set; }
        public string AcccomodationType_Name { get; set; }
    }
}