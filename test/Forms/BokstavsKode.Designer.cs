namespace test.Forms
{
    partial class BogstavsKode
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.TranslateBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkFraKode = new System.Windows.Forms.CheckBox();
            this.checkTilKode = new System.Windows.Forms.CheckBox();
            this.StartBogstavTextBox = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.TranslateBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(350, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 450);
            this.panel3.TabIndex = 8;
            // 
            // TranslateBtn
            // 
            this.TranslateBtn.Location = new System.Drawing.Point(6, 115);
            this.TranslateBtn.Name = "TranslateBtn";
            this.TranslateBtn.Size = new System.Drawing.Size(88, 23);
            this.TranslateBtn.TabIndex = 0;
            this.TranslateBtn.Text = "Oversæt";
            this.TranslateBtn.UseVisualStyleBackColor = true;
            this.TranslateBtn.Click += new System.EventHandler(this.TranslateBtn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(450, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 450);
            this.panel2.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.OutputTextBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(350, 380);
            this.panel7.TabIndex = 2;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputTextBox.Location = new System.Drawing.Point(0, 0);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(350, 111);
            this.OutputTextBox.TabIndex = 3;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(350, 70);
            this.panel6.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 450);
            this.panel1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkFraKode);
            this.panel5.Controls.Add(this.checkTilKode);
            this.panel5.Controls.Add(this.StartBogstavTextBox);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.InputTextBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 380);
            this.panel5.TabIndex = 3;
            // 
            // checkFraKode
            // 
            this.checkFraKode.AutoSize = true;
            this.checkFraKode.Location = new System.Drawing.Point(85, 234);
            this.checkFraKode.Name = "checkFraKode";
            this.checkFraKode.Size = new System.Drawing.Size(63, 21);
            this.checkFraKode.TabIndex = 5;
            this.checkFraKode.Text = "Kode";
            this.checkFraKode.UseVisualStyleBackColor = true;
            this.checkFraKode.CheckedChanged += new System.EventHandler(this.checkFraKode_CheckedChanged);
            // 
            // checkTilKode
            // 
            this.checkTilKode.AutoSize = true;
            this.checkTilKode.Location = new System.Drawing.Point(13, 234);
            this.checkTilKode.Name = "checkTilKode";
            this.checkTilKode.Size = new System.Drawing.Size(57, 21);
            this.checkTilKode.TabIndex = 4;
            this.checkTilKode.Text = "Text";
            this.checkTilKode.UseVisualStyleBackColor = true;
            this.checkTilKode.CheckedChanged += new System.EventHandler(this.checkTilKode_CheckedChanged);
            // 
            // StartBogstavTextBox
            // 
            this.StartBogstavTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartBogstavTextBox.Location = new System.Drawing.Point(118, 190);
            this.StartBogstavTextBox.Name = "StartBogstavTextBox";
            this.StartBogstavTextBox.Size = new System.Drawing.Size(100, 22);
            this.StartBogstavTextBox.TabIndex = 3;
            this.StartBogstavTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartBogstavTextBox.TextChanged += new System.EventHandler(this.StartBogstavTextBox_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 111);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(350, 73);
            this.panel8.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Forskydnings Bogstav";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputTextBox.Location = new System.Drawing.Point(0, 0);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 111);
            this.InputTextBox.TabIndex = 1;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 70);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // BogstavsKode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BogstavsKode";
            this.Text = "Bogstavs Kode";
            this.Load += new System.EventHandler(this.BogstavsKode_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button TranslateBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox StartBogstavTextBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkFraKode;
        private System.Windows.Forms.CheckBox checkTilKode;
    }
}