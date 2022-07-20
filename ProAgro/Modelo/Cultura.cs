using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_no_database.Modelo
{
    [Table("tblCultura")]
    public class CULTURA
    {

        public CULTURA()
        {
            this.COMPETICAOs = new List<COMPETICAO>();
            this.GERMINACAOs = new List<GERMINACAO>();
        }

        [Key]
        public int CODI_CUL { get; set; }

        [Required(ErrorMessage = "O nome da cultura é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(60)]
        [StringLength(60, MinimumLength = 1)]
        public string NOMCUL_CUL { get; set; }

        [MaxLength(30)]
        public string CULTIV_CUL { get; set; }

        [MaxLength(60)]
        public string LOTECU_CUL { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> GERMIN_CUL { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> PUREZA_CUL { get; set; }

        public Nullable<System.DateTime> VALIDA_CUL { get; set; }

        [MaxLength(9)]
        public string SAFRAC_CUL { get; set; }

        [Range(0, 999999.999)]
        public Nullable<decimal> M100SE_CUL { get; set; }

        [MaxLength(100)]
        public string TRAQUI_CUL { get; set; }

        [MaxLength(60)]
        public string PROSEM_CUL { get; set; }

        [MaxLength(250)]
        public string OBSERV_CUL { get; set; }
                
        public virtual List<COMPETICAO> COMPETICAOs { get; set; }
        public virtual List<GERMINACAO> GERMINACAOs { get; set; }
    }
}
