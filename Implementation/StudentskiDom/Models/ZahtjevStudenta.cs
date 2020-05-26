﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class ZahtjevStudenta : Zahtjev
    {
        private Student podnosilacZahtjeva;

        public Student PodnosilacZahtjeva
        {
            get { return podnosilacZahtjeva; }
            set { podnosilacZahtjeva = value; }
        }

        public ZahtjevRestorana(Student podnosilacZahtjeva, DateTime datum) : base(datum)
        {
            this.podnosilacZahtjeva = podnosilacZahtjeva;
        }
    }
}