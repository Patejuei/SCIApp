using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIApp
{
    internal class Especie
    {
        public string code { get; set; }
        public string detail { get; set; }
        public string brand { get; set; }
        public string model { set; get; }
        public int quantity { get; set; }
        public string location { get; set; }
        public string dependency { get; set; }

        public Especie(string code, string detail, string quantity, string location, string dependency)
        {
            this.code = code;
            this.detail = detail;
            this.quantity = Filter_Int(quantity);
            this.location = location;
            this.dependency = dependency;
            this.brand = "N/A";
            this.model = "N/A";
        }

        public string[] getParams()
        {
            return new string[] { code, detail, brand, model, quantity.ToString(), dependency, location };
        }

        private string Filter_Code(string code)
        {
            return code;
        }
        private int Filter_Int(string num)
        {
            if (num.Length > 0)
            {
                return int.Parse(num);
            }
            return 0;
        }

    }
}
