namespace AppCodeFirst.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Task")]
    public partial class Task
    {
        public int TaskId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsComplete { get; set; }

        public int? AssignedTo_UserId { get; set; }

        public virtual User User { get; set; }
    }
}
