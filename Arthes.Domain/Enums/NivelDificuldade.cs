using System.ComponentModel.DataAnnotations;

namespace Arthes.Domain.Enums
{
    public enum NivelDificuldade : int
    {
        [Display(Name = "Muito Difícil")] MuitoDificil = 1,
        [Display(Name = "Difícil")] Dificil = 2,
        [Display(Name = "Mediano")] Mediano = 3,
        [Display(Name = "Fácil")] Facil = 4,
        [Display(Name = "Muito Fácil")] MuitoFacil = 5
    }
}

