namespace SpritaiAutoClick
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            StartButton = new Krypton.Toolkit.KryptonButton();
            StopButton = new Krypton.Toolkit.KryptonButton();
            kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            MsValue = new Krypton.Toolkit.KryptonNumericUpDown();
            NotifCheck = new Krypton.Toolkit.KryptonCheckBox();
            SuspendLayout();
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(12, 12);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(144, 40);
            StartButton.StateNormal.Border.Rounding = 15F;
            StartButton.StateNormal.Border.Width = 2;
            StartButton.StatePressed.Back.Color1 = SystemColors.ScrollBar;
            StartButton.StatePressed.Back.Color2 = SystemColors.WindowFrame;
            StartButton.StatePressed.Border.Rounding = 18F;
            StartButton.StatePressed.Border.Width = 2;
            StartButton.StateTracking.Back.Color1 = SystemColors.ActiveCaption;
            StartButton.StateTracking.Back.Color2 = SystemColors.ActiveBorder;
            StartButton.StateTracking.Border.Color1 = SystemColors.ControlDark;
            StartButton.StateTracking.Border.Color2 = SystemColors.ControlDarkDark;
            StartButton.StateTracking.Border.Rounding = 15F;
            StartButton.StateTracking.Border.Width = 2;
            StartButton.TabIndex = 0;
            StartButton.Values.DropDownArrowColor = Color.Empty;
            StartButton.Values.Text = "START";
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(172, 12);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(144, 40);
            StopButton.StateNormal.Border.Rounding = 15F;
            StopButton.StateNormal.Border.Width = 2;
            StopButton.StatePressed.Back.Color1 = SystemColors.ScrollBar;
            StopButton.StatePressed.Back.Color2 = SystemColors.WindowFrame;
            StopButton.StatePressed.Border.Rounding = 18F;
            StopButton.StatePressed.Border.Width = 2;
            StopButton.StateTracking.Back.Color1 = SystemColors.ActiveCaption;
            StopButton.StateTracking.Back.Color2 = SystemColors.ActiveBorder;
            StopButton.StateTracking.Border.Color1 = SystemColors.ControlDark;
            StopButton.StateTracking.Border.Color2 = SystemColors.ControlDarkDark;
            StopButton.StateTracking.Border.Rounding = 15F;
            StopButton.StateTracking.Border.Width = 2;
            StopButton.TabIndex = 1;
            StopButton.Values.DropDownArrowColor = Color.Empty;
            StopButton.Values.Text = "STOP";
            StopButton.Click += StopButton_Click;
            // 
            // kryptonCheckBox1
            // 
            kryptonCheckBox1.Location = new Point(138, 58);
            kryptonCheckBox1.Name = "kryptonCheckBox1";
            kryptonCheckBox1.RightToLeft = RightToLeft.No;
            kryptonCheckBox1.Size = new Size(57, 20);
            kryptonCheckBox1.TabIndex = 2;
            kryptonCheckBox1.Values.Text = "Status";
            kryptonCheckBox1.CheckedChanged += kryptonCheckBox1_CheckedChanged;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(87, 84);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.ReadOnly = true;
            kryptonTextBox1.Size = new Size(166, 35);
            kryptonTextBox1.StateCommon.Border.Rounding = 15F;
            kryptonTextBox1.StateCommon.Border.Width = 2;
            kryptonTextBox1.TabIndex = 3;
            kryptonTextBox1.Text = "Enter Key";
            kryptonTextBox1.TextAlign = HorizontalAlignment.Center;
            kryptonTextBox1.TextChanged += kryptonTextBox1_TextChanged;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(9, 357);
            kryptonLabel1.Margin = new Padding(0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(128, 20);
            kryptonLabel1.TabIndex = 4;
            kryptonLabel1.Values.Text = "Spritai's AutoClick 1.3";
            kryptonLabel1.Click += kryptonLabel1_Click;
            // 
            // MsValue
            // 
            MsValue.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            MsValue.Location = new Point(104, 125);
            MsValue.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            MsValue.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            MsValue.Name = "MsValue";
            MsValue.Size = new Size(120, 22);
            MsValue.TabIndex = 5;
            MsValue.Value = new decimal(new int[] { 5, 0, 0, 0 });
            MsValue.ValueChanged += MsValue_ValueChanged;
            // 
            // NotifCheck
            // 
            NotifCheck.Location = new Point(139, 153);
            NotifCheck.Name = "NotifCheck";
            NotifCheck.Size = new Size(51, 20);
            NotifCheck.TabIndex = 6;
            NotifCheck.Values.Text = "Notif";
            NotifCheck.CheckedChanged += NotifCheck_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 386);
            Controls.Add(NotifCheck);
            Controls.Add(MsValue);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonCheckBox1);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Spritai's AutoClick";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonButton StartButton;
        private Krypton.Toolkit.KryptonButton StopButton;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonNumericUpDown MsValue;
        private Krypton.Toolkit.KryptonCheckBox NotifCheck;
    }
}
