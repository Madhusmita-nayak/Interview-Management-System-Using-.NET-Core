using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.TransactionTables
{
    public class Approval
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("BasicDetailId")]
        public int BasicDetailId { get; set; }

        [MaxLength(100)]
        public string InitiatedBy { get; set; }

        [MaxLength(100)]
        public string ReviewedBy { get; set; }

        public bool ApprovedByHr { get; set; }

        public bool ApprovedByPresident { get; set; }

        [ForeignKey("CreatedBy")]
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        [ForeignKey("ModifiedBy")]
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
