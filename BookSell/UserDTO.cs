using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSell
{
    class UserDTO
    {
        private string memid;
        private string memname;
        private string mempw;
        private string memphone;
        private string memaddre;

        public UserDTO(string memid, string memname, string mempw, string memphone, string memaddre)
        {
            this.memid = memid;
            this.memname = memname;
            this.mempw = mempw;
            this.memphone = memphone;
            this.memaddre = memaddre;
        }

        public string Memid
        {
            get
            {
                return memid;
            }
            set
            {
                memid = value;
            }
        }

        public string Memname
        {
            get
            {
                return memname;
            }
            set
            {
                memname = value;
            }
        }

        public string Mempw
        {
            get
            {
                return mempw;
            }
            set
            {
                mempw = value;
            }
        }

        public string Memphone
        {
            get
            {
                return memphone;
            }
            set
            {
                memphone = value;
            }
        }

        public string Memaddre
        {
            get
            {
                return memaddre;
            }
            set
            {
                memaddre = value;
            }
        }
    }
}
