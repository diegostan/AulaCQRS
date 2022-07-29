using System.Data;
using Microsoft.Data.SqlClient;

namespace FrotaApp.Infrastructure.Shared.Factory
{
    public class SqlFactory
    {
        public IDbConnection SqlConnection()
        {
            return new SqlConnection("Server=localhost; Database=BANCO_FROTA; User=sa; Password=@Passw0rd; Trusted_Connection=False; TrustServerCertificate=True;");
        }
    }
}