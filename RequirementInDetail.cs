using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.TransactionTables
{
    public class RequirementInDetail
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("BasicDetailId")]
        public int BasicDetailId { get; set; }
        public int Priority { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [ForeignKey("CreatedBy")]
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        [ForeignKey("ModifiedBy")]
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
