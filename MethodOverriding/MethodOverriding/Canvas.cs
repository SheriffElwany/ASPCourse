using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShaps(List<Shap> shapes)
        {
            foreach (var shap in shapes)
            {
                shap.Draw();
            }
        }
    }
}
