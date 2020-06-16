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
                        stringList[t] != "/" && stringList[t+1] != "/")
                    {
                        stringList[t] = stringList[t] + stringList[t+1];
                        stringList.RemoveAt(t + 1);
                    }
                }
                catch(Exception)
                {
                    
                }
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
            for (int i = 0; i <= stringList.Count; i++)
            {
                string s1 = stringList[i];
                string s2 = stringList[i +1];

                if (s1 == s2)     //for Errors like ++
                {
                    b = true;
                }
            }
            return b;
        }

        /// <summary>
        /// Gives index of the Next Calculation >> Number a
        /// </summary>
        public int showNextClac(List<string> sl)
        {
            int index=1;
            for (int i = 0; i< sl.Count; i++)
            {
                if (sl[i] == "*" || sl[i] == "/")
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
