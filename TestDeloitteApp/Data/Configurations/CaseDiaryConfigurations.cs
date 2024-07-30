
using TestDeloitteApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace TestDeloitteApp.Data
{
    public class CaseDiaryConfigurations : IEntityTypeConfiguration<CaseDiary>
    {
        public void Configure(EntityTypeBuilder<CaseDiary> builder)
        {
        }
    }
}