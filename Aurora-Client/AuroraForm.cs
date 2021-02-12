using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace Aurora_Client
{
    public partial class AuroraForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        PrivateFontCollection pfc = new PrivateFontCollection();
        public AuroraForm()
        {
            InitializeComponent();
            InitAddFont();
            HeaderLbl.Font = new Font(pfc.Families[0], 14);
            MinimizeBtn.Font = new Font(pfc.Families[0], 10, FontStyle.Bold);
            CloseBtn.Font = new Font(pfc.Families[0], 10, FontStyle.Bold);
            TitleLbl.Font = new Font(pfc.Families[0], 14);

            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.Mandatory = true;
            AutoUpdater.UpdateMode = Mode.Forced;
            AutoUpdater.AppTitle = "Aurora Client Update";
            AutoUpdater.Start("https://viperzaurora.com/updates/Version.xml");
        }

        private void InitAddFont()
        {
            int fontLength = Properties.Resources.Roboto.Length;
            byte[] fontdata = Properties.Resources.Roboto;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
        }

        private void DragBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void HeaderPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
