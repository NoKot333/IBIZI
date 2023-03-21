using System;
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
        public static char[,] create_Square(string key){
            string ABC = "¿¡¬√ƒ≈®∆«»… ÀÃÕŒœ–—“”‘’÷◊ÿŸ€‹⁄›ﬁﬂ123";
            char[,] string_square = new char[6,6];
            key = key.ToUpper();
            ABC = key + string.Join("",ABC.Split(key.ToCharArray()));
            for (int i =0; i < ABC.Length; i++)
            {
                string_square[i/6,i%6] = ABC[i];
            }
            return string_square;
        }
        
        public static string EncodeString(string init_text, char[,] square)
        {
            string encodedString = "";
            for (int i = 0; i < init_text.Length; i+=2)
            {
                if (init_text[i] == init_text[i+1])
                {
                    init_text = init_text.Remove(i + 1, 1).Insert(i + 1, "ﬂ");
                }
            }
            List<int> coord = new List<int>();
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
                            coord.Add(i);
                            coord.Add(j);
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
            for (int i = 0; i < coord.Count; i+=4)
            {
                if (coord[i] == coord[i + 2])
                {
                    if (coord[i+1] == 5)
                    {
                        encodedString += square[coord[i],0];
                    }
                    else
                    {
                        encodedString += square[coord[i], coord[i + 1]+1];
                    }
                    if (coord[i+3] == 5)
                    {
                        encodedString += square[coord[i + 2], 0];
                    }
                    else
                    {
                        encodedString += square[coord[i + 2], coord[i+3] + 1];
                    }

                } 
                else if (coord[i+1] == coord[i+3])
                {
                    if (coord[i] == 5)
                    {
                        encodedString += square[0, coord[i+1]];
                    }
                    else
                    {
                        encodedString += square[coord[i]+1, coord[i+1]];
                    }
                    if (coord[i + 2] == 5)
                    {
                        encodedString += square[0, coord[i + 3]];
                    }
                    else
                    {
                        encodedString += square[coord[i + 2] + 1, coord[i + 3]];
                    }
                }

                else {
                    encodedString += square[coord[i], coord[i + 3]].ToString()  + square[coord[i + 2], coord[i + 1]].ToString(); }
            }
            return encodedString;
        }

        public static string DecodeString(string init_text, char[,] square)
        {
            string decodedString = "";
            List<int> coord = new List<int>();
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
                            coord.Add(i);
                            coord.Add(j);
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
            for (int i = 0; i < coord.Count; i += 4)
            {
                if (coord[i] == coord[i + 2])
                {
                    if (coord[i + 1] == 0)
                    {
                        decodedString += square[coord[i], 5];
                    }
                    else
                    {
                        decodedString += square[coord[i], coord[i + 1] - 1];
                    }
                    if (coord[i + 3] == 0)
                    {
                        decodedString += square[coord[i + 2], 5];
                    }
                    else
                    {
                        decodedString += square[coord[i + 2], coord[i + 3] - 1];
                    }

                }
                else if (coord[i + 1] == coord[i + 3])
                {
                    if (coord[i] == 0)
                    {
                        decodedString += square[5, coord[i + 1]];
                    }
                    else
                    {
                        decodedString += square[coord[i] - 1, coord[i + 1]];
                    }
                    if (coord[i + 3] == 0)
                    {
                        decodedString += square[5, coord[i + 3]];
                    }
                    else
                    {
                        decodedString += square[coord[i + 2] - 1, coord[i + 3]];
                    }
                }
                else { decodedString += square[coord[i], coord[i + 3]].ToString() + square[coord[i + 2], coord[i + 1]].ToString(); }
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