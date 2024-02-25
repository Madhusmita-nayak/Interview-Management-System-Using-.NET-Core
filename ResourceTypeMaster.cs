using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.MasterTables
{
    public class ResourceTypeMaster
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }

        [ForeignKey("CreatedById")]
        public int? CreatedById { get; set; }
        public DateTime? CreatedOn { get; set; }

        [ForeignKey("ModifiedById")]
        public int? ModifiedById { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
