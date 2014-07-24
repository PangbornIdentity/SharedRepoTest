using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedRepo
{
    public class RepoShare
    {
        public string value;
        public int number;

        public void ReposShare()
        {
            value = "Initial value";
            number = 0;
        }

        public void setValue(string val)
        {
            value = val;
        }
        public void setNumber(int num)
        {
            number = num;
        }
        public string getValue() { return value; }
        public int getNumber() { return number; }
    }
}
