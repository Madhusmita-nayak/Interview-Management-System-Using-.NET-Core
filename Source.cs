using System.ComponentModel.DataAnnotations;
using IMS_CIS_Controller.Models.TransactionTables;

namespace IMS_CIS_Controller.Models.MasterTables
{
    public class Source
    {
        public int Id { get; set; }
        [MaxLength(50)]

        public string SourceName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        //Navigational Properties for AppUser
        public UserMaster CreatedByAppUser { get; set; }
        public UserMaster ModifiedByAppUser { get; set; }

        //Navigational Properties for Recruitment
        public List<Recruitment> Recruitment { get; set; }
    }
}
