using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace AMS
{
    class comment
    {
        public void cmnt(TextBox a, TextBox b)
        {
            StreamWriter sw = new StreamWriter("comment.txt", true);
            sw.WriteLine("NAME:-" + a.Text + "..." + b.Text);
            sw.Close();
        }

        public void showcmnt(ListBox l)
        {
            string[] ar = File.ReadAllLines("comment.txt");
            Stack<string> st = new Stack<string>();
            for (int i = 0; i < ar.Length; i++)
            {
                st.Push(ar[i]);
            }
            for (int j = 0; j < ar.Length; j++)
            {
                l.Items.Add(st.Pop());
            }
        }

        //    public void cancle(TextBox tt)
        //{
        //        string
        //}


    }
}
