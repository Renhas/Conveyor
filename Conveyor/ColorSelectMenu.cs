using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class ColorSelectMenu : Form
    {
        public ColorSelectMenu()
        {
            InitializeComponent();
        }
        public ColorSelectMenu(List<Color> colors) :this()
        {
            SetColors(colors);
        }

        public void SetColors(List<Color> colors) 
        {
            if (ColorPanel == null) return;
            ColorPanel.Controls.Clear();
            for (int i = 0; i < colors.Count(); i++) 
            {
                ColorPanel.Controls.Add(new ColorSelectElement(i + 1, colors[i]));
            }
        }

        public List<Color> GetColors() 
        {
            List<Color> colors = new List<Color>();
            foreach (var element in ColorPanel.Controls) 
            {
                if (element is ColorSelectElement color)
                    colors.Add(color.Color);
            }
            return colors;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
