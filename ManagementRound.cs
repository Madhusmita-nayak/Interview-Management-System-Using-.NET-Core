using IMS_CIS_Controller.Models.MasterTables;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.TransactionTables
{
    public class ManagementRound
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Interviewer { get; set; }
        public int ModeId { get; set; }
        public int ResultId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        //Navigation Property
        public ModeMaster ModeMaster { get; set; }
        public ResultMaster ResultMaster { get; set; }

        [ForeignKey("Id")]
        public int InterviewCommonId { get; set; }

        public InterviewCommon InterviewCommon { get; set; }

        public List<InterviewCommon> interviewCommons { get; set; }
        public UserMaster CreatedByAppUser { get; set; }
        public UserMaster ModifiedByAppUser { get; set; }
    }
}
