using System.Collections.Generic;
using System.Data.Entity;

using Arthes.Data.Context;
using Arthes.Domain.Entities;
using Arthes.Domain.Enums;

namespace Arthes.Data.Initializers
{
    public class RevistaDBInitializer : DropCreateDatabaseAlways<Arthes2023Context>
    {
        protected override void Seed(Arthes2023Context context)
        {
            IList<Revista> ItemRevista = new List<Revista>
            {
                new Revista() { Tema = "Tema 1", NumEdicao = 52, MesEdicao = (Mes)(int)Mes.Fevereiro, AnoEdicao = 2020},
                new Revista() { Tema = "Tema 2", NumEdicao = 53, MesEdicao = (Mes)(int)Mes.Janeiro, AnoEdicao = 2021},
                new Revista() { Tema = "Tema 3", NumEdicao = 54, MesEdicao = (Mes)(int)Mes.Agosto, AnoEdicao = 2022},
                new Revista() { Tema = "Tema 4", NumEdicao = 55, MesEdicao = (Mes)(int)Mes.Maio, AnoEdicao = 2023},
                new Revista() { Tema = "Tema 5", NumEdicao = 56, MesEdicao = (Mes)(int)Mes.Julho, AnoEdicao = 2024}
            };

            _ = context.Revistas.AddRange(ItemRevista);

            base.Seed(context);
        }
    }
}
