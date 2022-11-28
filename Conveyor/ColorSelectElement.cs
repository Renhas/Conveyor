using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class ColorSelectElement : UserControl
    {
        ColorDialog dialog;
        public Color Color 
        {
            get { return ColorPanel.BackColor; }
            set 
            {
                ColorPanel.BackColor = value;
            } 
        }
        public int Id 
        {
            get { return int.Parse(ColorId.Text); }
            set { ColorId.Text = value.ToString(); }
        }
        public ColorSelectElement()
        {
            InitializeComponent();
            Color = Color.White;
            Id = 1;
            dialog = new ColorDialog();
        }

        public ColorSelectElement(int id, Color color) : this()
        {
            Color = color;
            Id = id;
        }

        private void ColorPanel_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() != DialogResult.OK) return;
            Color = dialog.Color;
        }
    }
}
