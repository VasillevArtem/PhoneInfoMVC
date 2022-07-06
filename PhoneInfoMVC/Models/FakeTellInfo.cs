using System.Collections.Generic;
using System.Linq;
using PhoneInfoMVC.Models.MyHashTable;

namespace PhoneInfoMVC.Models
{
    public class FakeTellInfo : ITellInfoRepository
    {
        public IQueryable<HashTable.TInfo> TellInfo => new List<HashTable.TInfo>
        {
            new HashTable.TInfo { fio="Vasilev Artem Dmitrievich", phone = "987654321"},
            new HashTable.TInfo { fio="Vasilev Artem Dmitrievich", phone = "123456789"},
            new HashTable.TInfo { fio="Vasilev Artem Dmitrievich", phone = "123443657"}
        }.AsQueryable<HashTable.TInfo>();
    }
}
