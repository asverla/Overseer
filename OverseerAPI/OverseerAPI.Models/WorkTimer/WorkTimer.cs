using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OverseerAPI.Models.WorkTimer
{
    public class WorkTimer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime EndedAt { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Duration { get; set; }
        [ForeignKey("Team"), DefaultValue(0)]
        public int? TeamId { get; set; }
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