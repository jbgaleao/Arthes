using System.ComponentModel.DataAnnotations;

namespace Arthes.Domain.Enums
{
    public enum Mes : int
    {
        Janeiro = 1,
        Fevereiro = 2,
        [Display(Name = "Março")] Marco = 3,
        Abril = 4,
        Maio = 5,
        Junho = 6,
        Julho = 7,
        Agosto = 8,
        Setembro = 9,
        Outubro = 10,
        Novembro = 11,
        Dezemebro = 12,
    }
}

