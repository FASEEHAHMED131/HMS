using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HMS.Models
{
    public class AccomodationPackage
    {
        [Key]
        public int AccomodationPackage_ID { get; set; }
        public int AccomodationType_ID { get; set; }
        public AccomodationType AccomodationType { get; set; }
        public string AccomodationPackage_Name { get; set; }
        /// <summary>
        /// No of Rooms in this Package
        /// </summary>
        public int  Rooms { get; set; }
        /// <summary>
        /// The Accomodation Package 
        /// </summary>
        public decimal Package { get; set; }
    }
}