using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace PowerPointAlignCenter
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            var selectedShapes = Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange;
            try
            {
                if (selectedShapes.Count < 2)
                    return;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }

        private void AlignMiddle(Microsoft.Office.Interop.PowerPoint.ShapeRange shapeRange)
        {

        }
    }
}
