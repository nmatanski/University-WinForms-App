using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class CustomId
    {
        private Guid _id;

        public CustomId()
        {
            _id = Guid.NewGuid();
        }

        public CustomId(Guid guid)
        {
            _id = guid;
        }

        public override string ToString()
        {
            return _id.ToString();
        }
    }
}
