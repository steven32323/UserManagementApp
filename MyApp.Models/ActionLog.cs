using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class ActionLog : ModelBase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ActionType { get; set; }
        public DateTime ActionDate { get; set; }
    }
}
