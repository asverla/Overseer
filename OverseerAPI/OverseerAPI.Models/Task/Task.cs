using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverseerAPI.Models.Task
{
    public class Task
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskId { get; set; }
        public string Title { get; set; }
        public int Budget { get; set; }
        public int EstimatedTime { get; set; }
        public int Status { get; set; }
        public int PlannedToBePerformedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project.Project Project { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User.User User { get; set; }
        public string Description { get; set; }
        public int TotalTime { get; set; }
        public bool Done { get; set; }
        //public int CustomerId { get; set; }
        public bool Chargeable { get; set; }
        public int WorkerId { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime FinishedAt { get; set; }
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team.Team Team { get; set; }
        public double Velocity { get; set; }
        public bool PayPerHour { get; set; }
        public DateTime EarliestStart { get; set; }
        public bool Inbox { get; set; }
        public int InboxOfUser { get; set; }
        public string Charging { get; set; }
        //public int MilestoneId { get; set; }
        public double AlreadyInvoicedAmount { get; set; }
        public int AlreadyInvoicedSeconds { get; set; }
        public int Priority { get; set; }
        public int EstimatedRemainingTime { get; set; }
        public bool Hidden { get; set; }
        public DateTime HideUntil { get; set; }
        //public int TaskListId { get; set; }
        public int Position { get; set; }
        public DateTime CompletedOn { get; set; }
        public int CommentsCount { get; set; }
        public int SubtasksCount { get; set; }
        public double VatPercentage { get; set; }
        [ForeignKey("LastUpdatedBy")]
        public int LastUpdatedById { get; set; }
        public virtual User.User LastUpdatedBy { get; set; }
    }
}

/*
 # == Schema Information
#
# Table name: tasks
#
#  id                         :integer          not null, primary key
#  title                      :string(255)
#  budget                     :integer
#  estimated_time             :integer
#  status                     :integer
#  planned_to_be_performed_at :datetime
#  created_at                 :datetime
#  updated_at                 :datetime
#  project_id                 :integer
#  user_id                    :integer
#  description                :text
#  total_time                 :integer          default(0)
#  done                       :boolean          default(FALSE)
#  customer_id                :integer
#  chargeable                 :boolean          default(TRUE)
#  worker_id                  :integer
#  deadline                   :date
#  finished_at                :datetime
#  planning                   :boolean          default(FALSE)
#  team_id                    :integer
#  velocity                   :float
#  pay_per_hour               :boolean          default(TRUE)
#  earliest_start             :date
#  inbox                      :boolean          default(FALSE)
#  inbox_of_user              :integer
#  charging                   :string(255)
#  milestone_id               :integer
#  already_invoiced_amount    :float            default(0.0)
#  already_invoiced_seconds   :integer          default(0)
#  priority                   :integer          default(2)
#  estimated_remaining_time   :integer          default(0)
#  hidden                     :boolean          default(FALSE)
#  hide_until                 :date
#  task_list_id               :integer
#  position                   :integer
#  completed_on               :date
#  comments_count             :integer          default(0)
#  subtasks_count             :integer          default(0)
#  vat_percentage             :float            default(25.0)
#  last_updated_by_id         :integer
#

 */