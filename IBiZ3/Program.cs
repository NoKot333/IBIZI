using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

namespace IBiZ3
{
    internal static class Program
    {
        public static char[,] create_Square(string key,int num_cols){
            string ABC = "¿¡¬√ƒ≈®∆«»… ÀÃÕŒœ–—“”‘’÷◊ÿŸ€‹⁄›ﬁﬂ";
            if(num_cols <= 0) { num_cols = 1; }
            int num_rows = (int)Math.Ceiling((double)ABC.Length / num_cols);
            char[,] string_square = new char[num_rows,num_cols];
            key = key.ToUpper();
            ABC = key + string.Join("",ABC.Split(key.ToCharArray()));
            for (int i =0; i < ABC.Length; i++)
            {
                string_square[i/num_cols,i%num_cols] = ABC[i];
            }
            return string_square;
        }
        
        public static string EncodeString(string init_text, char[,] square)
        {
            string encodedString = "";
            bool found = false;
            foreach (char litter in init_text)
            {
                found = false;
                for (int i = 0; i < square.GetLength(0); i++)
            {
                for (int j = 0; j < square.GetLength(1); j++)
                {
                    if (square[i, j] == litter)
                    {
                        if ( (i + 1  < square.GetLength(0)) )
                            {
                                if (square[i+1,j] != '\0')
                                {
                                    encodedString += square[i+1,j];
                                } else
                                {
                                    encodedString += square[0, j];
                                }
                            } else
                            {
                                encodedString += square[0, j];
                            }
                        found = true;
                            break;
                    }
                }
                if (found)
                    {
                        break;
                    }
            }
            }
            
            return encodedString;
        }

        public static string DecodeString(string init_text, char[,] square)
        {
            string decodedString = "";
            foreach (char litter in init_text)
            {
                for (int i = 0; i < square.GetLength(0); i++)
                {
                    for (int j = 0; j < square.GetLength(1); j++)
                    {
                        if (square[i, j] == litter)
                        {
                            if (i != 0)
                            {
                                decodedString += square[i-1, j];
                            }
                            else if (square[square.GetLength(0) - 1, j] == '\0') 
                            { 
                                decodedString += square[square.GetLength(0) - 2, j];
                            } 
                            else
                            {
                                decodedString += square[square.GetLength(0)-1, j];
                            }
                        }
                    }
                }
            }

            return decodedString;
        }
        /*

        
        public static void addPos(char litter, List<int> list)
        {
            for (int i = 0; i < GetSquare().GetLength(0); i++)
            {
                for(int j = 0; j < GetSquare().GetLength(1); j++)
                {
                    if (GetSquare()[i,j] == litter)
                    {
                        list.Add(i);
                        list.Add(j);
                        return;
                    }
                }
            }
            list.Add(-1);
            list.Add(-1);
        }

        public static char GetCharByPos(int pos1, int pos2)
        {
            return GetSquare()[pos1, pos2];
        }
        /*
        public static string FromListToString(List<int> encodedString)
        {
            string final_string = "";
            foreach (int elem in encodedString)
            {
                final_string += Convert.ToString(elem) + " ";
            }
            return final_string.TrimEnd();
        }
        public static string CoordToString(List<int[]> coords)
        {
            string msg = "";
            foreach (int[] arr in coords)
            {

            }
            return msg;
        }
        public static string DecodeString(List<int> init_arr)
        {
            string final_text = "";
            for (int i = 0; i < init_arr.Count; i+=2)
            {
                final_text += GetCharByPos(init_arr[i], init_arr[i+1]);
            }
            return final_text;
            
        }
        public static List<int> invertArr(List<int> list) 
        {
            int temp = 0;
            for (int i = 0; i < list.Count; i+=2) 
            {
                temp = list[i];
                list[i] = list[i+1];
                list[i+1] = temp;
            }
            return list;
        }
        public static List<int> LshiftArr(List<int> listOfArrs)
        {
            int temp = listOfArrs[0];
            for (int i = 0;i < listOfArrs.Count()-1;i++)
            {
                listOfArrs[i] = listOfArrs[i+1];
            }
            listOfArrs[listOfArrs.Count()-1] = temp;
            return listOfArrs;
        }
        public static List<int> RshiftArr(List<int> listOfArrs)
        {
            int temp = listOfArrs[listOfArrs.Count-1];
            for (int i = listOfArrs.Count-1; i > 0; i--)
            {
                listOfArrs[i] = listOfArrs[i - 1];
            }
            listOfArrs[0] = temp;
            return listOfArrs;
        }
        public static List<int> DshiftArr(List<int> listOfArrs) 
        {
            for (int i = 0; i < listOfArrs.Count;i+=2)
            {
                if (listOfArrs[i] +1 < GetSquare().GetLength(0))
                {
                    listOfArrs[i]++;
                }
                else
                {
                    listOfArrs[i] = 0;
                }
            }
            return listOfArrs;
        }
        public static List<int> UshiftArr(List<int> listOfArrs)
        {
            for (int i = 0; i < listOfArrs.Count; i += 2)
            {
                if (listOfArrs[i] > 0)
                {
                    listOfArrs[i]--;
                }
                else
                {
                    listOfArrs[i] = GetSquare().GetLength(0)-1;
                }
            }
            return listOfArrs;
        }
        */
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
    }
}