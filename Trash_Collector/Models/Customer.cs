﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Customer
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }
        public string PickUpDay { get; set; }

        public string RequestExtraPickUp { get; set; }

        public int PaymentOwed { get; set; }

        public string StartEndPickUpDay { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }
}
