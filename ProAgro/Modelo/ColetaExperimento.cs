using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_no_database.Modelo
{
    [Table("tblColetaExperimento")]
    public class COLETAEXPERIMENTO
    {
        [Key]
        public int CODI_COE { get; set; }

        public int CODI_EXP { get; set; }

        [Required(ErrorMessage = "O tratamento é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(3)]
        public string TRATAM_COE { get; set; }

        [Required(ErrorMessage = "A repetição é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(3)]
        public string REPETI_COE { get; set; }

        [Required]
        [Display(Name = "Data do coleta")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public System.DateTime DATCOL_COE { get; set; }

        [MaxLength(3)]
        [StringLength(3, MinimumLength = 3)]
        public string ESTADI_COE { get; set; }

        public Nullable<int> INDIUV_COE { get; set; }

        [Range(0, 99999.9)]
        public Nullable<decimal> PRESSA_COE { get; set; }

        public Nullable<int> PONORV_COE { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> TEMMAX_COE { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> TEMMIN_COE { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> PLUVIO_COE { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> VELVEN_COE { get; set; }

        public Nullable<int> UMIDAD_COE { get; set; }

        [Range(0, 99999.9)]
        public Nullable<decimal> TENSIO_COE { get; set; }

        [Range(0, 99999.9)]
        public Nullable<decimal> IRRQNT_COE { get; set; }

        [Range(0, 9999999.999)]
        public Nullable<decimal> VALRE1_EXP { get; set; }

        [Range(0, 9999999.999)]
        public Nullable<decimal> VALRE2_EXP { get; set; }

        [Range(0, 9999999.999)]
        public Nullable<decimal> VALRE3_EXP { get; set; }

        [Range(0, 9999999.999)]
        public Nullable<decimal> VALRE4_EXP { get; set; }

        [Range(0, 9999999.999)]
        public Nullable<decimal> VALRE5_EXP { get; set; }

        [Range(0, 9999999.999)]
        public Nullable<decimal> VALRE6_EXP { get; set; }

        [Range(0, 9999999.999)]
        public Nullable<decimal> VALRE7_EXP { get; set; }

        [Range(0, 9999999.999)]
        public Nullable<decimal> VALRE8_EXP { get; set; }

        [Range(0, 9999999.999)]
        public Nullable<decimal> VALRE9_EXP { get; set; }

        [Range(0, 9999999.999)]
        public Nullable<decimal> VALREA_EXP { get; set; }

        [MaxLength(2000)]
        public string OBSGER_COE { get; set; }

        [ForeignKey("CODI_EXP")]
        public virtual EXPERIMENTO EXPERIMENTO { get; set; }
    }
}
