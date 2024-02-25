using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.TransactionTables
{
    public class Additionalnformation
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("BasicDetailId")]
        public int BasicDetailId { get; set; }

        [MaxLength(100)]
        public string? Name_Of_The_Client { get; set; }

        [MaxLength(100)]
        public string? Client_Domain { get; set; }

        [MaxLength(50)]
        public string? Type_Of_Client { get; set; }

        [MaxLength(100)]
        public string? Client_Geography { get; set; }

        [MaxLength(100)]
        public string? Visibility_of_Project { get; set; }
        public DateTime? Project_Start_Date { get; set; }

        [MaxLength(100)]
        public string? Tentative_Project_Duration { get; set; }

        public bool? Additional_Resources_Required_In_Future { get; set; }

        [MaxLength(100)]
        public string? Project_Directly_With_Client_or_Through_Partner { get; set; }
        public decimal? Project_Revenue { get; set; }

        [MaxLength(100)]
        public string? Type_Of_Project { get; set; }

        [MaxLength(100)]
        public string? Project_Execution_Model { get; set; }

        [ForeignKey("CreatedBy")]
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        [ForeignKey("ModifiedBy")]
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
