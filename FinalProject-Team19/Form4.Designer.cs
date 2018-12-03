namespace FinalProject_Team19
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.radHeight = new System.Windows.Forms.RadioButton();
            this.radWeight = new System.Windows.Forms.RadioButton();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.grbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // radHeight
            // 
            this.radHeight.AutoSize = true;
            this.radHeight.Location = new System.Drawing.Point(15, 21);
            this.radHeight.Name = "radHeight";
            this.radHeight.Size = new System.Drawing.Size(56, 17);
            this.radHeight.TabIndex = 0;
            this.radHeight.TabStop = true;
            this.radHeight.Text = "Height";
            this.radHeight.UseVisualStyleBackColor = true;
            this.radHeight.CheckedChanged += new System.EventHandler(this.radHeight_CheckedChanged);
            // 
            // radWeight
            // 
            this.radWeight.AutoSize = true;
            this.radWeight.Location = new System.Drawing.Point(85, 21);
            this.radWeight.Name = "radWeight";
            this.radWeight.Size = new System.Drawing.Size(59, 17);
            this.radWeight.TabIndex = 1;
            this.radWeight.TabStop = true;
            this.radWeight.Text = "Weight";
            this.radWeight.UseVisualStyleBackColor = true;
            this.radWeight.CheckedChanged += new System.EventHandler(this.radWeight_CheckedChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(99, 75);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 4;
            this.txt1.Visible = false;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(99, 115);
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 5;
            this.txt2.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 78);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "label1";
            this.lbl1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 118);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "label2";
            this.lbl2.Visible = false;
            // 
            // grbType
            // 
            this.grbType.Controls.Add(this.radWeight);
            this.grbType.Controls.Add(this.radHeight);
            this.grbType.Location = new System.Drawing.Point(26, 12);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(150, 44);
            this.grbType.TabIndex = 8;
            this.grbType.TabStop = false;
            this.grbType.Text = "Type:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(96, 223);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back to Main Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 223);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(12, 249);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(201, 13);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "*Note: All calculations are approximations";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(59, 194);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 15;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 154);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(35, 13);
            this.lbl3.TabIndex = 16;
            this.lbl3.Text = "label3";
            this.lbl3.Visible = false;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(99, 151);
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 17;
            this.txt3.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(211, 282);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form4";
            this.Text = "Height & Weight Conversion - FinalProject By Team19";
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radHeight;
        private System.Windows.Forms.RadioButton radWeight;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt3;
    }
}