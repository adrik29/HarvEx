using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Eggpies
{
    public partial class Form1 : Form
    {
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ScreenCapture sc = new ScreenCapture();
            sc.CaptureWindowToFile(Handle, saveFileDialog1.FileName, ImageFormat.Jpeg);
        }

        // Atalho de teclado
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                saveFileDialog1.FileName = "Screenshot maroto";
                saveFileDialog1.DefaultExt = ".jpg";
                saveFileDialog1.ShowDialog();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D))
            {
                if (panDebug.Visible) panDebug.Visible = false;
                else
                {
                    panDebug.Size = uniSize;
                    panDebug.Location = uniPoint;
                    panDebug.Visible = true;
                    picFlag.Visible = false;
                    labCountryName.Visible = false;
                    panDebug.BringToFront();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
