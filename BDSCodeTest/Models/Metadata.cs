using System;
using System.ComponentModel.DataAnnotations;

namespace BDSCodeTest.Models
{
    public class TaskMetadata
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "Task Name")]
        public string TaskNM;

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Task Date")]
        public DateTime TaskDT;
    }
}