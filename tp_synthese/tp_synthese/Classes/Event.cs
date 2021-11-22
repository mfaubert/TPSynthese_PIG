using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace tp_synthese
{
    public abstract class Event
    {
        public int Id;
        public int UserId;
        public DateTime DateTime;
    }
}
