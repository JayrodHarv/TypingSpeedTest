namespace TypingSpeedTest {
    partial class EditQuoteForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditQuoteForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditQuote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAuthorName = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxQuoteText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(101, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditQuote
            // 
            this.btnEditQuote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditQuote.FlatAppearance.BorderSize = 3;
            this.btnEditQuote.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQuote.Location = new System.Drawing.Point(246, 237);
            this.btnEditQuote.Name = "btnEditQuote";
            this.btnEditQuote.Size = new System.Drawing.Size(139, 31);
            this.btnEditQuote.TabIndex = 14;
            this.btnEditQuote.Text = "Edit Quote";
            this.btnEditQuote.UseVisualStyleBackColor = true;
            this.btnEditQuote.Click += new System.EventHandler(this.btnEditQuote_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name of Author:";
            // 
            // tbxAuthorName
            // 
            this.tbxAuthorName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAuthorName.Location = new System.Drawing.Point(163, 179);
            this.tbxAuthorName.Name = "tbxAuthorName";
            this.tbxAuthorName.Size = new System.Drawing.Size(222, 29);
            this.tbxAuthorName.TabIndex = 12;
            this.tbxAuthorName.Text = "";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Edit the quote here:";
            // 
            // tbxQuoteText
            // 
            this.tbxQuoteText.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuoteText.Location = new System.Drawing.Point(12, 47);
            this.tbxQuoteText.Name = "tbxQuoteText";
            this.tbxQuoteText.Size = new System.Drawing.Size(373, 96);
            this.tbxQuoteText.TabIndex = 10;
            this.tbxQuoteText.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "*Make sure there are no newlines*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(398, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditQuote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAuthorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxQuoteText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(414, 317);
            this.MinimumSize = new System.Drawing.Size(414, 0);
            this.Name = "EditQuoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditQuoteForm";
            this.Load += new System.EventHandler(this.EditQuoteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbxAuthorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbxQuoteText;
        private System.Windows.Forms.Label label2;
    }
}