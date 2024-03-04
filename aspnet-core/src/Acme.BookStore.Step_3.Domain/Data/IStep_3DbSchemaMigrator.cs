using System.Threading.Tasks;

namespace Acme.BookStore.Step_3.Data;

public interface IStep_3DbSchemaMigrator
{
    Task MigrateAsync();
}
