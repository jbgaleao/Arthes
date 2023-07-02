using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Arthes.Domain.Entities;

namespace Arthes.Data.Maps
{
    public class RevistaMap : EntityTypeConfiguration<Revista>
    {
        public RevistaMap()
        {
            _ = ToTable("REVISTAS", "DBO");

            _ = HasKey(r => r.Id);
            _ = Property(r => r.Id).HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            _ = Property(r => r.Tema).HasColumnName("TEMA").HasColumnType("varchar").HasMaxLength(80).IsRequired();
            _ = Property(r => r.NumEdicao).HasColumnName("NUMERO_EDICAO").HasColumnType("int").IsRequired();
            _ = Property(r => r.MesEdicao).HasColumnName("MES_EDICAO").HasColumnType("int").IsRequired();
            _ = Property(r => r.AnoEdicao).HasColumnName("ANO_EDICAO").HasColumnType("int").IsRequired();
        }
    }
}
