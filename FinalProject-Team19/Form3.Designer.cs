namespace FinalProject_Team19
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.txtHeight1 = new System.Windows.Forms.TextBox();
            this.radM = new System.Windows.Forms.RadioButton();
            this.radS = new System.Windows.Forms.RadioButton();
            this.grbHUnits = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnBMI = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAStats = new System.Windows.Forms.Button();
            this.btnWStats = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.radLast = new System.Windows.Forms.RadioButton();
            this.radFirst = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeight1 = new System.Windows.Forms.Label();
            this.txtHeight2 = new System.Windows.Forms.TextBox();
            this.lblIN = new System.Windows.Forms.Label();
            this.lblW1 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbHUnits.SuspendLayout();
            this.grbSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(24, 28);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(60, 13);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(24, 61);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(61, 13);
            this.lblLast.TabIndex = 1;
            this.lblLast.Text = "Last Name:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(287, 65);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(287, 98);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 13);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(24, 98);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age:";
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirst.Location = new System.Drawing.Point(90, 25);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(121, 20);
            this.txtFirst.TabIndex = 5;
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.SystemColors.Window;
            this.txtLast.Location = new System.Drawing.Point(91, 58);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(120, 20);
            this.txtLast.TabIndex = 6;
            // 
            // cboAge
            // 
            this.cboAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Items.AddRange(new object[] {
            "< 18",
            "18 - 40",
            "41 - 65",
            "> 65"});
            this.cboAge.Location = new System.Drawing.Point(90, 95);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(121, 21);
            this.cboAge.TabIndex = 7;
            this.cboAge.SelectedIndexChanged += new System.EventHandler(this.cboAge_SelectedIndexChanged);
            // 
            // txtHeight1
            // 
            this.txtHeight1.BackColor = System.Drawing.SystemColors.Window;
            this.txtHeight1.Location = new System.Drawing.Point(334, 62);
            this.txtHeight1.Name = "txtHeight1";
            this.txtHeight1.Size = new System.Drawing.Size(37, 20);
            this.txtHeight1.TabIndex = 8;
            // 
            // radM
            // 
            this.radM.AutoSize = true;
            this.radM.Location = new System.Drawing.Point(20, 17);
            this.radM.Name = "radM";
            this.radM.Size = new System.Drawing.Size(53, 17);
            this.radM.TabIndex = 9;
            this.radM.TabStop = true;
            this.radM.Text = "metric";
            this.radM.UseVisualStyleBackColor = true;
            this.radM.CheckedChanged += new System.EventHandler(this.radM_CheckedChanged);
            // 
            // radS
            // 
            this.radS.AutoSize = true;
            this.radS.Location = new System.Drawing.Point(20, 40);
            this.radS.Name = "radS";
            this.radS.Size = new System.Drawing.Size(66, 17);
            this.radS.TabIndex = 11;
            this.radS.TabStop = true;
            this.radS.Text = "standard";
            this.radS.UseVisualStyleBackColor = true;
            this.radS.CheckedChanged += new System.EventHandler(this.radS_CheckedChanged);
            // 
            // grbHUnits
            // 
            this.grbHUnits.Controls.Add(this.radS);
            this.grbHUnits.Controls.Add(this.radM);
            this.grbHUnits.Location = new System.Drawing.Point(439, 58);
            this.grbHUnits.Name = "grbHUnits";
            this.grbHUnits.Size = new System.Drawing.Size(116, 66);
            this.grbHUnits.TabIndex = 13;
            this.grbHUnits.TabStop = false;
            this.grbHUnits.Text = "Units:";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtWeight.Location = new System.Drawing.Point(334, 95);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 14;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(464, 142);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(92, 65);
            this.btnEnter.TabIndex = 18;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lstOut
            // 
            this.lstOut.BackColor = System.Drawing.SystemColors.Window;
            this.lstOut.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(23, 213);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(437, 173);
            this.lstOut.TabIndex = 26;
            this.lstOut.SelectedIndexChanged += new System.EventHandler(this.lstOut_SelectedIndexChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(464, 213);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(91, 23);
            this.btnDisplay.TabIndex = 27;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(464, 242);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(92, 23);
            this.btnBMI.TabIndex = 28;
            this.btnBMI.Text = "BMI";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(465, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(465, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAStats
            // 
            this.btnAStats.Location = new System.Drawing.Point(464, 271);
            this.btnAStats.Name = "btnAStats";
            this.btnAStats.Size = new System.Drawing.Size(91, 23);
            this.btnAStats.TabIndex = 31;
            this.btnAStats.Text = "Age Stats";
            this.btnAStats.UseVisualStyleBackColor = true;
            this.btnAStats.Click += new System.EventHandler(this.btnAStats_Click);
            // 
            // btnWStats
            // 
            this.btnWStats.Location = new System.Drawing.Point(465, 300);
            this.btnWStats.Name = "btnWStats";
            this.btnWStats.Size = new System.Drawing.Size(91, 23);
            this.btnWStats.TabIndex = 32;
            this.btnWStats.Text = "Weight Stats";
            this.btnWStats.UseVisualStyleBackColor = true;
            this.btnWStats.Click += new System.EventHandler(this.btnWStats_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(1, 29);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Location = new System.Drawing.Point(51, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 20;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.radLast);
            this.grbSearch.Controls.Add(this.radFirst);
            this.grbSearch.Location = new System.Drawing.Point(172, 10);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(170, 44);
            this.grbSearch.TabIndex = 23;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search Selection:";
            // 
            // radLast
            // 
            this.radLast.AutoSize = true;
            this.radLast.Location = new System.Drawing.Point(85, 19);
            this.radLast.Name = "radLast";
            this.radLast.Size = new System.Drawing.Size(76, 17);
            this.radLast.TabIndex = 22;
            this.radLast.TabStop = true;
            this.radLast.Text = "Last Name";
            this.radLast.UseVisualStyleBackColor = true;
            // 
            // radFirst
            // 
            this.radFirst.AutoSize = true;
            this.radFirst.Location = new System.Drawing.Point(4, 19);
            this.radFirst.Name = "radFirst";
            this.radFirst.Size = new System.Drawing.Size(75, 17);
            this.radFirst.TabIndex = 21;
            this.radFirst.TabStop = true;
            this.radFirst.Text = "First Name";
            this.radFirst.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(348, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.grbSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Location = new System.Drawing.Point(23, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 65);
            this.panel1.TabIndex = 25;
            // 
            // lblHeight1
            // 
            this.lblHeight1.AutoSize = true;
            this.lblHeight1.Location = new System.Drawing.Point(344, 46);
            this.lblHeight1.Name = "lblHeight1";
            this.lblHeight1.Size = new System.Drawing.Size(0, 13);
            this.lblHeight1.TabIndex = 33;
            // 
            // txtHeight2
            // 
            this.txtHeight2.Location = new System.Drawing.Point(377, 62);
            this.txtHeight2.Name = "txtHeight2";
            this.txtHeight2.Size = new System.Drawing.Size(33, 20);
            this.txtHeight2.TabIndex = 34;
            this.txtHeight2.Visible = false;
            // 
            // lblIN
            // 
            this.lblIN.AutoSize = true;
            this.lblIN.Location = new System.Drawing.Point(386, 46);
            this.lblIN.Name = "lblIN";
            this.lblIN.Size = new System.Drawing.Size(15, 13);
            this.lblIN.TabIndex = 35;
            this.lblIN.Text = "in";
            this.lblIN.Visible = false;
            // 
            // lblW1
            // 
            this.lblW1.AutoSize = true;
            this.lblW1.Location = new System.Drawing.Point(440, 98);
            this.lblW1.Name = "lblW1";
            this.lblW1.Size = new System.Drawing.Size(0, 13);
            this.lblW1.TabIndex = 36;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(277, 392);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(183, 23);
            this.btnConvert.TabIndex = 37;
            this.btnConvert.Text = "Height and Weight Conversion";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(389, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 109);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(566, 425);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblW1);
            this.Controls.Add(this.lblIN);
            this.Controls.Add(this.txtHeight2);
            this.Controls.Add(this.lblHeight1);
            this.Controls.Add(this.btnWStats);
            this.Controls.Add(this.btnAStats);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight1);
            this.Controls.Add(this.cboAge);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.grbHUnits);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "BMI Calculator-FinalProject By Team19";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grbHUnits.ResumeLayout(false);
            this.grbHUnits.PerformLayout();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.TextBox txtHeight1;
        private System.Windows.Forms.RadioButton radM;
        private System.Windows.Forms.RadioButton radS;
        private System.Windows.Forms.GroupBox grbHUnits;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAStats;
        private System.Windows.Forms.Button btnWStats;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.RadioButton radLast;
        private System.Windows.Forms.RadioButton radFirst;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeight1;
        private System.Windows.Forms.TextBox txtHeight2;
        private System.Windows.Forms.Label lblIN;
        private System.Windows.Forms.Label lblW1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}