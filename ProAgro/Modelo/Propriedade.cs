using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_no_database.Modelo
{
    [Table("tblPropriedade")]
    public class PROPRIEDADE
    {
        public PROPRIEDADE()
        {
            EXPERIMENTOs = new List<EXPERIMENTO>();
        }

        [Key]
        public int CODI_PRO { get; set; }

        [Required(ErrorMessage = "O código do experimento é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(100)]
        [StringLength(100, MinimumLength = 1)]
        public string NOMEPR_PRO { get; set; }

        [MaxLength(50)]
        public string MUNICI_PRO { get; set; }

        [MaxLength(2)]
        public string ESTADO_PRO { get; set; }

        [MaxLength(100)]
        public string ENDERE_PRO { get; set; }

        [MaxLength(40)]
        public string COMPLE_PRO { get; set; }

        [MaxLength(12)]
        public string TELEFO_PRO { get; set; }

        [MaxLength(30)]
        public string EMAILP_PROP { get; set; }

        [MaxLength(40)]
        public string NOMRES_PRO { get; set; }
        
        public virtual List<EXPERIMENTO> EXPERIMENTOs { get; set; }
    }
}
