﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademySystem.Models
{
    public class Homework
    {
        public int Id { get; set; }

        public byte[] Content { get; set; }

        public DateTime TimeSent { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
