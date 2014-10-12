using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OverseerAPI.Models.WorkTimer
{
    public class WorkTimer
    {
        public WorkTimer()
        {
            Users = new List<User.User>();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkTimerId { get; set; }
        public DateTime? EndedAt { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public virtual ICollection<User.User> Users { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Duration { get; set; }
        [ForeignKey("Team"), DefaultValue(0)]
        public int TeamId { get; set; }
        public virtual Team.Team Team { get; set; }
        [DefaultValue(0)]
        public int WorkType { get; set; }
    }
}

/*
# == Schema Information
#
# Table name: work_timers
#
#  id         :integer          not null, primary key
#  ended_at   :datetime
#  user_id    :integer
#  created_at :datetime
#  updated_at :datetime
#  duration   :integer
#  team_id    :integer          default(0)
#  work_type  :integer          default(1)
#
 */