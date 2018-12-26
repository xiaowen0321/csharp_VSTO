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


        private void ButtonAlignMiddle_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                if (((RibbonButton)sender).Label == "水平居中")
                {
                    AlignMiddle(Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange, AlignDirection.Horizontal);
                }
                else if (((RibbonButton)sender).Label == "垂直居中")
                {
                    AlignMiddle(Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange, AlignDirection.Vertical);
                }
                else
                {
                    AlignMiddle(Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange, AlignDirection.Horizontal);
                    AlignMiddle(Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange, AlignDirection.Vertical);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error");
            }
        }

        enum AlignDirection
        {
            Horizontal,
            Vertical
        }
        
        private void AlignMiddle(Microsoft.Office.Interop.PowerPoint.ShapeRange shapeRange, AlignDirection direction)
        {
            if (shapeRange == null || shapeRange.Count < 2)
            {
                return;
            }
            for (int i = 2; i <= shapeRange.Count; i++)
            {
                if (direction == AlignDirection.Horizontal)
                {
                    shapeRange[i].Left = shapeRange[1].Left + (shapeRange[1].Width - shapeRange[i].Width) / 2;
                }
                else if (direction == AlignDirection.Vertical)
                {
                    shapeRange[i].Top = shapeRange[1].Top + (shapeRange[1].Height - shapeRange[i].Height) / 2;
                }
                else
                {
                    return;
                }

            }

        }
    }
}
