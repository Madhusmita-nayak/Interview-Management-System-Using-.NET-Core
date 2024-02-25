﻿using System.ComponentModel.DataAnnotations;

namespace IMS_CIS_Controller.Models.MasterTables
{
    public class ModeMaster
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public UserMaster CreatedByAppUser { get; set; }
        public UserMaster ModifiedByAppUser { get; set; }
    }
}
