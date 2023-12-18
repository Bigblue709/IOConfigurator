using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace IOConfigurator
{
    public partial class Form1 : Form
    {
        String FastIoExe = "";
        String JvsExe = "";
        public String J2kExe = "";
        public String J2kIni = "";
        String BffExe = "";
        String BffGuiExe = "";

        public Form1()
        {
            InitializeComponent();
            InitializeGlobals();
        }

        private void InitializeGlobals()
        {
            String[] paths = Utilities.CheckIni();
            FastIoExe = paths[0];
            JvsExe = paths[1];
            J2kExe = paths[2];
            J2kIni = paths[3];
            BffExe = paths[4];
            BffGuiExe = paths[5];
        }

        // Enablers
        private void btnEnableFIO_Click(object sender, EventArgs e)
        {
            cbFIO.Checked = true;
        }

        private void btnEnableJVS_Click(object sender, EventArgs e)
        {
            cbJVS.Checked = true;
        }

        private void btnEnableJ2K_Click(object sender, EventArgs e)
        {
            if (File.Exists(J2kExe))
            {
                Utilities.KillApp("joytokey");
                Utilities.StartApp(J2kExe, ProcessWindowStyle.Minimized);
                cbJ2K.Checked = true;
            }
        }

        private void btnEnableBFF_Click(object sender, EventArgs e)
        {
            Utilities.KillApp("BackForceFeeder");
            Utilities.KillApp("BackForceFeederGUI");
            Utilities.StartApp(BffExe, ProcessWindowStyle.Minimized);
            cbBFF.Checked = true;
        }

        // Disablers
        private void btnDisableFIO_Click(object sender, EventArgs e)
        {
            cbFIO.Checked = false;
        }

        private void btnDisableJVS_Click(object sender, EventArgs e)
        {
            cbJVS.Checked = false;
        }

        private void btnDisableJ2K_Click(object sender, EventArgs e)
        {
            Utilities.KillApp("joytokey");
            cbJ2K.Checked = false;
        }

        private void btnDisableBFF_Click(object sender, EventArgs e)
        {
            Utilities.KillApp("BackForceFeeder");
            Utilities.KillApp("BackForceFeederGUI");
            cbBFF.Checked = false;
        }

        // Configs
        private void btnConfigFIO_Click(object sender, EventArgs e)
        {

        }

        private void btnConfigJVS_Click(object sender, EventArgs e)
        {

        }

        private void btnConfigJ2K_Click(object sender, EventArgs e)
        {
            MessageBox.Show(J2kExe, J2kIni, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (File.Exists(J2kIni) && File.Exists(J2kExe))
            {
                Utilities.KillApp("joytokey");
                Utilities.EditText(J2kIni, "StartIconified=1", "StartIconified=0");
                Utilities.StartAndWait(J2kExe, ProcessWindowStyle.Maximized);
                Utilities.EditText(J2kIni, "StartIconified=0", "StartIconified=1");
            }
            else
            {
                MessageBox.Show("Unable to find JoyToKey. Check path.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfigBFF_Click(object sender, EventArgs e)
        {
            if (File.Exists(BffExe) && File.Exists(BffGuiExe))
            {
                Utilities.KillApp("BackForceFeeder");
                Utilities.KillApp("BackForceFeederGUI");
                Utilities.StartAndWait(BffGuiExe, ProcessWindowStyle.Maximized);
                Utilities.StartApp(BffExe, ProcessWindowStyle.Minimized);
            }
            else
            {
                MessageBox.Show("Unable to find BackForceFeeder. Check path.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisableAll_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
