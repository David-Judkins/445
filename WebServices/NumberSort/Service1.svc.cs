using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NumberSort
{
        // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
        // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string InsertionSort(string s)
        {
            int[] NumArray = new int[60];
            string tempNum = null;
            string sortedString = null;
            int addIndex = 0;
            int j, target;

            //David Judkins- string of comma separated numbers converted to an array of numbers
            //for insertion sort processing.
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ',' && s[i] != ' ')
                {
                    tempNum += s[i];
                    j = i;
                    if (j < s.Length - 1)
                    {
                        while (s[j + 1] != ',' && s[j + 1] != ' ' && s[j + 1] != '\n')
                        {
                            j++;
                            tempNum += s[j];
                            if (j == s.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    i = j;
                    Int32.TryParse(tempNum, out NumArray[addIndex]);
                    tempNum = null;
                    addIndex++;
                }
            }


            //David Judkins- insertion sort on array of integers
            for (int i = 1; i < NumArray.Length; i++)
            {
                target = NumArray[i];
                j = i - 1;
                while (j >= 0 && NumArray[j] > target)
                {
                    NumArray[j + 1] = NumArray[j];
                    j--;
                }
                NumArray[j + 1] = target;
            }



            for (int i = 0; i < NumArray.Length; i++)
            {
                if (NumArray[i] != 0)
                {
                    sortedString += NumArray[i].ToString() + ", ";
                }

            }
            return sortedString;
        }
    }
}



