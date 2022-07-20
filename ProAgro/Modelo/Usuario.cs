using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_no_database.Modelo
{
    [Table("tblUsuario")]
    public class USUARIO
    {
        [Key]
        public int CODI_USU { get; set; }

        [Required(ErrorMessage = "O login é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(10)]
        public string LOGIN_USU { get; set; }

        [Required(ErrorMessage = "A senha é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(10)]
        public string SENHA_USU { get; set; }

        [MaxLength(100)]
        public string NOME_USU { get; set; }

        [MaxLength(100)]
        public string ENDERECO_USU { get; set; }

        [MaxLength(12)]
        public string TELEFONE_USU { get; set; }

        [MaxLength(50)]
        public string BAIRRO_USU { get; set; }

        [MaxLength(20)]
        public string COMPLEMENTO_USU { get; set; }

        [MaxLength(20)]
        public string CEP_USU { get; set; }

        [MaxLength(2)]
        public string ESTADO_USU { get; set; }
    }
}
