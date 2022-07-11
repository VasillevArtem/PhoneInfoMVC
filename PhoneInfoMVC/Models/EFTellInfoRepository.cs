using System.Collections.Generic;
using System.Linq;
using PhoneInfoMVC.Models.MyHashTable;

namespace PhoneInfoMVC.Models
{
    public class EFTellInfoRepository : ITellInfoRepository
    {
        private ApplicationDBContext context;

        public EFTellInfoRepository(ApplicationDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<HashTable.TInfo> TellInfo => context.TInfos;
    }
    
}
