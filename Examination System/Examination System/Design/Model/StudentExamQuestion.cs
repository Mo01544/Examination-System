namespace Design.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentExamQuestion")]
    public partial class StudentExamQuestion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExamId { get; set; }

        [StringLength(1)]
        public string StudentAnswer { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Question Question { get; set; }

        public virtual Student Student { get; set; }
    }
}
