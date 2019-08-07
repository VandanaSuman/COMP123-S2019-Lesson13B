using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson13B_PartC.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
          if (NameTabControl.SelectedIndex <NameTabControl.TabPages.Count - 1)
            { 
            NameTabControl.SelectedIndex++;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(NameTabControl.SelectedIndex != 0)
            { 
            NameTabControl.SelectedIndex--;
            }
        }
    }
}
