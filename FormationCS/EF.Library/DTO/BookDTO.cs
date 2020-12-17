﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Library.Entities
{
    public class BookDTO : IEntity
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public string FirstAuthor { get; set; }
    }
}
