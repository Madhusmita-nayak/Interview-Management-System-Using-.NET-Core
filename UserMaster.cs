using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using IMS_CIS_Controller.Models.TransactionTables;

namespace IMS_CIS_Controller.Models.MasterTables
{
    public class UserMaster
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }

        public long PhoneNumber { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public RoleMaster Role { get; set; }

        // Foreign key to the same User table for CreatedBy and ModifiedBy
        public int? CreatedById { get; set; }
        [ForeignKey("CreatedById")]
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedById { get; set; }
        [ForeignKey("ModifiedById")]
        public DateTime? ModifiedOn { get; set; }
        public UserMaster CreatedBy { get; set; }
        public UserMaster ModifiedBy { get; set; }

        //Foreign Key to other master and transaction table
        public List<Candidate> CandidateCreated { get; set; }
        public List<Candidate> CandidateModified { get; set; }
        public List<Recruiter> RecruiterCreated { get; set; }
        public List<Recruiter> RecruiterModified { get; set; }
        public List<Source> SourceCreated { get; set; }
        public List<Source> SourceModified { get; set; }
        public List<Status> StatusCreated { get; set; }
        public List<Status> StatusModified { get; set; }
        public List<IEDStatusMaster> IEDStatusCreated { get; set; }
        public List<IEDStatusMaster> IEDStatusModified { get; set; }
        public List<LevelMaster> LevelMasterCreated { get; set; }
        public List<LevelMaster> LevelModified { get; set; }
        public List<ModeMaster> ModeMasterCreated { get; set; }
        public List<ModeMaster> ModeMasterModified { get; set; }
        public List<ResultMaster> ResultMasterCreated { get; set; }
        public List<ResultMaster> ResultMasterModified { get; set; }
        public List<HRClientRound> HRClientRoundCreated { get; set; }
        public List<HRClientRound> HRClientRoundModified { get; set; }
        public List<InterviewCommon> InterviewCommonCreated { get; set; }
        public List<InterviewCommon> InterviewCommonModified { get; set; }
        public List<ManagementRound> ManagementRoundCreated { get; set; }
        public List<ManagementRound> ManagementRoundModified { get; set; }
        public List<TechnicalRound> TechnicalRoundCreated { get; set; }
        public List<TechnicalRound> TechnicalRoundModified { get; set; }

    }
}
