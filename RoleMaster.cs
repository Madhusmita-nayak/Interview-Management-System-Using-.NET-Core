using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.MasterTables
{
    public class RoleMaster
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string RoleName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public List<UserMaster> Users { get; set; } = new List<UserMaster>();
    }
}
