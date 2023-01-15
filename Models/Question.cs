namespace LibraryManagementSystem.Models
{
    public class Question
    {
        public List<string> tags { get; set; }

        public string link { get; set; }

        public Owner owner { get; set; }

        public bool is_answered { get; set; }

        public long view_count { get; set; }

        public string last_activity_date { get; set; }

        public long score { get; set; }

        public long answer_count { get; set; }

        public string creation_date { get; set; }

        public string question_id { get; set; }

        public string title { get; set; }
    }
}
