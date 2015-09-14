﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Theater.Models
{
    public class News
    {
        public int NewsId { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Author { get; set; }
    }
}