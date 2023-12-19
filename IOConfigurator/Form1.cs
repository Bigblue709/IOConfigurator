using System.Diagnostics;

namespace IOConfigurator
{
    public partial class Form1 : Form
    {
        String FastIoExe = "";
        String JvsExe = "";
        String J2kExe = "";
        String J2kIni = "";
        String BffExe = "";
        String BffGuiExe = "";

        bool fastioEnabled = false;
        bool jvsEnabled = false;
        bool j2kEnabled = false;
        bool bffEnabled = false;

        public Form1()
        {
            InitializeComponent();
            InitializeGlobals();
        }

        private void InitializeGlobals()
        {
            String[] iniValues = Utilities.CheckIni();

            fastioEnabled = bool.Parse(iniValues[0]);
            if (fastioEnabled) cbFIO.Checked = true;
            FastIoExe = iniValues[1];

            jvsEnabled = bool.Parse(iniValues[2]);
            if (jvsEnabled) cbJVS.Checked = true;
            JvsExe = iniValues[3];

            j2kEnabled = bool.Parse(iniValues[4]);
            if (j2kEnabled) cbJ2K.Checked = true;
            J2kExe = iniValues[5];
            tbJ2kExe.Text = J2kExe;
            J2kIni = iniValues[6];

            bffEnabled = bool.Parse(iniValues[7]);
            if (bffEnabled) cbBFF.Checked = true;
            BffExe = iniValues[8];
            BffGuiExe = iniValues[9];
        }

        // Enablers
        private void btnEnableFIO_Click(object sender, EventArgs e)
        {
            fastioEnabled = true;
            cbFIO.Checked = true;
        }

        private void btnEnableJVS_Click(object sender, EventArgs e)
        {
            jvsEnabled = true;
            cbJVS.Checked = true;
        }

        private void btnEnableJ2K_Click(object sender, EventArgs e)
        {
            if (File.Exists(J2kExe))
            {
                Utilities.KillApp("joytokey");
                Utilities.StartApp(J2kExe, ProcessWindowStyle.Hidden, false);

                j2kEnabled = true;
                cbJ2K.Checked = true;
            }
        }

        private void btnEnableBFF_Click(object sender, EventArgs e)
        {
            Utilities.KillApp("BackForceFeeder");
            Utilities.KillApp("BackForceFeederGUI");
            Utilities.StartApp(BffExe, ProcessWindowStyle.Hidden, false);

            bffEnabled = true;
            cbBFF.Checked = true;
        }

        // Disablers
        private void btnDisableFIO_Click(object sender, EventArgs e)
        {
            fastioEnabled = false;
            cbFIO.Checked = false;
        }

        private void btnDisableJVS_Click(object sender, EventArgs e)
        {
            jvsEnabled = false;
            cbJVS.Checked = false;
        }

        private void btnDisableJ2K_Click(object sender, EventArgs e)
        {
            Utilities.KillApp("joytokey");

            j2kEnabled = false;
            cbJ2K.Checked = false;
        }

        private void btnDisableBFF_Click(object sender, EventArgs e)
        {
            Utilities.KillApp("BackForceFeeder");
            Utilities.KillApp("BackForceFeederGUI");

            bffEnabled = false;
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
            if (File.Exists(J2kIni) && File.Exists(J2kExe))
            {
                Utilities.KillApp("joytokey");
                Utilities.EditText(J2kIni, "StartIconified=1", "StartIconified=0");
                Utilities.StartApp(J2kExe, ProcessWindowStyle.Maximized, true);
                Utilities.EditText(J2kIni, "StartIconified=0", "StartIconified=1");
                if(j2kEnabled)
                {
                    Utilities.StartApp(J2kExe, ProcessWindowStyle.Hidden, false);
                }
            }
            else
            {
                MessageBox.Show("Unable to find JoyToKey. Check path.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfigBFF_Click(object sender, EventArgs e)
        {
            if (File.Exists(BffGuiExe))
            {
                Utilities.KillApp("BackForceFeeder");
                Utilities.KillApp("BackForceFeederGUI");
                Utilities.StartApp(BffGuiExe, ProcessWindowStyle.Maximized, true);
                if (bffEnabled)
                {
                    Utilities.StartApp(BffExe, ProcessWindowStyle.Hidden, false);
                }
            }
            else
            {
                MessageBox.Show("Unable to find BackForceFeeder. Check path.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisableAll_Click(object sender, EventArgs e)
        {
            fastioEnabled = false;
            cbFIO.Checked = false;

            jvsEnabled = false;
            cbJVS.Checked = false;

            Utilities.KillApp("joytokey");
            j2kEnabled = false;
            cbJ2K.Checked = false;

            Utilities.KillApp("BackForceFeeder");
            Utilities.KillApp("BackForceFeederGUI");
            bffEnabled = false;
            cbBFF.Checked = false;
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            String[] iniValues = Utilities.CheckIni();
            iniValues[0] = cbFIO.Checked ? "true" : "false";
            iniValues[2] = cbJVS.Checked ? "true" : "false";
            iniValues[4] = cbJ2K.Checked ? "true" : "false";
            iniValues[7] = cbBFF.Checked ? "true" : "false";

            Utilities.UpdateIni(iniValues);
        }
    }
}
