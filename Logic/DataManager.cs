using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataObjects;

namespace Logic {
    public class DataManager {

        List<Quote> _quoteList;
        List<Test> _testList;
        Random random = new Random();
        int LETTERS_IN_WORD = 5;
        public DataManager() {
            try {
                _quoteList = DataAccessor.GetQuoteList();
                _testList = DataAccessor.GetTestList();
            }
            catch(Exception ex) {
                throw ex;
            }
        }

        public Quote GetRandomQuote() {
            _quoteList = DataAccessor.GetQuoteList();
            Quote quote = _quoteList[random.Next(_quoteList.Count)];
            return quote;
        }

        public bool RemoveQuote(int index) {
            bool result;
            _quoteList = DataAccessor.GetQuoteList();
            _quoteList.RemoveAt(index);
            try {
                result = DataAccessor.UpdateQuoteList(_quoteList);
            } catch (Exception ex) {

                throw ex;
            }
            return result;
        }

        public bool AddQuote(Quote quote, int index) {
            bool result;
            if(index >= _quoteList.Count) {
                _quoteList.Add(quote);
            } else {
                _quoteList.Insert(index, quote);
            }
            try {
                result = DataAccessor.UpdateQuoteList(_quoteList);
            } catch (Exception ex) {

                throw ex;
            }
            return result;
        }

        public Test GetPreviousTest() {
            _testList = DataAccessor.GetTestList();
            Test test = new Test();
            if (_testList.Count > 0) {
                test = _testList[_testList.Count - 1];
                return test;
            } else {
                return test;
            }
        }

        public bool DeleteTests() {
            bool completed = false;
            try {
                completed = DataAccessor.DeleteTestFile();
            } catch (Exception ex) {

                throw ex;
            }
            return completed;
        }

        public int CalculateAverageWPM() {
            int average = 0;

            if (_testList.Count > 0) {
                foreach (Test test in _testList) {
                    average += test.WPM;
                }
                average = average / _testList.Count;
            }
            return average;
        }

        public List<Test> GetTestList() {
            _testList = DataAccessor.GetTestList();
            return _testList;
        }

        public List<Quote> GetQuoteList() {
            _quoteList = DataAccessor.GetQuoteList();
            return _quoteList;
        }

        public void produceTestResults(DateTime start, DateTime end, string quote) {
            double elapsedTime = end.Subtract(start).TotalSeconds;
            Test test = new Test();
            test.WPM = (int)((quote.Length / LETTERS_IN_WORD) / (elapsedTime / 60));
            test.NumOfWords = GetWordCount(quote);
            test.ElapsedTimeInSeconds = (int)elapsedTime;
            DataAccessor.AddTest(test);
        }

        public int GetFastestWPM() {
            _testList = DataAccessor.GetTestList();
            int fastest = 0;
            if (_testList.Count > 0) {
                foreach (Test test in _testList) {
                    if (test.WPM > fastest) {
                        fastest = test.WPM;
                    }
                }
            }
            return fastest;
        }

        public int GetSlowestWPM() {
            _testList = DataAccessor.GetTestList();
            int slowest = 1000;
            if (_testList.Count > 0) {
                foreach (Test test in _testList) {
                    if (test.WPM < slowest) {
                        slowest = test.WPM;
                    }
                }
            }
            else {
                slowest = 0;
            }
            return slowest;
        }

        public int GetWordCount(string quote) {
            string[] words = quote.Split(' ');
            return words.Length;
        }
    }
}
