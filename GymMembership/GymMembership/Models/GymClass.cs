using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Web;

namespace GymMembership.Models
{
    public class GymClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Column (TypeName ="Datetime2")]
        //[DisplayFormat(ApplyFormatInEditMode = true,DataFormatString ="0:yyyy-MM-dd HH:mm")]
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        [Column(TypeName = "Datetime2")]
        public DateTime EndTime { get { return StartTime + Duration; } }
        public string Description { get; set; }

        public virtual ICollection<ApplicationUser> AttendingMembers { get; set; }

    }
}