﻿using System;
using System.Collections.Generic;

namespace localbusinessclient.models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}