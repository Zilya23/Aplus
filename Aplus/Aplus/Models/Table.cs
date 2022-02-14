using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Aplus.Models
{
[Table("Projects")]
    public class Project
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        [Unique]
        public string NameProject { get; set; }
        public string Description { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
