using System;
using System.Collections.Generic;

namespace MyApp.Models
{
    public class User : ModelBase
    {
        public string Forename { get; set; }

        public string Surname { get; set; }

        public bool IsActive { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<ActionLog> ActionLogs { get; set; } = new List<ActionLog>();
    }
}