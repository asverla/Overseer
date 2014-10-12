using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverseerAPI.Models.Team
{
    public class TeamMember
    {
        public TeamMember()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamMemberId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User.User User { get; set; }
        public string TeamRole { get; set; }
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Models.Team.Team Team { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int HourlyRate { get; set; }
        public int InternalHourlyRate { get; set; }
        public string SalaryType { get; set; }
        public double CostPerWorkUnit { get; set; }
        public int ExpectedDailyHours { get; set; }
        [DefaultValue(true)]
        public bool Active { get; set; }
        public DateTime? DeactivatedAt { get; set; }
        public string Settings { get; set; }
        public int TimeReportsUserId { get; set; }
        public string Phone { get; set; }
        //[ForeignKey("Customer")]
        //public int? CustomerId { get; set; }
    }
}

/*
# == Schema Information
#
# Table name: team_members
#
#  id                   :integer          not null, primary key
#  user_id              :integer
#  team_role            :string(255)
#  team_id              :integer
#  created_at           :datetime
#  updated_at           :datetime
#  hourly_rate          :integer
#  internal_hourly_rate :integer
#  salary_type          :string(255)
#  cost_per_work_unit   :float
#  expected_daily_hours :integer
#  active               :boolean          default(TRUE)
#  deactivated_at       :datetime
#  settings             :text
#  time_reports_user_id :integer
#  phone                :string(255)
#  customer_id          :integer
#
 */
