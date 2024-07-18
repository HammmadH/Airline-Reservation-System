using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AMS
{
    class regestr
    {
        public void reg(DataGridView d)
        {
            int n = 0;
            int i;
            string[] arr = File.ReadAllLines("regester.txt");
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



    }
}
