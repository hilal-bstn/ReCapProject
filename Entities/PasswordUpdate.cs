using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class PasswordUpdate : IEntity
    {
        public int UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
