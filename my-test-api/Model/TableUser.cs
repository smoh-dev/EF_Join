using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace my_test_api.Model
{
    [Table("tbl_user")]
    public class TableUser
    {
        [Key]
        [Column("key")]
        public int Key { get; set; }
        [Column("name")]
        public string Name { get; set; }
    }
}
