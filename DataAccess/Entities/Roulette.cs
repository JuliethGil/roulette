﻿using System;

namespace DataAccess.Entities
{
    public class Roulette
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? WinningNumber { get; set; }
        public bool Status { get; set; }
        public DateTime? OpeningDate { get; set; }
        public DateTime? EndingDate { get; set; }
    }
}
