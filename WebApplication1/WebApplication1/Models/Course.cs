﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class Course
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
        public int DurationWeeks { get; set; }
    }
}