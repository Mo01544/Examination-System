namespace Design.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            Choices = new HashSet<Choice>();
            ExamQuestions = new HashSet<ExamQuestion>();
            ExamQuestions1 = new HashSet<ExamQuestion>();
            StudentExamQuestions = new HashSet<StudentExamQuestion>();
        }

        [Key]
        public int QId { get; set; }

        public string QDescription { get; set; }

        [StringLength(10)]
        public string QType { get; set; }

        [StringLength(1)]
        public string Model_Answer { get; set; }

        public int? Cid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Choice> Choices { get; set; }

        public virtual Course Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamQuestion> ExamQuestions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamQuestion> ExamQuestions1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentExamQuestion> StudentExamQuestions { get; set; }
    }
}
