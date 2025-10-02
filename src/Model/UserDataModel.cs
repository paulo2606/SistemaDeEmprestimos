using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibCenter.src.Models
{
    [Table("user_data")]
    public class UserDataModel
    {
        [Key]
        [Column("id_user")]
        public int IdUser { get; set; }

        [Column("email_user")]
        public string EmailUser { get; set; }

        [Column("name_user")]
        public string NameUser { get; set; }

        [Column("phone_user")]
        public string PhoneUser { get; set; }

        [Column("registration")]
        public string Registration { get; set; }

        [Column("pwd_hash_user")]
        public string PwdHashUser { get; set; }

        [Column("dt_criation_user")]
        public DateTime DtCriationUser { get; set; }
    }
}