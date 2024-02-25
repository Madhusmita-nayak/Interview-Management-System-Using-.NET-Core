using IMS_CIS_Controller.Models.MasterTables;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.TransactionTables
{
    public class TechnicalRound
    {
        [Key]
        public int Id { get; set; }
        public int LevelId { get; set; }
        [MaxLength(50)]
        public string Interviewer { get; set; }
        public int ModeId { get; set; }
        public int ResultId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        //Navigation Properties
        [ForeignKey("Id")]
        public int InterviewCommonId { get; set; }
        public InterviewCommon InterviewCommon { get; set; }
        public LevelMaster LevelMaster { get; set; }
        public ModeMaster ModeMaster { get; set; }
        public ResultMaster ResultMaster { get; set; }
        public int IEDStatusId { get; set; }
        public IEDStatusMaster IEDStatusMaster { get; set; }
        public UserMaster CreatedByAppUser { get; set; }
        public UserMaster ModifiedByAppUser { get; set; }
    }
}
