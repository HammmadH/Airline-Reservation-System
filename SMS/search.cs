using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AMS
{
    class search
    {
        int cmp;
        int box;


        //MONDAY 

        public void monday(ComboBox a, ComboBox b, ComboBox c, TextBox d, ComboBox e)
        {
            String[] arr = File.ReadAllLines("search_monday.txt");

            box = int.Parse(d.Text);

            // MONDAY BUSINISS

            if (c.Text == "BUSINESS")
            {
                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[0]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[1]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[2]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }

                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[3]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[4]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[5]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
            }


            //MONDAY ECONOME
            if (c.Text == "ECONOMY")
            {
                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "ECONOMY" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[6]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "ECONOMY" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[7]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "ECONOMY" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[8]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }

                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "ECONOMY" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[9]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "ECONOMY" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[10]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "ECONOMY" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[11]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
            }

        }



        //friday


        public void friday(ComboBox a, ComboBox b, ComboBox c, TextBox d, ComboBox e)
        {
            String[] arr = File.ReadAllLines("search_friday.txt");

            //friday businiss

            if (c.Text == "BUSINESS")
            {
                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[0]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[1]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[2]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }

                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[3]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[4]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[5]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
            }


            ///FRIDAY ECONOME

            if (c.Text == "ECONOMY")
            {
                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "ECONOMY" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[6]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "ECONOMY" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[7]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "ECONOMY" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[8]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }

                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "ECONOMY" && e.Text == "FRIDAY")
                {

                    cmp = int.Parse(arr[9]);
                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "ECONOMY" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[10]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "ECONOMY" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[11]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
            }
        }

        //sunday



        public void sunday(ComboBox a, ComboBox b, ComboBox c, TextBox d, ComboBox e)
        {
            String[] arr = File.ReadAllLines("search_sunday.txt");
            box = int.Parse(d.Text);

            // sunday BUSINISS
            if (c.Text == "BUSINISS")
            {
                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "BUSINISS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[0]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "BUSINISS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[1]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "BUSINISS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[2]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }

                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "BUSINISS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[3]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "BUSINISS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[4]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "BUSINISS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[5]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
            }


            //sunday ECONOME
            if (c.Text == "ECONOMY")
            {



                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "ECONOMY" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[6]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "ECONOMY" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[7]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "ECONOMY" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[8]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }

                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "ECONOMY" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[9]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "ECONOMY" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[10]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "ECONOMY" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[11]);

                    if (box < cmp)
                    {
                        MessageBox.Show("seats left: " + cmp);
                    }

                }
            }

        }
    }
}
