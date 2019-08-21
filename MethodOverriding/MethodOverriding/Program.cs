using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shap>();
            shapes.Add(new Shap { Hight = 100, Width = 200, MyProperty = new Position{ X = 100, Y = 200 } });
            shapes.Add(new Shap { Hight = 100, Width = 200, MyProperty = new Position{ X = 100, Y = 200 } });
           // shapes.Add(new Tringale { Hight = 100, Width = 200,  Position=new Position{ X = 100, Y = 200 } });

            var canvas = new Canvas();
            canvas.DrawShaps(shapes);

        }
    }
}
