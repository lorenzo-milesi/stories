﻿using System;

namespace Stories.Meta
{
    public class ProjectIndexMeta
    {
        public int Page { get; set; }
        public int LastPage => (int) Math.Ceiling((double) Count / (double) Limit);
        public int Limit { get; set; }
        public int Count { get; set; }

        public string Next
        {
            get
            {
                if (Page < LastPage)
                {
                    return $"/api/Projects?page={Page + 1}&limit={Limit}";
                }

                return "";
            }
        }

        public string Prec
        {
            get
            {
                if (Page > 1)
                {
                    return $"/api/Projects?page={Page - 1}&limit={Limit}";
                }

                return "";
            }
        }
    }
}