using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;

namespace SpritaiAutoClick
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer clickTimer;
        private NotifyIcon notifyIcon;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int WM_HOTKEY = 0x0312;
        private const uint MOD_NONE = 0x0000;
        private int currentHotkeyId = 9000;
        private Keys currentHotkeyKey = Keys.F6;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            clickTimer = new System.Windows.Forms.Timer();
            clickTimer.Interval = (int)MsValue.Value;
            clickTimer.Tick += ClickTimer_Tick;

            kryptonTextBox1.ReadOnly = false;
            kryptonTextBox1.Text = currentHotkeyKey.ToString();
            kryptonTextBox1.KeyDown += kryptonTextBox1_KeyDown;

            kryptonCheckBox1.AutoCheck = false;
            RegisterHotKey(this.Handle, currentHotkeyId, MOD_NONE, currentHotkeyKey);

            // Initialisation de la notification
            notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.BalloonTipTitle = "Spritaï AutoClick";
        }

        private void kryptonTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            UnregisterHotKey(this.Handle, currentHotkeyId);

            currentHotkeyKey = e.KeyCode;
            kryptonTextBox1.Text = currentHotkeyKey.ToString();

            RegisterHotKey(this.Handle, currentHotkeyId, MOD_NONE, currentHotkeyKey);

            e.SuppressKeyPress = true;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == currentHotkeyId)
            {
                kryptonCheckBox1.Checked = !kryptonCheckBox1.Checked;
            }
            base.WndProc(ref m);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, currentHotkeyId);
            base.OnFormClosing(e);
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            // Anti click sur fenetre
            Point cursorScreenPos = Cursor.Position;
            Point cursorClientPos = this.PointToClient(cursorScreenPos);

            if (!this.ClientRectangle.Contains(cursorClientPos))
            {
                DoMouseClick();
            }
        }

        private void DoMouseClick()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            PlayClickSound();
            kryptonCheckBox1.Checked = true;
            clickTimer.Start();

            if (NotifCheck.Checked)
            {
                notifyIcon.BalloonTipText = "L'autoclick a démarré.";
                notifyIcon.ShowBalloonTip(3000);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            PlayClickSound();
            kryptonCheckBox1.Checked = false;
            clickTimer.Stop();

            if (NotifCheck.Checked)
            {
                notifyIcon.BalloonTipText = "L'autoclick a été arrêté.";
                notifyIcon.ShowBalloonTip(3000);
            }
        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonCheckBox1.Checked)
                clickTimer.Start();
            else
                clickTimer.Stop();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e) { }

        private void kryptonLabel1_Click(object sender, EventArgs e) { }

        private void delayNumericUpDown_ValueChanged(object sender, EventArgs e) { }

        private void MsValue_ValueChanged(object sender, EventArgs e)
        {
            clickTimer.Interval = (int)MsValue.Value;
        }

        private void NotifCheck_CheckedChanged(object sender, EventArgs e) { }

        private void PlayClickSound()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("click.wav");
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la lecture du son : " + ex.Message);
            }
        }
    }
}