using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.TransactionTables
{
    public class JobSpecification
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("BasicDetailId")]
        public int BasicDetailId { get; set; }
        public int YOE { get; set; }

        [MaxLength(100)]
        public string KeySkill { get; set; }

        [MaxLength(100)]
        public string Qualification { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [ForeignKey("CreatedBy")]
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [ForeignKey("ModifiedBy")]
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
