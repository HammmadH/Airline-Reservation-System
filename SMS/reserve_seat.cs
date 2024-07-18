using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AMS
{
    class reserve_seat
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

                    if (cmp != '0')
                    {

                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[0] = cmp.ToString();
                            File.WriteAllLines("search_monday.txt", arr);
                            MessageBox.Show("seats left :-" + cmp);
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }


                }

                if (a.Text == "KARACHI" && b.Text == "LAHOR" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[1]);
                    if (cmp != '0')
                    {

                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[1] = cmp.ToString();
                            File.WriteAllLines("search_monday.txt", arr);
                            MessageBox.Show("seats left" + cmp);
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHOR" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[2]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[2] = cmp.ToString();
                            File.WriteAllLines("search_monday.txt", arr);
                            MessageBox.Show("seats left" + cmp);
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }

                }
                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[3]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[3] = cmp.ToString();
                            File.WriteAllLines("search_monday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }

                }

                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[4]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[4] = cmp.ToString();
                            File.WriteAllLines("search_monday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }

                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }

                }

                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[5]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[5] = cmp.ToString();
                            File.WriteAllLines("search_monday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

            }

            //MONDAY ECONOME
            if (c.Text == "ECONOME")
            {

                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "ECONOME" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[6]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[6] = cmp.ToString();
                            File.WriteAllLines("search_monday.txt", arr);
                            MessageBox.Show("seats left :-" + cmp);
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "ECONOME" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[7]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[7] = cmp.ToString();
                            File.WriteAllLines("search_monday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "ECONOME" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[8]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[8] = cmp.ToString();
                            File.WriteAllLines("search_monday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }

                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }
                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "ECONOME" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[9]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[9] = cmp.ToString();
                            File.WriteAllLines("search_monday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "ECONOME" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[10]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[10] = cmp.ToString();
                            File.WriteAllLines("search_monday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }

                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "ECONOME" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[11]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[11] = cmp.ToString();
                            File.WriteAllLines("search_monday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }
            }

        }


        //friday

        public void friday(ComboBox a, ComboBox b, ComboBox c, TextBox d, ComboBox e)
        {
            String[] arr = File.ReadAllLines("search_friday.txt");

            box = int.Parse(d.Text);

            // friday BUSINISS
            if (c.Text == "BUSINESS")
            {
                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[0]);

                    if (cmp != '0')
                    {

                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[0] = cmp.ToString();
                            File.WriteAllLines("search_friday.txt", arr);
                            MessageBox.Show("seats left :-" + cmp);
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[1]);
                    if (cmp != '0')
                    {

                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[1] = cmp.ToString();
                            File.WriteAllLines("search_friday.txt", arr);
                            MessageBox.Show("seats left" + cmp);
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[2]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[2] = cmp.ToString();
                            File.WriteAllLines("search_friday.txt", arr);
                            MessageBox.Show("seats left" + cmp);
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }

                }
                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[3]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[3] = cmp.ToString();
                            File.WriteAllLines("search_friday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }

                    }

                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }

                }

                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[4]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[4] = cmp.ToString();
                            File.WriteAllLines("search_friday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[5]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[5] = cmp.ToString();
                            File.WriteAllLines("search_friday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

            }

            //friday ECONOME
            if (c.Text == "ECONOME")
            {

                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "ECONOME" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[6]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[6] = cmp.ToString();
                            File.WriteAllLines("search_friday.txt", arr);
                            MessageBox.Show("seats left :-" + cmp);
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }

                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "ECONOME" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[7]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[7] = cmp.ToString();
                            File.WriteAllLines("search_friday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "ECONOME" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[8]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[8] = cmp.ToString();
                            File.WriteAllLines("search_friday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }
                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "ECONOME" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[9]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[9] = cmp.ToString();
                            File.WriteAllLines("search_friday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "ECONOME" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[10]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[10] = cmp.ToString();
                            File.WriteAllLines("search_friday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "ECONOME" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[11]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[11] = cmp.ToString();
                            File.WriteAllLines("search_friday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }
            }

        }


        public void sunday(ComboBox a, ComboBox b, ComboBox c, TextBox d, ComboBox e)
        {
            String[] arr = File.ReadAllLines("search_sunday.txt");
            box = int.Parse(d.Text);

            // sunday BUSINISS



            if (c.Text == "BUSINESS")
            {
                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[0]);

                    if (cmp != '0')
                    {

                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[0] = cmp.ToString();
                            File.WriteAllLines("search_sunday.txt", arr);
                            MessageBox.Show("seats left :-" + cmp);
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[1]);
                    if (cmp != '0')
                    {

                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[1] = cmp.ToString();
                            File.WriteAllLines("search_sunday.txt", arr);
                            MessageBox.Show("seats left" + cmp);
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }

                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[2]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[2] = cmp.ToString();
                            File.WriteAllLines("search_sunday.txt", arr);
                            MessageBox.Show("seats left" + cmp);
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }
                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[3]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[3] = cmp.ToString();
                            File.WriteAllLines("search_sunday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[4]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[4] = cmp.ToString();
                            File.WriteAllLines("search_sunday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[5]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[5] = cmp.ToString();
                            File.WriteAllLines("search_sunday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

            }

            //friday ECONOME
            if (c.Text == "ECONOME")
            {

                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "ECONOME" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[6]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[6] = cmp.ToString();
                            File.WriteAllLines("search_sunday.txt", arr);
                            MessageBox.Show("seats left :-" + cmp);
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "ECONOME" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[7]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[7] = cmp.ToString();
                            File.WriteAllLines("search_sunday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "ECONOME" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[8]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[8] = cmp.ToString();
                            File.WriteAllLines("search_sunday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }

                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }
                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "ECONOME" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[9]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[9] = cmp.ToString();
                            File.WriteAllLines("search_sunday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }

                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "ECONOME" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[10]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[10] = cmp.ToString();
                            File.WriteAllLines("search_sunday.txt", arr);
                            MessageBox.Show("seats left");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "ECONOME" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[11]);
                    if (cmp != '0')
                    {
                        if (box < cmp)
                        {
                            cmp -= box;
                            arr[11] = cmp.ToString();
                            File.WriteAllLines("search_sunday.txt", arr);
                            MessageBox.Show("seats left sun");
                        }
                        else
                        {
                            MessageBox.Show("JUST" + cmp + "SEATS LEFT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ALL SEATS RESERVERD");
                    }
                }
            }

        }
























    }
}
