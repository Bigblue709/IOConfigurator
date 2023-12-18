namespace IOConfigurator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEnableFIO = new Button();
            btnEnableJVS = new Button();
            btnEnableJ2K = new Button();
            btnEnableBFF = new Button();
            btnConfigBFF = new Button();
            btnConfigJ2K = new Button();
            btnConfigJVS = new Button();
            btnConfigFIO = new Button();
            btnDisableAll = new Button();
            cbFIO = new CheckBox();
            groupBox1 = new GroupBox();
            cbBFF = new CheckBox();
            cbJ2K = new CheckBox();
            cbJVS = new CheckBox();
            btnDisableBFF = new Button();
            btnDisableJ2K = new Button();
            btnDisableJVS = new Button();
            btnDisableFIO = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            textBox4 = new TextBox();
            label4 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox6 = new GroupBox();
            button7 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnableFIO
            // 
            btnEnableFIO.Location = new Point(6, 22);
            btnEnableFIO.Name = "btnEnableFIO";
            btnEnableFIO.Size = new Size(110, 55);
            btnEnableFIO.TabIndex = 0;
            btnEnableFIO.Text = "Enable FastIO";
            btnEnableFIO.UseVisualStyleBackColor = true;
            btnEnableFIO.Click += btnEnableFIO_Click;
            // 
            // btnEnableJVS
            // 
            btnEnableJVS.Location = new Point(6, 22);
            btnEnableJVS.Name = "btnEnableJVS";
            btnEnableJVS.Size = new Size(110, 55);
            btnEnableJVS.TabIndex = 1;
            btnEnableJVS.Text = "Enable JVS";
            btnEnableJVS.UseVisualStyleBackColor = true;
            btnEnableJVS.Click += btnEnableJVS_Click;
            // 
            // btnEnableJ2K
            // 
            btnEnableJ2K.Location = new Point(6, 22);
            btnEnableJ2K.Name = "btnEnableJ2K";
            btnEnableJ2K.Size = new Size(110, 55);
            btnEnableJ2K.TabIndex = 2;
            btnEnableJ2K.Text = "Enable JoyToKey";
            btnEnableJ2K.UseVisualStyleBackColor = true;
            btnEnableJ2K.Click += btnEnableJ2K_Click;
            // 
            // btnEnableBFF
            // 
            btnEnableBFF.Enabled = false;
            btnEnableBFF.Location = new Point(6, 22);
            btnEnableBFF.Name = "btnEnableBFF";
            btnEnableBFF.Size = new Size(110, 55);
            btnEnableBFF.TabIndex = 3;
            btnEnableBFF.Text = "Enable BackForceFeeder";
            btnEnableBFF.UseVisualStyleBackColor = true;
            btnEnableBFF.Click += btnEnableBFF_Click;
            // 
            // btnConfigBFF
            // 
            btnConfigBFF.Enabled = false;
            btnConfigBFF.Location = new Point(238, 22);
            btnConfigBFF.Name = "btnConfigBFF";
            btnConfigBFF.Size = new Size(110, 55);
            btnConfigBFF.TabIndex = 7;
            btnConfigBFF.Text = "Configure BackForceFeeder";
            btnConfigBFF.UseVisualStyleBackColor = true;
            btnConfigBFF.Click += btnConfigBFF_Click;
            // 
            // btnConfigJ2K
            // 
            btnConfigJ2K.Location = new Point(238, 22);
            btnConfigJ2K.Name = "btnConfigJ2K";
            btnConfigJ2K.Size = new Size(110, 55);
            btnConfigJ2K.TabIndex = 6;
            btnConfigJ2K.Text = "Configure JoyToKey";
            btnConfigJ2K.UseVisualStyleBackColor = true;
            btnConfigJ2K.Click += btnConfigJ2K_Click;
            // 
            // btnConfigJVS
            // 
            btnConfigJVS.Enabled = false;
            btnConfigJVS.Location = new Point(238, 22);
            btnConfigJVS.Name = "btnConfigJVS";
            btnConfigJVS.Size = new Size(110, 55);
            btnConfigJVS.TabIndex = 5;
            btnConfigJVS.Text = "Configure JVS";
            btnConfigJVS.UseVisualStyleBackColor = true;
            btnConfigJVS.Click += btnConfigJVS_Click;
            // 
            // btnConfigFIO
            // 
            btnConfigFIO.Enabled = false;
            btnConfigFIO.Location = new Point(238, 22);
            btnConfigFIO.Name = "btnConfigFIO";
            btnConfigFIO.Size = new Size(110, 55);
            btnConfigFIO.TabIndex = 4;
            btnConfigFIO.Text = "Configure FastIO";
            btnConfigFIO.UseVisualStyleBackColor = true;
            btnConfigFIO.Click += btnConfigFIO_Click;
            // 
            // btnDisableAll
            // 
            btnDisableAll.Location = new Point(6, 20);
            btnDisableAll.Name = "btnDisableAll";
            btnDisableAll.Size = new Size(99, 80);
            btnDisableAll.TabIndex = 8;
            btnDisableAll.Text = "Disable All IO (keyboard and mouse only)";
            btnDisableAll.UseVisualStyleBackColor = true;
            btnDisableAll.Click += btnDisableAll_Click;
            // 
            // cbFIO
            // 
            cbFIO.AutoSize = true;
            cbFIO.Enabled = false;
            cbFIO.Location = new Point(6, 22);
            cbFIO.Name = "cbFIO";
            cbFIO.Size = new Size(59, 19);
            cbFIO.TabIndex = 10;
            cbFIO.Text = "FastIO";
            cbFIO.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbBFF);
            groupBox1.Controls.Add(cbJ2K);
            groupBox1.Controls.Add(cbJVS);
            groupBox1.Controls.Add(cbFIO);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(111, 120);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "What's On?";
            // 
            // cbBFF
            // 
            cbBFF.AutoSize = true;
            cbBFF.Enabled = false;
            cbBFF.Location = new Point(6, 97);
            cbBFF.Name = "cbBFF";
            cbBFF.Size = new Size(45, 19);
            cbBFF.TabIndex = 13;
            cbBFF.Text = "BFF";
            cbBFF.UseVisualStyleBackColor = true;
            // 
            // cbJ2K
            // 
            cbJ2K.AutoSize = true;
            cbJ2K.Enabled = false;
            cbJ2K.Location = new Point(6, 72);
            cbJ2K.Name = "cbJ2K";
            cbJ2K.Size = new Size(74, 19);
            cbJ2K.TabIndex = 12;
            cbJ2K.Text = "JoyToKey";
            cbJ2K.UseVisualStyleBackColor = true;
            // 
            // cbJVS
            // 
            cbJVS.AutoSize = true;
            cbJVS.Enabled = false;
            cbJVS.Location = new Point(6, 47);
            cbJVS.Name = "cbJVS";
            cbJVS.Size = new Size(43, 19);
            cbJVS.TabIndex = 11;
            cbJVS.Text = "JVS";
            cbJVS.UseVisualStyleBackColor = true;
            // 
            // btnDisableBFF
            // 
            btnDisableBFF.Enabled = false;
            btnDisableBFF.Location = new Point(122, 22);
            btnDisableBFF.Name = "btnDisableBFF";
            btnDisableBFF.Size = new Size(110, 55);
            btnDisableBFF.TabIndex = 15;
            btnDisableBFF.Text = "Disable BackForceFeeder";
            btnDisableBFF.UseVisualStyleBackColor = true;
            btnDisableBFF.Click += btnDisableBFF_Click;
            // 
            // btnDisableJ2K
            // 
            btnDisableJ2K.Location = new Point(122, 22);
            btnDisableJ2K.Name = "btnDisableJ2K";
            btnDisableJ2K.Size = new Size(110, 55);
            btnDisableJ2K.TabIndex = 14;
            btnDisableJ2K.Text = "Disable JoyToKey";
            btnDisableJ2K.UseVisualStyleBackColor = true;
            btnDisableJ2K.Click += btnDisableJ2K_Click;
            // 
            // btnDisableJVS
            // 
            btnDisableJVS.Location = new Point(122, 22);
            btnDisableJVS.Name = "btnDisableJVS";
            btnDisableJVS.Size = new Size(110, 55);
            btnDisableJVS.TabIndex = 13;
            btnDisableJVS.Text = "Disable JVS";
            btnDisableJVS.UseVisualStyleBackColor = true;
            btnDisableJVS.Click += btnDisableJVS_Click;
            // 
            // btnDisableFIO
            // 
            btnDisableFIO.Location = new Point(122, 22);
            btnDisableFIO.Name = "btnDisableFIO";
            btnDisableFIO.Size = new Size(110, 55);
            btnDisableFIO.TabIndex = 12;
            btnDisableFIO.Text = "Disable FastIO";
            btnDisableFIO.UseVisualStyleBackColor = true;
            btnDisableFIO.Click += btnDisableFIO_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 23);
            textBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 86);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 17;
            label1.Text = "Path:";
            // 
            // button1
            // 
            button1.Location = new Point(313, 84);
            button1.Name = "button1";
            button1.Size = new Size(35, 23);
            button1.TabIndex = 18;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(313, 84);
            button2.Name = "button2";
            button2.Size = new Size(35, 23);
            button2.TabIndex = 21;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 86);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 20;
            label2.Text = "Path:";
            label2.Click += this.label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 23);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(313, 84);
            button3.Name = "button3";
            button3.Size = new Size(35, 23);
            button3.TabIndex = 24;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 23;
            label3.Text = "Path:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(46, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 23);
            textBox3.TabIndex = 22;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEnableFIO);
            groupBox2.Controls.Add(btnConfigFIO);
            groupBox2.Controls.Add(btnDisableFIO);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(145, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 120);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "FastIO";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEnableJVS);
            groupBox3.Controls.Add(btnConfigJVS);
            groupBox3.Controls.Add(btnDisableJVS);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(button2);
            groupBox3.Location = new Point(145, 138);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(356, 120);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "JVS";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnEnableJ2K);
            groupBox4.Controls.Add(btnConfigJ2K);
            groupBox4.Controls.Add(btnDisableJ2K);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(textBox3);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(145, 264);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(356, 120);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "JoyToKey";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox4);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(button4);
            groupBox5.Controls.Add(btnEnableBFF);
            groupBox5.Controls.Add(btnConfigBFF);
            groupBox5.Controls.Add(btnDisableBFF);
            groupBox5.Location = new Point(145, 390);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(356, 120);
            groupBox5.TabIndex = 28;
            groupBox5.TabStop = false;
            groupBox5.Text = "BackForceFeeder";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(46, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(261, 23);
            textBox4.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 86);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 20;
            label4.Text = "Path:";
            // 
            // button4
            // 
            button4.Location = new Point(313, 84);
            button4.Name = "button4";
            button4.Size = new Size(35, 23);
            button4.TabIndex = 21;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(6, 106);
            button5.Name = "button5";
            button5.Size = new Size(99, 80);
            button5.TabIndex = 29;
            button5.Text = "Edit Configurator .ini";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(6, 192);
            button6.Name = "button6";
            button6.Size = new Size(99, 80);
            button6.TabIndex = 30;
            button6.Text = "Kill and relaunch AM";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button7);
            groupBox6.Controls.Add(button5);
            groupBox6.Controls.Add(button6);
            groupBox6.Controls.Add(btnDisableAll);
            groupBox6.Location = new Point(12, 138);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(111, 372);
            groupBox6.TabIndex = 31;
            groupBox6.TabStop = false;
            groupBox6.Text = "General";
            // 
            // button7
            // 
            button7.Location = new Point(6, 278);
            button7.Name = "button7";
            button7.Size = new Size(99, 80);
            button7.TabIndex = 32;
            button7.Text = "Save and Exit";
            button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 519);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "IO Configurator v0.01";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnEnableFIO;
        private Button btnEnableJVS;
        private Button btnEnableJ2K;
        private Button btnEnableBFF;
        private Button btnConfigBFF;
        private Button btnConfigJ2K;
        private Button btnConfigJVS;
        private Button btnConfigFIO;
        private Button btnDisableAll;
        private CheckBox cbFIO;
        private GroupBox groupBox1;
        private CheckBox cbBFF;
        private CheckBox cbJ2K;
        private CheckBox cbJVS;
        private Button btnDisableBFF;
        private Button btnDisableJ2K;
        private Button btnDisableJVS;
        private Button btnDisableFIO;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox textBox2;
        private Button button3;
        private Label label3;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox textBox4;
        private Label label4;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox6;
        private Button button7;
    }
}
