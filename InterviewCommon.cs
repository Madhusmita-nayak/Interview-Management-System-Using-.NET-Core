using IMS_CIS_Controller.Models.MasterTables;
using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.TransactionTables
{
    public class InterviewCommon
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Recruiter { get; set; }
        public string JobOrderNo { get; set; }
        [MaxLength(50)]
        public string? Source { get; set; }
        [MaxLength(50)]
        public string CandidateName { get; set; }
        public string Email { get; set; }
        public long ContactNo { get; set; }
        public int YearOfExperience { get; set; }
        public int RelevantExp { get; set; }
        public float CTCLPA { get; set; }
        public float ExpCTCLPA { get; set; }
        public string NoticePeriod { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public List<HRClientRound> HRClientRounds { get; set; }
        public List<TechnicalRound> TechnicalRounds { get; set; }
        public List<ManagementRound> ManagementRounds { get; set; }
        public UserMaster CreatedByAppUser { get; set; }
        public UserMaster ModifiedByAppUser { get; set; }
    }
}
