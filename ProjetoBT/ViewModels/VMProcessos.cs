using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBT.ViewModels
{

    public class VMProcessosIndex
    {
        public VMProcessosIndex()
        {
            ListaProcessos = new List<VMProcessosIndexItem>();  
        }
        public List<VMProcessosIndexItem> ListaProcessos { get; set; }
    }

    public class VMProcessosIndexItem
    {
        [Key]
        public int iProcesso { get; set; }

        [Display(Name = "Valor da Causa")]
        public decimal dValorCausa { get; set; }

        [Display(Name = "Nome Do Contratante")]
        public string sNomeContratante { get; set; }

        [Display(Name = "Nome Do Escritório")]
        public string sNomeEscritório { get; set; }

        public bool bAprovarCausa { get; set; }

    }

    public class VMProcessosForms
    {
        [Key]
        public int iProcesso { get; set; }

        [Display(Name = "Valor da Causa")]
        [Required(ErrorMessage = "Preencha o Valor da Causa")]
        public decimal dValorCausa { get; set; }

        [Display(Name = "Nome Do Contratante")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres")]
        public string sNomeContratante { get; set; }

        [Display(Name = "Nome Do Escritório")]
        [MaxLength(100, ErrorMessage = "Maximo de 100 Caracteres")]
        public string sNomeEscritório { get; set; }
    }
}
