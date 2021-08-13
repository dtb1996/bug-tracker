using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public string Project { get; set; }
        public string Status { get; set; }
        /*
        public DateTime CreationDate { get; set; }
        public string Submitter { get; set; }
        public string AssignedUser { get; set; }
        public string Priority { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        */
    }
}