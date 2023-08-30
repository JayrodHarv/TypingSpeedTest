using DataObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccess {
    public class DataAccessor {

        public static List<Quote> GetQuoteList() {
            List<Quote> quoteList = new List<Quote>();
            if (QuoteFileExists()) {
                try {
                    StreamReader fileReader = new StreamReader(AppData.DataPath + @"\" + AppData.QuoteListFileName);
                    while (fileReader.EndOfStream == false) {
                        Quote quote = new Quote();
                        string line = fileReader.ReadLine();
                        string[] parts = line.Split('\t');
                        if (parts.Length == 2) {
                            quote.Text = parts[0];
                            quote.Author = parts[1];
                        } else {
                            quote.Text = line;
                        }
                        quoteList.Add(quote);
                    }
                    fileReader.Close();
                } catch (Exception) {
                    throw;
                }
            }
            return quoteList;
        }

        public static bool UpdateQuoteList(List<Quote> quoteList) {
            bool result = false;
            try {
                string path = AppData.DataPath + @"\" + AppData.QuoteListFileName;
                if(QuoteFileExists()) {
                    File.Delete(path);
                }
                StreamWriter sw = File.AppendText(path); // writes to file if it exists; creates new file if it doesn't
                for (int i = 0; i < quoteList.Count; i++) {
                    if (i == 0) {
                        sw.Write(quoteList[i].Text + "\t" + quoteList[i].Author);
                    } else {
                        sw.Write("\n" + quoteList[i].Text + "\t" + quoteList[i].Author);
                    }
                }
                sw.Close();
                result = true;
            } catch (Exception ex) {
                throw ex;
            }
            return result;
        }

        public static void AddTest(Test test) {
            try {
                string path = AppData.DataPath + @"\" + AppData.TestDataFileName;
                bool fileExisted = TestFileExists();
                StreamWriter sw = File.AppendText(path); // writes to file if it exists; creates new file if it doesn't
                if (!fileExisted) {
                    sw.Write(test.WPM + "\t" + test.NumOfWords + "\t" + test.ElapsedTimeInSeconds);
                } else {
                    sw.Write("\n" + test.WPM + "\t" + test.NumOfWords + "\t" + test.ElapsedTimeInSeconds);
                }
                sw.Close();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public static List<Test> GetTestList() {
            List<Test> testList = new List<Test>();
            char[] separator = { '\t' };
            if (TestFileExists()) {
                try {
                    StreamReader fileReader = new StreamReader(AppData.DataPath + @"\" + AppData.TestDataFileName);
                    while (fileReader.EndOfStream == false) {
                        string line = fileReader.ReadLine();
                        string[] parts = line.Split(separator);
                        if (parts.Length == 3) {
                            Test test = new Test();
                            test.WPM = Convert.ToInt32(parts[0]);
                            test.NumOfWords = Convert.ToInt32(parts[1]);
                            test.ElapsedTimeInSeconds = Convert.ToInt32(parts[2]);
                            testList.Add(test);
                        }
                    }
                    fileReader.Close();
                } catch (Exception) {
                    throw;
                }
            }
            return testList;
        }

        public static bool DeleteTestFile() {
            bool deleted;

            if (TestFileExists()) {
                try {
                    string path = AppData.DataPath + @"\" + AppData.TestDataFileName;
                    File.Delete(path);
                    deleted = true;
                } catch (Exception ex) {

                    throw ex;
                }
            } else {
                deleted = true;
            }
            return deleted;
        }

        public static bool TestFileExists() {
            bool exists = false;
            string path = AppData.DataPath + @"\" + AppData.TestDataFileName;
            if (File.Exists(path)) {
                exists = true;
            }
            return exists;
        }

        public static bool QuoteFileExists() {
            bool exists = false;
            string path = AppData.DataPath + @"\" + AppData.QuoteListFileName;
            if (File.Exists(path)) {
                exists = true;
            }
            return exists;
        }

    }
}
