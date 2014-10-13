using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace OverseerAPI.Models.Project
{
    public class ProjectMember
    {
        public ProjectMember()
        {
            Users = new List<User.User>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectMembersId { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public virtual ICollection<User.User> Users { get; set; }
        public int ProjectRole { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [DefaultValue(0)]
        public int ProjectStatus { get; set; }
        [DefaultValue(0)]
        public int Position { get; set; }
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team.Team Team { get; set; }
        public string TitleInProject { get; set; }
        [DefaultValue(false)]
        public bool ResponsibleForProject { get; set; }
        [ForeignKey("TeamMember")]
        public int TeamMemberId { get; set; }
        public virtual Team.TeamMember TeamMember { get; set; }
    }
}

/*
# == Schema Information
#
# Table name: project_memberships
#
#  id                      :integer          not null, primary key
#  project_id              :integer
#  user_id                 :integer
#  project_role            :integer
#  created_at              :datetime
#  updated_at              :datetime
#  project_status          :integer          default(0)
#  position                :integer          default(0)
#  team_id                 :integer
#  title_in_project        :string(255)
#  responsible_for_project :boolean          default(FALSE)
#  team_member_id          :integer
#
 */