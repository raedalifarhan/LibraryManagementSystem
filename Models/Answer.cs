using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Answer
    {
        public Owner owner { get; set; }
        public bool is_accepted { get; set; }
        public long score { get; set; }
        public string last_activity_date { get; set; }
        public string creation_date { get; set; }
        public string answer_id { get; set; }
        public string question_id { get; set; }
        public string content_license { get; set; }
    }
}