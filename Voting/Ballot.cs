using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    internal class Ballot
    {
        private int[] CompanyList = new int[4] { 0, 0, 0, 0 };
        private string[] CompanyNameList = new string[4] { "Apple", "Huawei", "Samsung", "Nokia" };

        public bool VoteAdd(int indexCompany)
        {
            if (indexCompany > 4 || indexCompany < 1)
                return false;
            CompanyList[--indexCompany]++;
            return true;
        }

        public void PrintNameList()
        {
            int i = 1;
            foreach (string s in CompanyNameList)
                Console.WriteLine((i++).ToString() + ". " + s);
        }

        public void PrintResult()
        {
            Console.WriteLine("Voting result:");
            for (int i = 0; i < 4; i++)
                Console.WriteLine(CompanyNameList[i] + " - " + CompanyList[i]);
        }
    }
}
