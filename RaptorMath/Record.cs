//==============================================================//
//					       Record.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Kyle Bridges and Harvey Kreitzer                    //
// Purpose: This class creates a Record object that contains    //
//          all pertinent data required to fill it.             //
//==============================================================//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaptorMath
{
    //------------------------------------------------------------------//
    // Kyle Bridges                                                     //
    // Date: 2/24/2014                                                  //
    //------------------------------------------------------------------//
    public class Record
    {
        private string dateTaken;
        private string question;
        private string rangeStart;
        private string rangeEnd;
        private string operation;
        private string wrong;
        private string percent;
        private string skipped;

        public string DateTaken
        {
            get { return this.dateTaken; }
            set { this.dateTaken = value; }
        }

        public string Question
        {
            get { return this.question; }
            set { this.question = value; }
        }

        public string RangeStart
        {
            get { return this.rangeStart; }
            set { this.rangeStart = value; }
        }

        public string RangeEnd
        {
            get { return this.rangeEnd; }
            set { this.rangeEnd = value; }
        }

        public string Operation
        {
            get { return this.operation; }
            set { this.operation = value; }
        }

        public string Wrong
        {
            get { return this.wrong; }
            set { this.wrong = value; }
        }

        public string Percent
        {
            get { return this.percent; }
            set { this.percent = value; }
        }

        public string Skipped
        {
            get { return this.skipped; }
            set { this.skipped = value; }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/24/2014                                                  //
        //------------------------------------------------------------------//
        public Record()
        {
            dateTaken = "Unknown";
            question = "0";
            rangeStart = "0";
            rangeEnd = "0";
            operation = "Unknown";
            wrong = "0";
            percent = "0";
            skipped = "0";
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/24/2014                                                  //
        //------------------------------------------------------------------//
        public Record(string stDate, string stQuestion, string stRngStrt, string stRngEnd,
                      string stOp, string stWrong, string stPercent, string stSkipped)
        {
            dateTaken = stDate;
            question = stQuestion;
            rangeStart = stRngStrt;
            rangeEnd = stRngEnd;
            operation = stOp;
            wrong = stWrong;
            percent = stPercent;
            skipped = stSkipped;
        }
    }
}
