using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.DataAccess
{
    public class AppContext : DbContext
    {
        public AppContext() { }

        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    }
}
