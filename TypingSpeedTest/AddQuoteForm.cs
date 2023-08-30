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
    public partial class AddQuoteForm : Form {
        DataManager _dataManager = new DataManager();
        List<Quote> _quoteList = new List<Quote>();
        public AddQuoteForm() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAddQuote_Click(object sender, EventArgs e) {
            if (tbxQuoteText.Text.Length > 0 && tbxAuthorName.Text.Length > 0) {
                _quoteList = _dataManager.GetQuoteList();
                Quote quote = new Quote();
                quote.Text = tbxQuoteText.Text;
                quote.Author = tbxAuthorName.Text;
                _dataManager.AddQuote(quote, _quoteList.Count);
                QuoteEditorForm.instance.listBox.Items.Add(_quoteList.Count + ". " + quote.Text + " - " + quote.Author);
                Close();
            } else {
                MessageBox.Show("Please enter both the text and the author into the textboxes. If you don't know the author, just enter anonymous.");
            }
        }

        private void AddQuoteForm_Load(object sender, EventArgs e) {
            _quoteList = _dataManager.GetQuoteList();
        }
    }
}
