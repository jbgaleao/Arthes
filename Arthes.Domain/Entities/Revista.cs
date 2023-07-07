using System;

using Arthes.Domain.Enums;

namespace Arthes.Domain.Entities
{
    public class Revista
    {
        public int Id { get; set; }
        public string Tema { get; set; }
        public int NumEdicao { get; set; }
        public Mes MesEdicao { get; set; }
        public int AnoEdicao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
