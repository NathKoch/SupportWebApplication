using System.ComponentModel.DataAnnotations;

namespace SupportWebApplication.Models
{
    public class Appeal
    {
        public required string Id { get; set; }

        public string Description { get; set; }

        public DateTime SubmissionTime { get; set; }

        public DateTime Deadline { get; set; }

        public bool IsResolved { get; set; }
    }
}
