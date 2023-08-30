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
    public partial class QuoteEditorForm : Form {
        public static QuoteEditorForm instance;
        public ListBox listBox;
        private DataManager _dataManager = new DataManager();
        private List<Quote> _quoteList = new List<Quote>();
        public QuoteEditorForm() {
            InitializeComponent();
            instance = this;
            listBox = listBoxQuotes;
        }

        private void QuoteEditorForm_Load(object sender, EventArgs e) {
            PopulateQuotes();
        }

        private void PopulateQuotes() {
            if (listBoxQuotes.Items.Count > 0) {
                listBoxQuotes.Items.Clear();
            }
            _quoteList = _dataManager.GetQuoteList();
            for (int i = 0; i < _quoteList.Count; i++) {
                listBoxQuotes.Items.Add(i + 1 + ". " + _quoteList[i].Text + " - " + _quoteList[i].Author);
            }
        }

        private void btnAddQuote_Click(object sender, EventArgs e) {
            var addQuoteForm = new AddQuoteForm();
            addQuoteForm.ShowDialog();
        }

        private void btnEditQuote_Click(object sender, EventArgs e) {
            if (listBoxQuotes.SelectedIndex != -1) {
                listBox = listBoxQuotes;
                var editQuoteForm = new EditQuoteForm();
                editQuoteForm.ShowDialog();
            } else {
                MessageBox.Show("Please select a quote to edit.", "Must Select Quote To Edit");
            }
        }

        private void btnRemoveQuote_Click(object sender, EventArgs e) {
            int selectedQuoteIndex = listBoxQuotes.SelectedIndex;
            if (selectedQuoteIndex != -1) {
                string message = "Are you sure that you would like to remove this quote?";
                string caption = "Remove Quote";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes) {
                    bool removed = _dataManager.RemoveQuote(selectedQuoteIndex);
                    if (removed) {
                        listBoxQuotes.Items.RemoveAt(selectedQuoteIndex);
                        MessageBox.Show("Quote was successfully removed.", "Remove Successful");
                    } else {
                        MessageBox.Show("Could not remove quote.", "Remove Failed");
                    }
                }
            } else {
                MessageBox.Show("Please select a quote to remove.", "Must Select A Quote To Remove");
            }
        }

        private void QuoteEditorForm_FormClosing(object sender, FormClosingEventArgs e) {
            TypingTestForm.instance.backFromEditor = true;
        }
    }
}
