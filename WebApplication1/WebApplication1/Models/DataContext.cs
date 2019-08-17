using System.Data.Entity;

namespace WebApplication1.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebApplication1.Models.Student> Students { get; set; }
    }


}