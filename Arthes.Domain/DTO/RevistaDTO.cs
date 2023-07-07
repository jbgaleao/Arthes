using System;
using System.ComponentModel.DataAnnotations;

using Arthes.Domain.Enums;

namespace Arthes.Domain.DTO
{
    public class RevistaDTO
    {
        public int Id { get; set; }

        [Display(Name = "Tema")]
        [Required]
        public string Tema { get; set; }

        [Display(Name = "Número Edição")]
        [Required]
        public int NumEdicao { get; set; }

        [Display(Name = "Mês Edição")]
        [Required]
        public Mes MesEdicao { get; set; }

        [Display(Name = "Ano Edição")]
        [Required]
        [Range(2018, 2030)]
        public int AnoEdicao { get; set; }

        [Display(Name = "Data Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}