using DataObjects;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingSpeedTest {
    public partial class TypingTestForm : Form {
        public static TypingTestForm instance;
        private DataManager _dataManager = new DataManager();
        private DateTime start;
        private DateTime end;
        private Quote currentQuote;
        public bool backFromEditor = false;
        char[] quoteChars;
        double seconds = 0;
        public TypingTestForm() {
            InitializeComponent();
            instance = this;
        }

        private void Form1_Load(object sender, EventArgs e) {
            StartTest();
        }

        private void EndTest() {
            end = DateTime.Now;
            _dataManager.produceTestResults(start, end, currentQuote.Text);
            StartTest();
        }

        private void StartTest() {
            tbxInput.Text = "";
            currentQuote = _dataManager.GetRandomQuote();
            quoteChars = currentQuote.Text.ToCharArray();
            lblQuote.Text = currentQuote.Text;
            lblWPM.Text = "Previous Test WPM: " + _dataManager.GetPreviousTest().WPM.ToString();
            lblAuthor.Text = "- " + currentQuote.Author;
            lblAverageWPM.Text = "Average WPM: " + _dataManager.CalculateAverageWPM().ToString();
            lblFastestWPM.Text = "Fastest WPM: " + _dataManager.GetFastestWPM().ToString();
            lblSlowestWPM.Text = "Slowest WPM: " + _dataManager.GetSlowestWPM().ToString();
            seconds = 0;
            timer1.Enabled = false;
            lblTimeElapsed.Text = "";
            lblHint.Visible = true;
        }

        private void tbxInput_TextChanged(object sender, EventArgs e) {
            char[] inputChars = tbxInput.Text.ToCharArray();
            if (inputChars.Length == 1) {
                start = DateTime.Now;
                timer1.Enabled = true;
                lblHint.Visible = false;
            }
            if (determineCorrectness(inputChars, quoteChars)) {
                lblQuote.ForeColor = Color.Black;
            } else {
                lblQuote.ForeColor = Color.Red;
            }
        }

        private bool determineCorrectness(char[] inputChars, char[] quoteChars) {
            int incorrect = 0;
            bool complete = false;
            for (int i = 0; i < inputChars.Length; i++) {
                if (inputChars.Length <= quoteChars.Length) {
                    if (inputChars[i] != quoteChars[i]) {
                        incorrect++;
                    } else {
                        if (inputChars.Length == quoteChars.Length) {
                            complete = true;
                        }
                    }
                } else {
                    return false;
                }
            }

            if (complete && incorrect == 0) {
                EndTest();
                return true;
            } else {
                if (incorrect > 0) {
                    return false;
                } else {
                    return true;
                }
            }
        }

        private void TypingTestForm_Activated(object sender, EventArgs e) {
            if (backFromEditor) {
                StartTest();
                backFromEditor = false;
            }
        }

        private void tsmViewTests_Click(object sender, EventArgs e) {
            var statsForm = new TypingStatsForm();
            statsForm.ShowDialog();
        }

        private void tsmClearTests_Click(object sender, EventArgs e) {
            string message = "Are you sure that you would like to delete all previous typing tests?";
            string caption = "Clear All Previous Tests";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes) {
                bool deleted = _dataManager.DeleteTests();
                if (deleted) {
                    lblWPM.Text = "Previous Test WPM: 0";
                    lblAverageWPM.Text = "Average WPM: 0";
                    lblFastestWPM.Text = "Fastest WPM: 0";
                    lblSlowestWPM.Text = "Slowest WPM: 0";
                    MessageBox.Show("All tests have successfully been deleted.", "Cleared All Previous Tests");
                } else {
                    MessageBox.Show("There were no tests to clear.", "Clearing Tests Failed");
                }
            }
        }

        private void tsmEditQuotes_Click(object sender, EventArgs e) {
            var quoteEditor = new QuoteEditorForm();
            quoteEditor.ShowDialog();
        }

        private void tsmChangeQuote_Click(object sender, EventArgs e) {
            StartTest();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            seconds += 0.1;
            lblTimeElapsed.Text = Math.Round(seconds, 1).ToString();
        }
    }
}
