﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Conversation : IEntity
    {
        public int Id { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
    }
}
