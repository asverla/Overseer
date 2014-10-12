using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OverseerAPI.Models.Team
{
    public class Team
    {
        public Team()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int HourlyRate { get; set; }
        public string EncryptionKey { get; set; }
        public string FortnoxDb { get; set; }
        public string FortnoxApiKey { get; set; }
        public double ExpectedDailyHours { get; set; }
        public string Settings { get; set; }
        public string Subdomain { get; set; }

        [DefaultValue("USD")]
        public string CurrencyCode { get; set; }
    }
}

/*
# == Schema Information
#
# Table name: teams
#
#  id                   :integer          not null, primary key
#  name                 :string(255)
#  created_at           :datetime
#  updated_at           :datetime
#  hourly_rate          :integer
#  encryption_key       :string(255)
#  fortnox_db           :string(255)
#  fortnox_apikey       :string(255)
#  expected_daily_hours :float
#  subdomain            :string(255)
#  settings             :text
#  currency_code        :string(3)        default("USD")
#
 */
