﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsOrderAPI.Models
{
    public class FoodItem
    {
        [Key]
        public long Id { get; set; }
        public string ImgSource { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
    }
}
