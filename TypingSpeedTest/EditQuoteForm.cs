using DataObjects;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingSpeedTest {
    public partial class EditQuoteForm : Form {
        private DataManager _dataManager = new DataManager();
        private List<Quote> _quoteList = new List<Quote>();
        public EditQuoteForm() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnEditQuote_Click(object sender, EventArgs e) {
            int selectedQuoteIndex = QuoteEditorForm.instance.listBox.SelectedIndex;
            if (tbxQuoteText.TextLength > 0 && tbxQuoteText.Text.Length > 0) {
                Quote quote = new Quote();
                quote.Text = tbxQuoteText.Text;
                quote.Author = tbxAuthorName.Text;
                bool removed = _dataManager.RemoveQuote(selectedQuoteIndex);
                bool newAdded = _dataManager.AddQuote(quote, selectedQuoteIndex);
                if (removed && newAdded) {
                    QuoteEditorForm.instance.listBox.Items.RemoveAt(selectedQuoteIndex);
                    QuoteEditorForm.instance.listBox.Items.Insert(selectedQuoteIndex, selectedQuoteIndex + 1 + ". " + _quoteList[selectedQuoteIndex].Text + " - " + _quoteList[selectedQuoteIndex].Author);
                    MessageBox.Show("Quote was successfully edited.", "Edit Successful");
                } else {
                    MessageBox.Show("Could not edit quote.", "Edit Failed");
                }
            } else {
                MessageBox.Show("Please enter both the text and the author into the textboxes. If you don't know the author, just enter anonymous.");
            }
            Close();
        }

        private void EditQuoteForm_Load(object sender, EventArgs e) {
            _quoteList = _dataManager.GetQuoteList();
            tbxQuoteText.Text = _quoteList[QuoteEditorForm.instance.listBox.SelectedIndex].Text;
            tbxAuthorName.Text = _quoteList[QuoteEditorForm.instance.listBox.SelectedIndex].Author;
        }
    }
}
