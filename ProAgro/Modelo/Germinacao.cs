using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_no_database.Modelo
{
    [Table("tblGerminacao")]
    public partial class GERMINACAO
    {
        public GERMINACAO()
        {
            COLETAGERMINACAOs = new List<COLETAGERMINACAO>();
        }
        [Key]
        public int CODI_GER { get; set; }

        [Required(ErrorMessage = "Descrição da germinação é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(30)]
        public string NOMGER_GER { get; set; }

        [Required(ErrorMessage = "O código do experimento é obrigatório!", AllowEmptyStrings = false)]
        public int CODI_EXP { get; set; }

        [Required(ErrorMessage = "O código do usuário é obrigatório!", AllowEmptyStrings = false)]
        public int CODI_USU { get; set; }

//        [Required(ErrorMessage = "O código do responsável é obrigatório!", AllowEmptyStrings = false)]
//        public string CODI_RES { get; set; }

        [Required(ErrorMessage = "O código da cultura é obrigatório!", AllowEmptyStrings = false)]
        public int CODI_CUL { get; set; }

        [MaxLength(20)]
        public string ESPECI_GER { get; set; }

        [Required(ErrorMessage = "A data da germinação é obrigatório!", AllowEmptyStrings = false)]
        public System.DateTime DATAMO_GER { get; set; }

        [Required(ErrorMessage = "A quantidade de tratamento é obrigatório!", AllowEmptyStrings = false)]
        public int NUMTRA_GER { get; set; }

        [Required(ErrorMessage = "A quantidade de repetição é obrigatório!", AllowEmptyStrings = false)]
        public int NUMREP_GER { get; set; }

        [Required(ErrorMessage = "O pedo do papel é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 9999999.9999)]
        public decimal PEPAGE_GER { get; set; }

        [Required(ErrorMessage = "A temperatura da germinadora é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 999.9)]
        public decimal TEMPET_GER { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> QUAGUA_GER { get; set; }

        [Required(ErrorMessage = "A quantidade da soma total de sementes é obrigatório!", AllowEmptyStrings = false)]
        public int QSETOT_GER { get; set; }

        [Required(ErrorMessage = "A quantidade de semente por repetição é obrigatório!", AllowEmptyStrings = false)]
        public int QSEREP_GER { get; set; }

        public virtual List<COLETAGERMINACAO> COLETAGERMINACAOs { get; set; }

        [ForeignKey("CODI_EXP")]
        public virtual CULTURA CULTURA { get; set; }

        [ForeignKey("CODI_CUL")]
        public virtual EXPERIMENTO EXPERIMENTO { get; set; }
    }
}
