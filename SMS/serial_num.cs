using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AMS
{
    class serial_num
    {
        public int x;
        public void serial(Label a, TextBox t1, TextBox t2, TextBox t3, TextBox t4, ComboBox c1, ComboBox c2, ComboBox c3, ComboBox c4, TextBox t5)
        {

            //string[] arr1;
            //string ln = null;
            //arr1 = ln.Split('\n');
            //serial num

            string[] arr = File.ReadAllLines("serial_num.txt");

            x = Int32.Parse(arr[0]);
            x++;
            a.Text = x.ToString();
            arr[0] = x.ToString();
            File.WriteAllLines("serial_num.txt", arr);

            //add data in file


            StreamWriter sw = new StreamWriter(x + ".txt", true);
            sw.WriteLine(t1.Text);
            sw.WriteLine(t2.Text);
            sw.WriteLine(t3.Text);
            sw.WriteLine(t4.Text);
            sw.WriteLine(c1.Text);
            sw.WriteLine(c2.Text);
            sw.WriteLine(c3.Text);
            sw.WriteLine(c4.Text);
            sw.WriteLine(t5.Text);
            sw.Close();




            // for all regester

            StreamWriter s = new StreamWriter("regester.txt", true);
            s.WriteLine(x);
            s.Close();

            //MessageBox.Show(x.ToString());
        }

        public void showser(Panel p, Label l)
        {
            p.Show();
            l.Text = x.ToString();
        }


    }
}
