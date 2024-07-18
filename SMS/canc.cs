using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AMS
{
    class canc
    {

        public void del(TextBox t, Panel p)
        {
            string[] ar = File.ReadAllLines("regester.txt");
            List<string> ll = new List<string>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (t.Text != ar[i])
                {

                    ll.Add(ar[i]);
                }

                if (t.Text == ar[i])
                {
                    StreamWriter sr = new StreamWriter("cancel.txt", true);
                    sr.WriteLine(ar[i]);
                    sr.Close();
                }
            }

            File.Delete("regester.txt");
            StreamWriter ss = new StreamWriter("regester.txt");
            foreach (string item in ll)
            {
                ss.WriteLine(item);
            }
            ss.Close();
            MessageBox.Show("THANKS...");
            p.Hide();
        }







        public void canl(DataGridView d)
        {
            int n = 0;
            int i;
            string[] arr = File.ReadAllLines("cancel.txt");
            for (int j = 0; j < arr.Length; j++)
            {
                string[] ar = File.ReadAllLines(arr[j] + ".txt");
                d.Rows.Add();
                for (i = 0; i < ar.Length; i++)
                {
                    d.Rows[n].Cells[i].Value = ar[i];

                }
                n++;
            }


            // d.Rows[n].Cells[i].Value = arr[i];
        }


        public void find(TextBox t)
        {
            bool b = true;
            string[] ar = File.ReadAllLines("regester.txt");
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == t.Text)
                {
                    MessageBox.Show("YOUR SEATS ARE RESERVED...");

                    b = false;
                    break;
                }

            }
            t.Clear();
            if (b == true)
            {
                MessageBox.Show("NOT REGESTERED...");
            }
        }




        public void detail(TextBox t, ListBox l)
        {
            bool b = true;
            string[] ar = File.ReadAllLines("regester.txt");
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == t.Text)
                {
                    string[] a = File.ReadAllLines(ar[i] + ".txt");
                    for (int j = 0; j < a.Length; j++)
                    {
                        l.Items.Add(a[j]);
                    }


                    b = false;
                    break;
                }

            }
            t.Clear();
            if (b == true)
            {
                MessageBox.Show("NOT REGESTERED...");
            }
        }
    }
}
