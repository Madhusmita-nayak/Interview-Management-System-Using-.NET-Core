using System.ComponentModel.DataAnnotations;
using IMS_CIS_Controller.Models.MasterTables;

namespace IMS_CIS_Controller.Models.TransactionTables
{
    public class Recruitment
    {
        public int Id { get; set; }
        public long CandidateID { get; set; }
        public int RecruiterID { get; set; }
        public int RelevantExperience { get; set; }
        public DateTime Date { get; set; }
        public decimal CTC { get; set; }
        public decimal ExpectedCTC { get; set; }
        public int NoticePeriod { get; set; }
        public int StatusId { get; set; }
        [MaxLength(1000)]

        public string? Remarks { get; set; }
        public int SourceID { get; set; }
        [MaxLength(50)]

        public string? NameOfTheSource { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        //Navigational Properties for AppUser
        public UserMaster CreatedByAppUser { get; set; }
        public UserMaster ModifiedByAppUser { get; set; }

        //Navigational Properties for Candidate
        public Candidate candidate { get; set; }

        //Navigational Properties for Recruiter
        public Recruiter recruiter { get; set; }

        //Navigational Properties for source
        public Source source { get; set; }

        //Navigational Properties for Status
        public Status Status { get; set; }

    }
}
