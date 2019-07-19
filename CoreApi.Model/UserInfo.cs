using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApi.Model
{
    public class UserInfo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        [NotMapped]
        public string province { get; set; }
    }
}
