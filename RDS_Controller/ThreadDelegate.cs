using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RDS_Controller
{
    public class ThreadDelegate
    {
        public delegate void ThreadEvent<T,Y,U>(T t,Y y,U u);
    }
}
