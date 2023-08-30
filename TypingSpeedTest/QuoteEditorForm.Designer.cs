namespace TypingSpeedTest {
    partial class QuoteEditorForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuoteEditorForm));
            this.listBoxQuotes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.btnRemoveQuote = new System.Windows.Forms.Button();
            this.btnEditQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxQuotes
            // 
            this.listBoxQuotes.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxQuotes.FormattingEnabled = true;
            this.listBoxQuotes.HorizontalScrollbar = true;
            this.listBoxQuotes.ItemHeight = 17;
            this.listBoxQuotes.Location = new System.Drawing.Point(12, 35);
            this.listBoxQuotes.Name = "listBoxQuotes";
            this.listBoxQuotes.Size = new System.Drawing.Size(776, 361);
            this.listBoxQuotes.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(776, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quote List:";
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddQuote.FlatAppearance.BorderSize = 3;
            this.btnAddQuote.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(12, 409);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(255, 31);
            this.btnAddQuote.TabIndex = 5;
            this.btnAddQuote.Text = "Add Quote";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            this.btnAddQuote.Click += new System.EventHandler(this.btnAddQuote_Click);
            // 
            // btnRemoveQuote
            // 
            this.btnRemoveQuote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveQuote.FlatAppearance.BorderSize = 3;
            this.btnRemoveQuote.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveQuote.Location = new System.Drawing.Point(533, 409);
            this.btnRemoveQuote.Name = "btnRemoveQuote";
            this.btnRemoveQuote.Size = new System.Drawing.Size(255, 31);
            this.btnRemoveQuote.TabIndex = 6;
            this.btnRemoveQuote.Text = "Remove Quote";
            this.btnRemoveQuote.UseVisualStyleBackColor = true;
            this.btnRemoveQuote.Click += new System.EventHandler(this.btnRemoveQuote_Click);
            // 
            // btnEditQuote
            // 
            this.btnEditQuote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditQuote.FlatAppearance.BorderSize = 3;
            this.btnEditQuote.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQuote.Location = new System.Drawing.Point(273, 409);
            this.btnEditQuote.Name = "btnEditQuote";
            this.btnEditQuote.Size = new System.Drawing.Size(255, 31);
            this.btnEditQuote.TabIndex = 7;
            this.btnEditQuote.Text = "Edit Quote";
            this.btnEditQuote.UseVisualStyleBackColor = true;
            this.btnEditQuote.Click += new System.EventHandler(this.btnEditQuote_Click);
            // 
            // QuoteEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditQuote);
            this.Controls.Add(this.btnRemoveQuote);
            this.Controls.Add(this.btnAddQuote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxQuotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuoteEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quote Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuoteEditorForm_FormClosing);
            this.Load += new System.EventHandler(this.QuoteEditorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxQuotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.Button btnRemoveQuote;
        private System.Windows.Forms.Button btnEditQuote;
    }
}