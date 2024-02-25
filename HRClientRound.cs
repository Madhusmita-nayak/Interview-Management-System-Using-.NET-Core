using IMS_CIS_Controller.Models.MasterTables;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.TransactionTables
{
    public class HRClientRound
    {
        [Key]
        public int Id { get; set; }
        public string? RatedAt { get; set; }
        public string? SkypeId { get; set; }
        public string? Interviewer { get; set; }
        public int ModeId { get; set; }
        public int ResultId { get; set; }
        public int IEDStatusId { get; set; }
        public DateTime JoiningOn { get; set; }
        [MaxLength(1000)]
        public string? ReasonForEsspl { get; set; }
        [MaxLength(1000)]
        public string? ReasonForDecline { get; set; }
        [MaxLength(1000)]
        public string? Remarks { get; set; }
        public float MarksScoredInOnlineTest { get; set; }
        public string RoundName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        //Navigation Property
        [ForeignKey("Id")]
        public int InterviewCommonId { get; set; }
        public InterviewCommon InterviewCommon { get; set; }
        public ModeMaster ModeMaster { get; set; }
        public ResultMaster ResultMaster { get; set; }
        public IEDStatusMaster IEDStatusMaster { get; set; }
        public UserMaster CreatedByAppUser { get; set; }
        public UserMaster ModifiedByAppUser { get; set; }
    }
}
