using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.TransactionTables
{
    public class BasicDetail
    {
        [Key]
        public int Id { get; set; }
        public int JobRequestNum { get; set; }
        public DateTime RequestDate { get; set; }
        public int NoOfVacancy { get; set; }

        [ForeignKey("Grade")]
        public int Grade { get; set; } //fk

        public DateTime RequiredBy { get; set; }
        [ForeignKey("RequirementType")]
        public int RequirementType { get; set; }   //fk
        [ForeignKey("ResourceType")]
        public int ResourceType { get; set; } //fk

        [MaxLength(100)]
        public string NameOfTheProject { get; set; }

        [ForeignKey("DmId")]
        public int DmId { get; set; } //fk

        [ForeignKey("CreatedBy")]
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [ForeignKey("ModifiedBy")]
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
