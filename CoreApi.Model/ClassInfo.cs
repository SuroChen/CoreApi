using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreApi.Model
{
    [Table("Class")]
    public class ClassInfo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required, StringLength(32)]
        public string Name { get; set; }

        [Required, Column("CTime")]
        public DateTime CreateTime { get; set; }

        [Column(TypeName = "ntext"), MaxLength(20), MinLength(10)]
        public string Remark { get; set; }

        [NotMapped]
        public string NotNeed { get; set; }
    }
}
