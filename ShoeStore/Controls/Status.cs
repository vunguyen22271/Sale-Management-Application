using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Controls
{
    public class Status
    {
        private string success;
        private string failure;
        private string exist;
        private String nonexistence;

        public string Success { get => success; }
        public string Failure { get => failure; }
        public string Exist { get => exist; }
        public string Nonexistence { get => nonexistence; }

        public Status()
        {
            success = "success";
            failure = "fail";

            exist = "exist";
            nonexistence = "nonexistence";
        }
    }
}