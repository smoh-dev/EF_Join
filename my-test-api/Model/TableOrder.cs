using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace my_test_api.Model
{
    [Table("tbl_order")]
    public class TableOrder
    {
        [Key]
        [Column("key")]
        public int Key { get; set; }
        [Column("user_key")]
        public int UserKey { get; set; }
        [Column("code")]
        public string Code { get; set; }
    }
}
