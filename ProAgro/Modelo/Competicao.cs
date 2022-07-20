using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_no_database.Modelo
{
    [Table("tblCompeticao")]
    public class COMPETICAO
    {
        [Key]
        public int CODI_COM { get; set; }

        [Required(ErrorMessage = "O código da cultura é obrigatório!", AllowEmptyStrings = false)]
        public int CODI_CUL { get; set; }

        [Required(ErrorMessage = "O nome da competição é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(60)]
        [StringLength(60, MinimumLength = 1)]
        public string NOMECO_COM { get; set; }

        [Required(ErrorMessage = "O codigo do experimento é obrigatório!", AllowEmptyStrings = false)]
        public int CODI_EXP { get; set; }

        [ForeignKey("CODI_CUL")]
        public virtual CULTURA CULTURA { get; set; }

        [ForeignKey("CODI_EXP")]
        public virtual EXPERIMENTO EXPERIMENTO { get; set; }
    }
}
