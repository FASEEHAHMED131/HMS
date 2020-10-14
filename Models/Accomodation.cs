using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Models
{
    public class Accomodation
    {
        public int Accomodation_ID { get; set; }
        public int AccomodationPackageID { get; set; }
        public AccomodationPackage AccomodationPackage { get; set; }
        /// <summary>
        /// Room Number for the selected Packages
        /// </summary>
        public int Room_Number { get; set; }
        /// <summary>
        /// Status of room
        /// either occupied(true) or not (false)
        /// </summary>
        public bool status { get; set; }
    }
}