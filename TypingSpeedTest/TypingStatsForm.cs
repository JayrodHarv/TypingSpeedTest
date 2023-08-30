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
using System.Windows.Forms.VisualStyles;

namespace TypingSpeedTest {
    public partial class TypingStatsForm : Form {
        private DataManager _dataManager = new DataManager();
        public TypingStatsForm() {
            InitializeComponent();
            CreateStatsTable();
        }

        public void CreateStatsTable() {
            List<Test> testList = _dataManager.GetTestList();
            Font font = new Font(FontFamily.GenericSansSerif, 19, GraphicsUnit.Pixel);
            TableLayoutPanel tblStats = new TableLayoutPanel();
            tblStats.AutoSize = true;
            tblStats.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tblStats.ColumnCount = 3;
            tblStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tblStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            Label wpmLabel = new Label();
            wpmLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            wpmLabel.Font = font;
            wpmLabel.AutoSize = false;
            wpmLabel.Text = "Words Per Minute";
            wpmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            tblStats.Controls.Add(wpmLabel, 0, 0);
            Label wordsLabel = new Label();
            wordsLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            wordsLabel.Font = font;
            wordsLabel.AutoSize = false;
            wordsLabel.Text = "Number Of Words";
            wordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            tblStats.Controls.Add(wordsLabel, 1, 0);
            Label secondsLabel = new Label();
            secondsLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            secondsLabel.Font = font;
            secondsLabel.AutoSize = false;
            secondsLabel.Text = "Elapsed Time In Seconds";
            secondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            tblStats.Controls.Add(secondsLabel, 2, 0);

            for (int i = 0; i < testList.Count; i++) {
                Label wpm = new Label();
                wpm.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                wpm.Font = font;
                wpm.AutoSize = false;
                wpm.Text = testList[testList.Count - i - 1].WPM.ToString();
                wpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                tblStats.Controls.Add(wpm, 0, i + 1);
                Label words = new Label();
                words.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                words.Font = font;
                words.AutoSize = false;
                words.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                words.Text = testList[testList.Count - i - 1].NumOfWords.ToString();
                tblStats.Controls.Add(words, 1, i + 1);
                Label seconds = new Label();
                seconds.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                seconds.Font = font;
                seconds.AutoSize = false;
                seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                seconds.Text = testList[testList.Count - i - 1].ElapsedTimeInSeconds.ToString();
                tblStats.Controls.Add(seconds, 2, i + 1);
            }
            tblStats.Location = new Point(15, 50);
            tblStats.Name = "tblStats";
            tblStats.RowCount = testList.Count + 1;
            for (int i = 0; i < tblStats.RowCount; i++) {
                tblStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            }
            tblStats.Size = new Size(905, testList.Count * 32);
            tblStats.TabIndex = 2;
            tblStats.SuspendLayout();
            Controls.Add(tblStats);
        }
    }
}
