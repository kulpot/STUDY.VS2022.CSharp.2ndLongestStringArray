using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//          Psuedo Code
//Gets the second longest string in a string array.
//Accepts a string array and returns a string representing
//the second longest string. Use params to accept differents
//sets of strings.

//METHOD GetSecondLongestString accepts strings
//  SET longestString as empty
//  SET secondLongest as empty

//  Get longest string
//      for each string in string array
//          IF iterated string is longer than longestString THEN
//              SET longestString as iterated string

//  Get second longest string
//      for each string in string array
//          IF iterated string is longer than secondLongestString THEN
//              IF iterated string is not equal to longestString THEN
//              SET secondLongestString as iterated string
//  RETURN secondLongestString
//END METHOD


namespace _2ndLongestStringArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = GetSecondLongestString("efeggef", "ffrf", "ededeededededed");
        }

        private string GetSecondLongestString(params string[] stringArray)
        {
            string longestString = string.Empty;
            string secondLongestString = string.Empty;

            foreach (string s in stringArray)
            {
                if(s.Length > longestString.Length)
                {
                    longestString = s;
                }
            }

            foreach (string s in stringArray)
            {
                bool isLongest = s == longestString;

                if (s.Length > secondLongestString.Length && !isLongest)
                {
                    secondLongestString = s;
                }
            }

            return secondLongestString;
        }
    }
}
