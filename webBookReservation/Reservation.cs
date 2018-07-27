using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webBookReservation
{
    public class Reservation
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Student Student { get; set; }
        public bool Doyoureserve { get; set; }
        public int Date { get; set; }
    }
}