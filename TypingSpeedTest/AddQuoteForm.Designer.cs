namespace TypingSpeedTest {
    partial class AddQuoteForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuoteForm));
            this.tbxQuoteText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAuthorName = new System.Windows.Forms.RichTextBox();
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxQuoteText
            // 
            this.tbxQuoteText.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuoteText.Location = new System.Drawing.Point(12, 51);
            this.tbxQuoteText.Name = "tbxQuoteText";
            this.tbxQuoteText.Size = new System.Drawing.Size(373, 96);
            this.tbxQuoteText.TabIndex = 0;
            this.tbxQuoteText.Text = "";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type the quote here:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name of Author:";
            // 
            // tbxAuthorName
            // 
            this.tbxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAuthorName.Location = new System.Drawing.Point(163, 183);
            this.tbxAuthorName.Name = "tbxAuthorName";
            this.tbxAuthorName.Size = new System.Drawing.Size(222, 29);
            this.tbxAuthorName.TabIndex = 6;
            this.tbxAuthorName.Text = "";
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddQuote.FlatAppearance.BorderSize = 3;
            this.btnAddQuote.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(246, 241);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(139, 31);
            this.btnAddQuote.TabIndex = 8;
            this.btnAddQuote.Text = "Add Quote";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            this.btnAddQuote.Click += new System.EventHandler(this.btnAddQuote_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(101, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 31);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "*Make sure there are no newlines*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(397, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddQuote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAuthorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxQuoteText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(413, 323);
            this.MinimumSize = new System.Drawing.Size(413, 0);
            this.Name = "AddQuoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddQuoteForm";
            this.Load += new System.EventHandler(this.AddQuoteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbxQuoteText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbxAuthorName;
        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
    }
}