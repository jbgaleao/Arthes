using System;

using Arthes.Domain.Enums;

namespace Arthes.Web.ViewModels
{
    public class RevistaViewModel
    {
        public int Id { get; set; }
        public string Tema { get; set; }
        public int NumEdicao { get; set; }
        public Mes MesEdicao { get; set; }
        public int AnoEdicao { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}