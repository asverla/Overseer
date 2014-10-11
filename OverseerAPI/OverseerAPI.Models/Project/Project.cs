using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OverseerAPI.Models.Project
{
    public class Project
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Budget { get; set; }
        public string Description { get; set; }
        [DefaultValue(true)]
        public bool PayPerHour { get; set; }
        public int EstimatedHours { get; set; }
        public int HourlyRate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [DefaultValue(0)]
        public int Status { get; set; }
        [DefaultValue(0)]
        public int TotalTime { get; set; }
        public string ProjectType { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        [ForeignKey("Team")]
        public int? TeamId { get; set; }
        public DateTime Deadline { get; set; }
        [DefaultValue(true)]
        public bool Chargeable { get; set; }
        public DateTime EarliestStart { get; set; }
        public string Charging { get; set; }
        [DefaultValue(0.0)]
        public double AlreadyInvoicedAmount { get; set; }
        [DefaultValue(0)]
        public int AlreadyInvoicedSeconds { get; set; }
        [ForeignKey("ProjectLeader")]
        public int? ProjectLeaderId { get; set; }
        [ForeignKey("Estimate")]
        public int? EstimateId { get; set; }
        [DefaultValue(25.0)]
        public double VatPercentage { get; set; }
        [ForeignKey("LastUpdatedBy")]
        public int? LastUpdatedById { get; set; }
        [DefaultValue(0)]
        public int TotalApprovedTime { get; set; }
    }

}

/*
# == Schema Information
#
# Table name: projects
#
#  id                       :integer          not null, primary key
#  title                    :string(255)
#  budget                   :integer
#  description              :text
#  pay_per_hour             :boolean          default(TRUE)
#  estimated_hours          :integer
#  hourly_rate              :integer
#  created_at               :datetime
#  updated_at               :datetime
#  status                   :integer          default(0)
#  total_time               :integer          default(0)
#  project_type             :string(255)
#  customer_id              :integer
#  team_id                  :integer
#  deadline                 :date
#  chargeable               :boolean          default(TRUE)
#  earliest_start           :date
#  charging                 :string(255)
#  already_invoiced_amount  :float            default(0.0)
#  already_invoiced_seconds :integer          default(0)
#  project_leader_id        :integer
#  estimate_id              :integer
#  vat_percentage           :float            default(25.0)
#  last_updated_by_id       :integer
#  total_approved_time      :integer          default(0)
#
 */