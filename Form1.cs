using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANNY_PLAYER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] paths, files;

        private void selectMediaBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

               listBox1.Items.Clear();

                foreach (var file in files)
                {
                    listBox1.Items.Add(file);
                }
            }
        }
            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex >=0 && selectedIndex < paths.Length)
            {
                axWindowsMediaPlayer1.URL = paths[selectedIndex];   
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < paths.Length)
            {
                axWindowsMediaPlayer1.URL = paths[selectedIndex];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
