﻿using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_04
{
    public struct Movie 
    {
        public string Title;
        public int Rating;

        public Movie(string title, int rating)
        {
            Title = title;
            Rating = rating;
        }
    }
}