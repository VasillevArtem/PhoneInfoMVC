using System.ComponentModel.DataAnnotations;
namespace PhoneInfoMVC.Models.MyHashTable
{
    public partial class HashTable
    {
        public class TInfo
        {
            public int Id { get; set; }
            public string phone { get; set; }
            public string fio { get; set; }
        }
    }
}
