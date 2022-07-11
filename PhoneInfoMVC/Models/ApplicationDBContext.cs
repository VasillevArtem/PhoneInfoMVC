using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PhoneInfoMVC.Models.MyHashTable;


namespace PhoneInfoMVC.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option) : base(option) { }
        
        public DbSet<HashTable.TInfo> TInfos { get; set; }
        
    }
}
