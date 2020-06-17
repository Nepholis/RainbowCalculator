using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace RechnerV1
{
    /// <summary>
    /// Seperates one String into a StringList with decimal values in it
    /// </summary>
    public class SeparatedList
    {
        public List<string> stringList = new List<string> { };
        public SeparatedList(string s)
        {
            foreach (Char c in s)
            {
                stringList.Add(c.ToString());
            }
            for(int i = 0; i< stringList.Count - 1; i++)
            {
                try
                {
                    int t = i;
                    while (t< stringList.Count &&
                        stringList[t] != "+" && stringList[t+1] != "+" &&
                        stringList[t] != "-" && stringList[t+1] != "-" &&
                        stringList[t] != "*" && stringList[t+1] != "*" &&
                        stringList[t] != "/" && stringList[t+1] != "/" &&
                        stringList[t] != "(" && stringList[t+1] != "("&&
                        stringList[t] != ")" && stringList[t+1] != ")")
                    {
                        stringList[t] = stringList[t] + stringList[t+1];
                        stringList.RemoveAt(t + 1);
                    }
                }
                catch { }
            }
        }
        /// <summary>
        /// returns a seperated String List
        /// </summary>
        public List<string> getStrings()
        {
            return this.stringList;
        }

        /// <summary>
        /// returns true if Calculations was invalid
        /// </summary>
        public bool detectWrongInput()
        {
            bool b = false;
            int t = 0;
            for (int i = 0; i < stringList.Count; i++)
            {
                string s1 = stringList[i];
                try
                {
                    string s2 = stringList[i + 1];
                    if (s1 == s2 && s1 != "(" && s1 != ")")     //for Errors like ++
                    {
                        b = true;
                    }
                }
                catch { }
                
                if (s1 == "(") { t++; }
                else if (s1 == ")") { t--; }

                if (t < 0) { MessageBox.Show("To much Rightbrackets: e.g. Index" + i); b = true; break; }
            }

            if (t > 0) { MessageBox.Show("To much Leftbrackets!"); b = true; }
            else if (t == 0) { b = false; }
            return b;
        }

        /// <summary>
        /// Gives index of the Next Calculation >> Number a
        /// </summary>
        public int showNextClac(List<string> sl)
        {
            int index=1;
            try
            {
                index = deepestBracket(sl)+1;
            }
            catch { }
            int start = index;
            for (int i = start; i< sl.Count; i++)
            {
                if (strIsDigit(sl[i]) == true && sl[i-1] =="(" && sl[i+1] == ")") // checks "(number)" and deletes Brackets
                {
                    sl.RemoveAt(i + 1);
                    sl.RemoveAt(i - 1);
                    try
                    {
                        if (strIsDigit(sl[i - 2]) == true)
                        {
                            sl.Insert(i - 1, "*");
                            index = i - 1;
                            return index;
                        }
                    }
                    catch { }

                    index = i - 2;
                    return index;
                }
                else if (strIsDigit(sl[i-1]) == true && (sl[i] == "*" || sl[i] == "/"))
                {
                    index = i-1;
                    return index;
                }
                else if (strIsDigit(sl[i]) == true && strIsDigit(sl[i + 2]) == true)
                {
                    index = i + 1;
                    return index;
                }
            }
            return index;
        }
        public bool strIsDigit(string s)
        {
            char c = s[0];
            bool b = Char.IsDigit(c);
            return b; 
        }
        public int deepestBracket(List<string> sl)
        {
            int current_max = 0; // current count 
            int max = 0;    // overall maximum count 

            // Traverse the input string 
            for (int i = 0; i < sl.Count; i++)
            {
                if (sl[i] == "(")
                {
                    current_max++;

                    // update max if required 
                    if (current_max > max)
                        max = current_max;
                }
                else if (sl[i] == ")")
                {
                    if (current_max > 0)
                        current_max--;
                }
            }
            int index = 0;
            int temp = max;
            for (int i = 0; i < sl.Count; i++)
            {
                if (sl[i] == "(" && max > 0)
                {
                    temp--;
                    index = i;
                }
            }
            return index;
        }
    }
}
