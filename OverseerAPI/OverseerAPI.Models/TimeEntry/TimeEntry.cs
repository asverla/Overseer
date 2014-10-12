using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OverseerAPI.Models.TimeEntry
{
    public class TimeEntry
    {
        public TimeEntry()
        {
            Users = new List<User.User>();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimeEntryId { get; set; }
        public DateTime? StartedAt { get; set; }
        //[ForeignKey("Task")]
        //public int? TaskId { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project.Project Project { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public virtual ICollection<User.User> Users { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [DefaultValue(0)]
        public int Duration { get; set; }
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team.Team Team { get; set; }
        public string Description { get; set; }
        public string Charging { get; set; }
        //[ForeignKey("Milestone")]
        //public int MilestoneId { get; set; }
        //[ForeignKey("Workplan")]
        //public int WorkPlanId { get; set; }
        [DefaultValue(true)]
        public bool Running { get; set; }
        public string Log { get; set; }
        public DateTime? Day { get; set; }
        [DefaultValue(0)]
        public int PreviousDuration { get; set; }
        public decimal BilledAmount { get; set; }
        [DefaultValue(false)]
        public bool Approved { get; set; }

    }
}

/*
# == Schema Information
#
# Table name: time_entries
#
#  id                :integer          not null, primary key
#  started_at        :datetime
#  task_id           :integer
#  project_id        :integer
#  user_id           :integer
#  created_at        :datetime
#  updated_at        :datetime
#  duration          :integer          default(0)
#  team_id           :integer
#  description       :string(255)
#  charging          :string(255)
#  milestone_id      :integer
#  work_plan_id      :integer
#  running           :boolean          default(TRUE)
#  log               :text
#  day               :date
#  previous_duration :integer          default(0)
#  billed_amount     :decimal(8, 2)
#  approved          :boolean          default(FALSE)
#

 */