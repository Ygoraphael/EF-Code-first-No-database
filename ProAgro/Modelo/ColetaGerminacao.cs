using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_no_database.Modelo
{
    [Table("tblColetaGerminacao")]
    public class COLETAGERMINACAO
    {
        [Key]
        public int CODI_COG { get; set; }

        [Required]
        public int CODI_GER { get; set; }

        [Required(ErrorMessage = "O tratamento é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(3)]
        public string TRATAM_COG { get; set; }

        [Required(ErrorMessage = "A repetição é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(3)]
        public string REPETI_COG { get; set; }

        [Required(ErrorMessage = "O PLANO DE ACOMPANHAMENTO DIAS é obrigatório!", AllowEmptyStrings = false)]
        public int PLAACO_COG { get; set; }

        [Required(ErrorMessage = "A DATA DA COLETA DE DADOS é obrigatoria!", AllowEmptyStrings = false)]
        public DateTime DATCOG_COG { get; set; }

        [Required(ErrorMessage = "O número de SEMENTES GERMINADAS é obrigatoria!", AllowEmptyStrings = false)]
        public int SEMGER_COG { get; set; }

        [Required(ErrorMessage = "O número de SEMENTES NAO GERMINADAS é obrigatoria!", AllowEmptyStrings = false)]
        public int NAOGER_COG { get; set; }

        [Range(0, 999.9)]
        public Nullable<decimal> PORGER_COG { get; set; }

        [ForeignKey("CODI_GER")]
        public virtual GERMINACAO GERMINACAO { get; set; }
    }
}
