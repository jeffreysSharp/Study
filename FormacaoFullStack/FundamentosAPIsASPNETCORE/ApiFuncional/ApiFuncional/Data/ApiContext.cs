using Microsoft.EntityFrameworkCore;

namespace ApiFuncional.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

    }
}
