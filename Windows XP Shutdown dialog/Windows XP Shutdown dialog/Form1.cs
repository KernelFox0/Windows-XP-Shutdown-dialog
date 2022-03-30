using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Threading;
using System.Diagnostics;

namespace Windows_XP_Shutdown_dialog
{
    public partial class shutdialog : Form
    {
        public shutdialog()
        {
            InitializeComponent();
            /*PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"C:\Windows\Fonts\vgasys.fon");
            Font f = new Font(@"C:\Windows\Fonts\vgasys.fon", 69);*/
            cancelButton.Font = new Font(@"C:\Windows\Fonts>vgasys.fon", 12, FontStyle.Regular);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Sleep() { this.Close(); Process.Start("\"C:\\Program Files\\Windows XP Shutdown dialog\\psshutdown64.exe\" -d -t 0"); }
        public void Shutdown() { this.Close(); Process.Start(@"C:\Windows\System32\shutdown.exe -s -t 0"); }
        public void Restart() { this.Close(); Process.Start(@"C:\Windows\System32\shutdown.exe -r -t 0"); }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Thread sl = new Thread();
            Sleep();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Shutdown();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GG! You found an easter egg in a shutdown dialog!\nAre you clicking randomly?", "Easter egg!!!1!!1!", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
