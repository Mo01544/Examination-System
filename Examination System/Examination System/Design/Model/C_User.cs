namespace Design.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_User")]
    public partial class C_User
    {
        [Key]
        public int UID { get; set; }

        [Required]
        [StringLength(50)]
        public string userName { get; set; }

        [Required]
        [StringLength(10)]
        public string Password { get; set; }

        [Required]
        [StringLength(10)]
        public string FName { get; set; }

        [Required]
        [StringLength(10)]
        public string LName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birth_Date { get; set; }

        [Required]
        [StringLength(1)]
        public string UserType { get; set; }

        public virtual Instructor Instructor { get; set; }

        public virtual Student Student { get; set; }
    }
}
