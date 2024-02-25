using IMS_CIS_Controller.Models.MasterTables;
using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.TransactionTables
{
    public class Candidate
    {
        public long Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [MaxLength(50)]

        public string Email { get; set; } = null!;
        [MaxLength(20)]

        public string PhoneNumber { get; set; } = null!;

        public int YearOfExperience { get; set; }
        [MaxLength(100)]

        public string? PrimarySkillSet { get; set; }
        [MaxLength(100)]

        public string? CurrentLocation { get; set; }
        [MaxLength(100)]

        public string? CurrentCompany { get; set; }

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
