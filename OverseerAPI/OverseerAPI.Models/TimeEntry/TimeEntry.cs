using System;

namespace OverseerAPI.Models.TimeEntry
{
    public class TimeEntry
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Duration { get; set; }
        public string DurationHumanized { get; set; }
        public DateTime Day { get; set; }
        public int TaskId { get; set; }
        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public string Charging { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Running { get; set; }
        public double Money { get; set; }
        public double HourlyRate { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
