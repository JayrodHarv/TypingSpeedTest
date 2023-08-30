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
using System.Windows.Forms.Design;

namespace TypingSpeedTest {
    public partial class Form2 : Form {
        private DataManager _dataManager = new DataManager();
        public Form2() {
            InitializeComponent();
            CreateStatsTable();
        }

        public void CreateStatsTable() {
            List<Test> testList = _dataManager.GetTestList();
            TableLayoutPanel tblStats = new TableLayoutPanel();
            tblStats.AutoSize = true;
            tblStats.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tblStats.ColumnCount = 3;
            tblStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tblStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));

            for (int i = 0; i < testList.Count; i++) {
                Label wpm = new Label();
                wpm.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                wpm.Font = new Font(FontFamily.GenericSansSerif, 12);
                wpm.AutoSize = false;
                wpm.Text = testList[testList.Count - i - 1].WPM.ToString();
                wpm.TextAlign = ContentAlignment.MiddleCenter;
                tblStats.Controls.Add(wpm, 0, i);
                Label words = new Label();
                words.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                words.Font = new Font(FontFamily.GenericSansSerif, 12);
                words.AutoSize = false;
                words.TextAlign = ContentAlignment.MiddleCenter;
                words.Text = testList[testList.Count - i - 1].NumOfWords.ToString();
                tblStats.Controls.Add(words, 1, i);
                Label seconds = new Label();
                seconds.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                seconds.Font = new Font(FontFamily.GenericSansSerif, 12);
                seconds.AutoSize = false;
                seconds.TextAlign = ContentAlignment.MiddleCenter;
                seconds.Text = testList[testList.Count - i - 1].ElapsedTimeInSeconds.ToString();
                tblStats.Controls.Add(seconds, 2, i);
            }
            tblStats.Location = new Point(16, 32);
            tblStats.Name = "tblStats";
            tblStats.RowCount = testList.Count;
            for (int i = 0; i < tblStats.RowCount; i++) {
                tblStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            }
            tblStats.Size = new Size(772, testList.Count * 32);
            tblStats.TabIndex = 2;
            tblStats.SuspendLayout();
            Controls.Add(tblStats);
        }

        private void Form2_Load(object sender, EventArgs e) {
            DisplayTests();
        }

        private void DisplayTests() {
            List<Test> testList = _dataManager.GetTestList();
            for (int i = testList.Count - 1; i > 0; i--) {
                // tblStats.Controls.Add(new Label());
            }
        }
    }
}
