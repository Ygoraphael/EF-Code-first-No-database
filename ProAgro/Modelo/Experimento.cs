using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_no_database.Modelo
{
    [Table("tblExperimento")]
    public class EXPERIMENTO
    {
        public EXPERIMENTO()
        {
            COLETAEXPERIMENTOs = new List<COLETAEXPERIMENTO>();
            COMPETICAOs        = new List<COMPETICAO>();
            GERMINACAOs        = new List<GERMINACAO>();
        }
        [Key]
        public int CODI_EXP { get; set; }

        [Required(ErrorMessage = "Descrição do experimento é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(30)]
        public string NOMEXP_EXP { get; set; }

        [Required(ErrorMessage = "O nome da propriedade é obrigatório!", AllowEmptyStrings = false)]
        public int CODI_PRO { get; set; }

        public string CODI_COM { get; set; }        

        [Required(ErrorMessage = "A quantidade de tratamento é obrigatório!", AllowEmptyStrings = false)]
        public int NUMTRA_EXP { get; set; }

        [Required(ErrorMessage = "A quantidade de repetição é obrigatório!", AllowEmptyStrings = false)]
        public int NUMREP_EXP { get; set; }

        [Required(ErrorMessage = "A data da semeadura é obrigatório!", AllowEmptyStrings = false)]
        public System.DateTime DATINI_EXP { get; set; }

        [Range(0, 99999.99)]
        public Nullable<decimal> DIAVAS_EXP { get; set; }

        [MaxLength(2000)]
        public string DESTRA_EXP { get; set; }

        [Required(ErrorMessage = "O codigo de padrão de variaveis é obrigatório!", AllowEmptyStrings = false)]
        public int CODI_PAD { get; set; }

        [MaxLength(1)]
        public string EXPFIN_EXP { get; set; }

        [MaxLength(1)]
        public string TIPTRA_EXP { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> PEIEA1_EXP { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> PEIEA2_EXP { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> PEIEA3_EXP { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> PEQET1_EXP { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> PEQET2_EXP { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> PEQET3_EXP { get; set; }


        public virtual List<COLETAEXPERIMENTO> COLETAEXPERIMENTOs { get; set; }
        public virtual List<COMPETICAO> COMPETICAOs { get; set; }
        public virtual List<GERMINACAO> GERMINACAOs { get; set; }

        [ForeignKey("CODI_PAD")]
        public virtual NOMEPADRAOVARIAVEIS NOMEPADRAOVARIAVEIS { get; set; }

        [ForeignKey("CODI_PRO")]
        public virtual PROPRIEDADE PROPRIEDADE { get; set; }

    }
}
