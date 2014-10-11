using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OverseerAPI.Models.User
{
    public class User
    {
        public User()
        {
        }

        public User(string id, string username)
        {
            AspNetUserId = id;
            Username = username;
        }

        [Key]
        public string AspNetUserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string TimeZone { get; set; }
        public DateTime LastActive { get; set; }
        public string MainUserType { get; set; }
        public string ApiKey { get; set; }
        public string Locale { get; set; }
        public string ProfilePictureFileName { get; set; }
        public int ProfilePictureFileSize { get; set; }
        public string Settings { get; set; }
        [ForeignKey("WorkTimer")]
        public int? WorkTimerId { get; set; }
        [ForeignKey("TimeEntry")]
        public int? TimeEntryId { get; set; }
        [ForeignKey("CurrentTask")]
        public int? CurrentTaskId { get; set; }
        public string AuthCode { get; set; }
        [DefaultValue(false)]
        public bool EnableExperimentalFeatures { get; set; }
        public string UnconfirmedEmail { get; set; }
        public DateTime ConfirmedAt { get; set; }
        public string ConfirmedToken { get; set; }
        public DateTime ConfirmedSentAt { get; set; }
        [DefaultValue(false)]
        public bool Unsubscribed { get; set; }
        [DefaultValue(false)]
        public bool CompletedTour { get; set; }
        public string AvatarColor { get; set; }
        public string InitialsColor { get; set; }
        public string Initials { get; set; }
        [DefaultValue(28800)]
        public int WorkTime1 { get; set; }
        [DefaultValue(28800)]
        public int WorkTime2 { get; set; }
        [DefaultValue(28800)]
        public int WorkTime3 { get; set; }
        [DefaultValue(28800)]
        public int WorkTime4 { get; set; }
        [DefaultValue(28800)]
        public int WorkTime5 { get; set; }
        [DefaultValue(0)]
        public int WorkTime6 { get; set; }
        [DefaultValue(0)]
        public int WorkTime7 { get; set; }
    }
}

/*
# == Schema Information
#
# Table name: users
#
#  id                           :integer          not null, primary key
#  username                     :string(255)
#  email                        :string(255)
#  password_hash                :string(255)
#  password_salt                :string(255)
#  created_at                   :datetime
#  updated_at                   :datetime
#  first_name                   :string(255)
#  last_name                    :string(255)
#  work_time_1                  :integer          default(28800)
#  work_time_2                  :integer          default(28800)
#  work_time_3                  :integer          default(28800)
#  work_time_4                  :integer          default(28800)
#  work_time_5                  :integer          default(28800)
#  work_time_6                  :integer          default(0)
#  work_time_7                  :integer          default(0)
#  time_zone                    :string(255)
#  last_active                  :datetime
#  main_user_type               :string(255)
#  api_key                      :string(255)
#  locale                       :string(255)
#  profile_picture_file_name    :string(255)
#  profile_picture_file_size    :integer
#  settings                     :text
#  work_timer_id                :integer
#  time_entry_id                :integer
#  current_task_id              :integer
#  auth_code                    :string(255)
#  avatar_color                 :string(255)
#  initials                     :string(255)
#  password_reset_token         :string(255)
#  password_reset_sent_at       :datetime
#  enable_experimental_features :boolean          default(FALSE)
#  unconfirmed_email            :string(255)
#  confirmed_at                 :datetime
#  confirmation_token           :string(255)
#  confirmation_sent_at         :datetime
#  unsubscribed                 :boolean          default(FALSE)
#  completed_tour               :boolean          default(FALSE)
#
 */
