﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class UserOperationClaim
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public string OperationClaimId { get; set; }
    }
}
