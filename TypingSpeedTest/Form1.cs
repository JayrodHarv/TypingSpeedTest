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
    public partial class Form1 : Form {
        private DataManager _dataManager = new DataManager();
        private DateTime start;
        private DateTime end;
        private Quote currentQuote;
        char[] quoteChars;
        public Form1() {
            InitializeComponent();
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
            currentQuote = _dataManager.GetNewQuote();
            quoteChars = currentQuote.Text.ToCharArray();
            lblQuote.Text = currentQuote.Text;
            lblWPM.Text = Convert.ToString(_dataManager.GetPreviousTest().WPM);
            lblAuthor.Text = currentQuote.Author;
        }

        private void tbxInput_TextChanged(object sender, EventArgs e) {
            char[] inputChars = tbxInput.Text.ToCharArray();
            if (inputChars.Length == 1) { // starts "timer" when user starts typing
                start = DateTime.Now;
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

        private void btnViewStats_Click(object sender, EventArgs e) {
            var statsForm = new Form2();
            statsForm.ShowDialog();
        }
    }
}
