﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChaosMVCFIRSTAPP.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int AlbumID { get; set; }

        public virtual Album Album { get; set; }

        public string Contents { get; set; }

        public string ReviewerEmail { get; set; }
    }
}