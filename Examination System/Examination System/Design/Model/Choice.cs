namespace Design.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Choice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QId { get; set; }

        [Key]
        [Column("Choice", Order = 1)]
        [StringLength(1)]
        public string Choice1 { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public virtual Question Question { get; set; }
    }
}
