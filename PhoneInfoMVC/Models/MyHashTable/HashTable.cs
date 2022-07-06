namespace PhoneInfoMVC.Models.MyHashTable
{
    public partial class HashTable
    {

        public int sizeTable;           
        static int step = 37;           
        int size;                       
        THashItem[] h;                  

        public HashTable(int sizeTable)    
        {
            this.sizeTable = sizeTable;
            h = new THashItem[sizeTable];
            HashInit();
        }
        public void HashInit()          
        {
            size = 0;
            for (int i = 0; i < sizeTable; i++)
            {
                h[i].empty = true;
                h[i].visit = false;
            }
        }

        

        public int AddHash(string fio, string phone) 
        {
            int adr = -1;
            if (size < sizeTable)
            {
                adr = hashKey(phone);

                while (!h[adr].empty)
                    adr = (adr + step) % sizeTable;


                h[adr].empty = false;
                h[adr].visit = true;
                h[adr].info.fio = fio;
                h[adr].info.phone = phone;
                size++;
            }
            return adr;

        }

        void ClearVisit()
        {

        }

        public bool DelHash(string phone, out int i) 
        {
            bool result = false;
            i = 0;
            if (size != 0) 
            {
                i = hashKey(phone);
               
                if (h[i].info.phone == phone)
               
                {
                    h[i].empty = true;
                    result = true;
                    size--;
                }
                else 
                {
                    string FIO; int count;
                    i = FindHash(phone, out FIO, out count);
                    if (i != -1)
                    
                    {
                        h[i].empty = true;
                        result = true;
                        size--;
                    }
                }
            }
            return result;
        }

        void FillHashTable()
        {
           
        }

        public int FindHash(string phone, out string fio, out int count) 
        {
            int result = -1;
            bool ok;
            fio = "";
            count = 1;
            ClearVisit();
            int i = hashKey(phone);
            ok = h[i].info.phone == phone;
            while (!ok && !h[i].visit)
            {
                count++;
                h[i].visit = true;
                i = (i + step) % sizeTable;
                ok = h[i].info.phone == phone;
            }

            if (ok)
            {
                result = i;
                fio = h[result].info.fio;
            }
            return result;
        }
    }

}
