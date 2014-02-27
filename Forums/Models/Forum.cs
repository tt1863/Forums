using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forums.Models
{
    [Table("Forums")]
    public class Forum
    {
        public int ForumId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Sequence { get; set; }

        public virtual List<Thread> Threads { get; set; }
    }
}