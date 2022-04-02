namespace Design.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Topic")]
    public partial class Topic
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TopicName { get; set; }

        public virtual Course Course { get; set; }
    }
}
