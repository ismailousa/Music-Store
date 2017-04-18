﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Music_Store.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public string CardId { get; set; }
        public int AlbumId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }

        public virtual Album Album { get; set; }
    }
}