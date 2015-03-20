using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unicode_csv_converter
{
    public class EncodingItem
    {

        public string Name
        {
            get;
            private set;
        }

        public Encoding Encoding
        {
            get;
            private set;
        }

        public EncodingItem(string name, Encoding encoding)
        {
            this.Encoding = encoding;
            this.Name = name;
        }

    }
}
