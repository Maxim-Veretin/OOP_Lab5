using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            hoverBut.imgs.Add(Properties.Resources.smork);
            hoverBut.imgs.Add(Properties.Resources.smork1);
            hoverBut.imgs.Add(Properties.Resources.smork2);

            ellipseHoverBut.imgs.Add(Properties.Resources.smork);
            ellipseHoverBut.imgs.Add(Properties.Resources.smork1);
            ellipseHoverBut.imgs.Add(Properties.Resources.smork2);
        }
    }
}
