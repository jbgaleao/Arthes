using Arthes.Domain.Entities;

using FluentValidation;

namespace Arthes.Data.Validators
{
    public class RevistaValidator : AbstractValidator<Revista>
    {
        public RevistaValidator()
        {
            // - TEMA
            _ = RuleFor(model => model.Tema).MaximumLength(80).WithMessage("Tamanho máximo de 80 caracteres");
            _ = RuleFor(model => model.Tema).NotEmpty().WithMessage("Campo Obrigatório");
            _ = RuleFor(model => model.Tema).NotNull().WithMessage("Campo Obrigatório");

            // - NUMERO DA EDICAO
            _ = RuleFor(model => model.NumEdicao).ExclusiveBetween(1, 999).WithMessage("Número da Edição Inválido");
            _ = RuleFor(model => model.NumEdicao).NotEmpty().WithMessage("Campo Obrigatório");
            _ = RuleFor(model => model.NumEdicao).NotNull().WithMessage("Campo Obrigatório");

            // - MES DA EDICAO
            _ = RuleFor(model => model.MesEdicao).IsInEnum().WithMessage("Mês da Edição Inválido");
            //_ = RuleFor(model => model.MesEdicao).Must(ValidaEnumMes).WithMessage("Selecione o Mês da Edição");
            _ = RuleFor(model => model.MesEdicao).NotEmpty().WithMessage("Campo Obrigatório");
            _ = RuleFor(model => model.MesEdicao).NotNull().WithMessage("Campo Obrigatório");

            // - ANO DA EDICAO
            _ = RuleFor(model => model.AnoEdicao).ExclusiveBetween(2018, 2030).WithMessage("Ano da Edição Inválido");
            _ = RuleFor(model => model.AnoEdicao).NotEmpty().WithMessage("Campo Obrigatório");
            _ = RuleFor(model => model.AnoEdicao).NotNull().WithMessage("Campo Obrigatório");
        }

        //    private bool ValidaEnumMes(Mes mes)
        //    {
        //        //return MesEscolhido.ToString().Equals("0") ? false : true;
        //        int indice;
        //        indice(Mes)
        //    }
    }
}