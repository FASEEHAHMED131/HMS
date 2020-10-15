using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HMS.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        /// <summary>
        /// Referecing to the user who booked
        /// </summary>
        public int UserID { get; set; }
        public User User { get; set; }
        /// <summary>
        /// The Accomodation Selected is this,
        /// </summary>
        public int AccomodationID { get; set; }
        public Accomodation Accomodation { get; set; }
        /// <summary>
        /// Date of Booking
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Duration of the nights to stay
        /// </summary>
        public int Duration { get; set; }
    }
}