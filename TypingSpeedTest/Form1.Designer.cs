namespace TypingSpeedTest {
    partial class Form1 {
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
            this.tbxInput = new System.Windows.Forms.RichTextBox();
            this.lblQuote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWPM = new System.Windows.Forms.Label();
            this.btnViewStats = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.Location = new System.Drawing.Point(394, 345);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxInput.Size = new System.Drawing.Size(542, 96);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.Text = "";
            this.tbxInput.TextChanged += new System.EventHandler(this.tbxInput_TextChanged);
            // 
            // lblQuote
            // 
            this.lblQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(394, 242);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(542, 100);
            this.lblQuote.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Previous Test WPM:";
            // 
            // lblWPM
            // 
            this.lblWPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWPM.Location = new System.Drawing.Point(221, 7);
            this.lblWPM.Name = "lblWPM";
            this.lblWPM.Size = new System.Drawing.Size(64, 41);
            this.lblWPM.TabIndex = 3;
            // 
            // btnViewStats
            // 
            this.btnViewStats.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewStats.FlatAppearance.BorderSize = 3;
            this.btnViewStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStats.Location = new System.Drawing.Point(1150, 9);
            this.btnViewStats.Name = "btnViewStats";
            this.btnViewStats.Size = new System.Drawing.Size(149, 31);
            this.btnViewStats.TabIndex = 4;
            this.btnViewStats.Text = "View Stats";
            this.btnViewStats.UseVisualStyleBackColor = true;
            this.btnViewStats.Click += new System.EventHandler(this.btnViewStats_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quote From:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(522, 7);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(322, 31);
            this.lblAuthor.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1311, 630);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewStats);
            this.Controls.Add(this.lblWPM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.tbxInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Speed Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbxInput;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWPM;
        private System.Windows.Forms.Button btnViewStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAuthor;
    }
}

