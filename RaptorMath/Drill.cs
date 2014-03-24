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
        private string drillSet;
        private string curQuestions;
        private string curRangeStart;
        private string curRangeEnd;
        private string curOperand;
        private string curWrong;
        public string curSkipped;
        public string curPercent;

        public string DrillSet
        {
            get { return this.drillSet; }
            set { this.drillSet = value; }
        }

        public string CurQuestions
        {
            get { return this.curQuestions; }
            set { this.curQuestions = value; }
        }

        public string CurRangeStart
        {
            get { return this.curRangeStart; }
            set { this.curRangeStart = value; }
        }

        public string CurRangeEnd
        {
            get { return this.curRangeEnd; }
            set { this.curRangeEnd = value; }
        }

        public string CurOperand
        {
            get { return this.curOperand; }
            set { this.curOperand = value; }
        }

        public string CurWrong
        {
            get { return this.curWrong; }
            set { this.curWrong = value; }
        }

        public string CurSkipped
        {
            get { return this.curSkipped; }
            set { this.curSkipped = value; }
        }

        public string CurPercent
        {
            get { return this.curPercent; }
            set { this.curPercent = value; }
        }

        public Drill()
        {
            curQuestions = "0";
            curRangeStart = "0";
            curRangeEnd = "0";
            curOperand = "Unknown";
            curWrong = "0";
            curSkipped = "0";
            curPercent = "0";
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public void IncrementWrong()
        {
            int wrong = Convert.ToInt32(curWrong);
            wrong++;
            curWrong = wrong.ToString();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public void IncrementSkipped()
        {
            int skipped = Convert.ToInt32(curSkipped);
            skipped++;
            curSkipped = skipped.ToString();
        }

        public void Reset()
        {
            curSkipped = "0";
            curWrong = "0";
            curPercent = "0";
        }
    }
}
