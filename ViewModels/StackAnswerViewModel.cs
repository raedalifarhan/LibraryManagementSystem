using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.ViewModels
{
    public class StackAnswerViewModel
    {
        public List<Answer> items { get; set; }

        public bool has_more { get; set; }

        public int quota_max { get; set; }

        public int quota_remaining { get; set; }
    }
}
