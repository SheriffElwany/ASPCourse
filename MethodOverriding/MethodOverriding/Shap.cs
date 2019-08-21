using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{

  public  class Shap
    {
        public int Width { get; set; }
        public int Hight { get; set; }
        public Position MyProperty { get; set; }
        
        //public ShapType Type { get; set; }

        public virtual void Draw()
        {

        }
    }
}
