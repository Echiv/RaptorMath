//==============================================================//
//					        Drill.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Kyle Bridges and Harvey Kreitzer                    //
// Purpose: This class creates a Drill object that contains     //
//          all pertinent data along with functions that        //
//          increment the total questions wrong and skipped.    //
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
    // Date: 2/26/2014                                                  //
    //------------------------------------------------------------------//
    public class Drill
    {
        private int id;
        private string drillName;
        private string questions;
        private string rangeStart;
        private string rangeEnd;
        private string operand;
        private string wrong;
        public string skipped;
        public string percent;

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string DrillName
        {
            get { return this.drillName; }
            set { this.drillName = value; }
        }

        public string Questions
        {
            get { return this.questions; }
            set { this.questions = value; }
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

        public string Operand
        {
            get { return this.operand; }
            set { this.operand = value; }
        }

        public string Wrong
        {
            get { return this.wrong; }
            set { this.wrong = value; }
        }

        public string Skipped
        {
            get { return this.skipped; }
            set { this.skipped = value; }
        }

        public string Percent
        {
            get { return this.percent; }
            set { this.percent = value; }
        }

        public Drill()
        {
            drillName = "Unknown";
            questions = "0";
            rangeStart = "0";
            rangeEnd = "0";
            operand = "Unknown";
            wrong = "0";
            skipped = "0";
            //curPercent = "0";
        }

        public Drill(string driName, string numQuestions, string start, string end, string op)
        {
            drillName = driName;
            questions = numQuestions;
            rangeStart = start;
            rangeEnd = end;
            operand = op;
            wrong = "0";
            skipped = "0";
            percent = "0";
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public void IncrementWrong()
        {
            int numWrong = Convert.ToInt32(wrong);
            numWrong++;
            wrong = numWrong.ToString();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public void IncrementSkipped()
        {
            int numSkipped = Convert.ToInt32(skipped);
            numSkipped++;
            skipped = numSkipped.ToString();
        }

        public void Reset()
        {
            skipped = "0";
            wrong = "0";
            percent = "0";
        }
    }
}
