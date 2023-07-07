using Arthes.Domain.DTO;

using FluentValidation;

namespace Arthes.Web.Validators
{
    public class RevistaValidator : AbstractValidator<RevistaDTO>
    {
        public RevistaValidator()
        {
            // - TEMA
            _ = RuleFor(model => model.Tema).NotEmpty().WithMessage("Campo Obrigatório");
            _ = RuleFor(model => model.Tema).NotNull().WithMessage("Campo Obrigatório");
            _ = RuleFor(model => model.Tema).MaximumLength(80).WithMessage("Tamanho máximo de 80 caracteres");

            // - NUMERO DA EDICAO
            _ = RuleFor(model => model.NumEdicao).ExclusiveBetween(1, 999).WithMessage("Número da Edição Inválido");
            _ = RuleFor(model => model.NumEdicao).NotEmpty().WithMessage("Campo Obrigatório");
            _ = RuleFor(model => model.NumEdicao).NotNull().WithMessage("Campo Obrigatório");

            // - MES DA EDICAO
            _ = RuleFor(model => model.MesEdicao).IsInEnum().WithMessage("Mês da Edição Inválido");
            _ = RuleFor(model => model.MesEdicao).NotEmpty().WithMessage("Campo Obrigatório");

            _ = RuleFor(model => model.MesEdicao).NotNull().WithMessage("Campo Obrigatório");

            // - ANO DA EDICAO
            _ = RuleFor(model => model.AnoEdicao).InclusiveBetween(2018, 2030).WithMessage("Ano da Edição Inválido");
            _ = RuleFor(model => model.AnoEdicao).NotEmpty().WithMessage("Campo Obrigatório");
            _ = RuleFor(model => model.AnoEdicao).NotNull().WithMessage("Campo Obrigatório");
        }
    }
}