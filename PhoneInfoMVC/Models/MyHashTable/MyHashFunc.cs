namespace PhoneInfoMVC.Models.MyHashTable
{
    public partial class HashTable
    {
        int hashKey(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                result += Convert.ToInt32(s[i]) * i;
                result %= sizeTable;

                
            }
            return result;
        }
    }
}
