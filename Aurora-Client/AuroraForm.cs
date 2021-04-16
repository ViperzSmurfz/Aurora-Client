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
using Aurora_Client.Forms;
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
        public Dictionary<Button, Form> Displays;
        public Form CurrentDisplay;
        public AuroraForm()
        {
            InitializeComponent();
            InitAddFont();
            HeaderLbl.Font = new Font(pfc.Families[0], 14);
            MinimizeBtn.Font = new Font(pfc.Families[0], 10, FontStyle.Bold);
            CloseBtn.Font = new Font(pfc.Families[0], 10, FontStyle.Bold);
            TitleLbl.Font = new Font(pfc.Families[0], 14);

            //Create Displays
            Displays = new Dictionary<Button, Form>() {
                { DashboardBtn, new DashboardForm() },
                { ModsBtn, new ModsForm() },
                { SettingsBtn, new SettingsForm() },
                { PlayBtn, new PlayForm() }
            };

            //Start and Hide Displays
            foreach (Form v in Displays.Values)
            {
                v.Show();
                v.Hide();
            }

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

        private void DisplayDesktop(Button btn)
        {
            Displays[btn].TopLevel = false;
            Displays[btn].FormBorderStyle = FormBorderStyle.None;
            Displays[btn].Dock = DockStyle.Fill;
            if (CurrentDisplay != null)
            {
                DesktopPnl.Controls.Remove(CurrentDisplay);
            }
            DesktopPnl.Controls.Add(Displays[btn]);
            DesktopPnl.Tag = Displays[btn];
            Displays[btn].BringToFront();
            Displays[btn].Show();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            HeaderLbl.Text = "Dashboard";
            DisplayDesktop(DashboardBtn);
        }

        private void AuroraForm_Load(object sender, EventArgs e)
        {
            DisplayDesktop(DashboardBtn);
        }

        private void ModsBtn_Click(object sender, EventArgs e)
        {
            HeaderLbl.Text = "AuroraMC Modlist";
            DisplayDesktop(ModsBtn);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            HeaderLbl.Text = "Client Settings";
            DisplayDesktop(ModsBtn);
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            HeaderLbl.Text = "Launch AuroraMC";
            DisplayDesktop(ModsBtn);
        }

        private void WebsiteBtn_Click(object sender, EventArgs e)
        {
            Form Confirm = new WebsiteConfirmForm();
            Confirm.StartPosition = FormStartPosition.CenterParent;
            Confirm.ShowDialog();
        }

        private void TitleLbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
