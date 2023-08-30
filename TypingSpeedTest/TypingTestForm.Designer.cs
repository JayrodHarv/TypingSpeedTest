namespace TypingSpeedTest {
    partial class TypingTestForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypingTestForm));
            this.tbxInput = new System.Windows.Forms.RichTextBox();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblWPM = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAverageWPM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSlowestWPM = new System.Windows.Forms.Label();
            this.lblFastestWPM = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmViewStats = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClearTests = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditQuotes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangeQuote = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHint = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.DetectUrls = false;
            this.tbxInput.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbxInput.Location = new System.Drawing.Point(320, 380);
            this.tbxInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxInput.Size = new System.Drawing.Size(640, 120);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.Text = "";
            this.tbxInput.TextChanged += new System.EventHandler(this.tbxInput_TextChanged);
            // 
            // lblQuote
            // 
            this.lblQuote.BackColor = System.Drawing.Color.Transparent;
            this.lblQuote.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(2, 0);
            this.lblQuote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(640, 120);
            this.lblQuote.TabIndex = 1;
            // 
            // lblWPM
            // 
            this.lblWPM.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblWPM.Location = new System.Drawing.Point(3, 45);
            this.lblWPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWPM.Name = "lblWPM";
            this.lblWPM.Size = new System.Drawing.Size(283, 30);
            this.lblWPM.TabIndex = 2;
            this.lblWPM.Text = "Previous Test WPM:";
            this.lblWPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(320, 347);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(640, 30);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAverageWPM
            // 
            this.lblAverageWPM.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAverageWPM.Location = new System.Drawing.Point(44, 75);
            this.lblAverageWPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAverageWPM.Name = "lblAverageWPM";
            this.lblAverageWPM.Size = new System.Drawing.Size(194, 30);
            this.lblAverageWPM.TabIndex = 7;
            this.lblAverageWPM.Text = "Average WPM:";
            this.lblAverageWPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSlowestWPM);
            this.panel1.Controls.Add(this.lblFastestWPM);
            this.panel1.Controls.Add(this.lblWPM);
            this.panel1.Controls.Add(this.lblAverageWPM);
            this.panel1.Location = new System.Drawing.Point(1007, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 186);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Info Box";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSlowestWPM
            // 
            this.lblSlowestWPM.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSlowestWPM.Location = new System.Drawing.Point(48, 135);
            this.lblSlowestWPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSlowestWPM.Name = "lblSlowestWPM";
            this.lblSlowestWPM.Size = new System.Drawing.Size(234, 30);
            this.lblSlowestWPM.TabIndex = 9;
            this.lblSlowestWPM.Text = "Slowest WPM:";
            this.lblSlowestWPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFastestWPM
            // 
            this.lblFastestWPM.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFastestWPM.Location = new System.Drawing.Point(55, 105);
            this.lblFastestWPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFastestWPM.Name = "lblFastestWPM";
            this.lblFastestWPM.Size = new System.Drawing.Size(183, 30);
            this.lblFastestWPM.TabIndex = 8;
            this.lblFastestWPM.Text = "Fastest WPM:";
            this.lblFastestWPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblQuote);
            this.panel3.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(320, 222);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 120);
            this.panel3.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmViewStats,
            this.tsmClearTests,
            this.tsmEditQuotes,
            this.tsmChangeQuote,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmViewStats
            // 
            this.tsmViewStats.Name = "tsmViewStats";
            this.tsmViewStats.Size = new System.Drawing.Size(73, 20);
            this.tsmViewStats.Text = "View Tests";
            this.tsmViewStats.Click += new System.EventHandler(this.tsmViewTests_Click);
            // 
            // tsmClearTests
            // 
            this.tsmClearTests.Name = "tsmClearTests";
            this.tsmClearTests.Size = new System.Drawing.Size(75, 20);
            this.tsmClearTests.Text = "Clear Tests";
            this.tsmClearTests.Click += new System.EventHandler(this.tsmClearTests_Click);
            // 
            // tsmEditQuotes
            // 
            this.tsmEditQuotes.Name = "tsmEditQuotes";
            this.tsmEditQuotes.Size = new System.Drawing.Size(80, 20);
            this.tsmEditQuotes.Text = "Edit Quotes";
            this.tsmEditQuotes.Click += new System.EventHandler(this.tsmEditQuotes_Click);
            // 
            // tsmChangeQuote
            // 
            this.tsmChangeQuote.Name = "tsmChangeQuote";
            this.tsmChangeQuote.Size = new System.Drawing.Size(96, 20);
            this.tsmChangeQuote.Text = "Change Quote";
            this.tsmChangeQuote.Click += new System.EventHandler(this.tsmChangeQuote_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHint.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(320, 189);
            this.lblHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(300, 27);
            this.lblHint.TabIndex = 17;
            this.lblHint.Text = "Start typing quote below to begin:";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(829, 189);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(131, 30);
            this.lblTimeElapsed.TabIndex = 18;
            this.lblTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TypingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "TypingTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Speed Test";
            this.Activated += new System.EventHandler(this.TypingTestForm_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbxInput;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblWPM;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblAverageWPM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmViewStats;
        private System.Windows.Forms.ToolStripMenuItem tsmClearTests;
        private System.Windows.Forms.ToolStripMenuItem tsmEditQuotes;
        private System.Windows.Forms.ToolStripMenuItem tsmChangeQuote;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblFastestWPM;
        private System.Windows.Forms.Label lblSlowestWPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimeElapsed;
    }
}

