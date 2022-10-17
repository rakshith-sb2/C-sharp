using System;
using System.Collections.Generic;

namespace netcoremvc
{
    public partial class UserActivation
    {
        public int UserId { get; set; }
        public Guid ActivationCode { get; set; }
    }
}
