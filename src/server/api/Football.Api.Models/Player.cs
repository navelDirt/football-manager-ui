﻿using System;
using System.Collections.Generic;

namespace Football.Api.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string CountryOfBirth { get; set; }
        public string Nationality { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }

        public string TeamCode { get; set; }
    }
}
