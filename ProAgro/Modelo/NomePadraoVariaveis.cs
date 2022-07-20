using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_no_database.Modelo
{
    [Table("tblNomePadraoVariaveis")]
    public class NOMEPADRAOVARIAVEIS
    {
        public NOMEPADRAOVARIAVEIS()
        {
            EXPERIMENTOs = new List<EXPERIMENTO>();
        }

        [Key]
        public int CODI_PAD { get; set; }

        [Required(ErrorMessage = "Descrição do padrão de variaVeis é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(30)]
        public string NOMPAD_PAD { get; set; }

        [MaxLength(30)]
        public string LAVAR1_PAD { get; set; }

        [MaxLength(30)]
        public string LAVAR2_PAD { get; set; }

        [MaxLength(30)]
        public string LAVAR3_PAD { get; set; }

        [MaxLength(30)]
        public string LAVAR4_PAD { get; set; }

        [MaxLength(30)]
        public string LAVAR5_PAD { get; set; }

        [MaxLength(30)]
        public string LAVAR6_PAD { get; set; }

        [MaxLength(30)]
        public string LAVAR7_PAD { get; set; }

        [MaxLength(30)]
        public string LAVAR8_PAD { get; set; }

        [MaxLength(30)]
        public string LAVAR9_PAD { get; set; }

        [MaxLength(30)]
        public string LAVARA_PAD { get; set; }

        public virtual List<EXPERIMENTO> EXPERIMENTOs { get; set; }
    }
}
