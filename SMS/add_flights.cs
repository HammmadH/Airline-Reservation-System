using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace AMS
{
    class add_flights
    {
        // int cmp;
        // int box;

        ////MONDAY 

        //public void monday(ComboBox a, ComboBox b, ComboBox c, TextBox d, ComboBox e)
        //{
        //    String[] arr = File.ReadAllLines("search_monday.txt");
        //    box = Convert.ToInt32(d.Text);

        //    // MONDAY BUSINISS

        //    if (c.Text == "BUSINESS")
        //    {
        //        if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "MONDAY")
        //        {
        //            cmp = Convert.ToInt32(arr[0]);
        //            int add = cmp + box;
        //            arr[0] = add.ToString();
        //            MessageBox.Show("ADD");
        //            File.WriteAllLines("search_monday.txt", arr);
        //        }
        //    }
        //}



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
                    int add = cmp + box;
                    arr[0] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_monday.txt", arr);

                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[1]);
                    int add = cmp + box;
                    arr[1] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_monday.txt", arr);


                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[2]);

                    int add = cmp + box;
                    arr[2] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_monday.txt", arr);

                }

                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[3]);
                    int add = cmp + box;
                    arr[3] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_monday.txt", arr);


                }
                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[4]);
                    int add = cmp + box;
                    arr[4] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_monday.txt", arr);


                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[5]);
                    int add = cmp + box;
                    arr[5] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_monday.txt", arr);


                }
            }


            //MONDAY ECONOME
            if (c.Text == "ECONOMY")
            {
                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "ECONOMY" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[6]);

                    int add = cmp + box;
                    arr[6] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_monday.txt", arr);

                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "ECONOMY" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[7]);
                    int add = cmp + box;
                    arr[7] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_monday.txt", arr);


                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "ECONOMY" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[8]);
                    int add = cmp + box;
                    arr[8] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_monday.txt", arr);



                }

                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "ECONOMY" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[9]);
                    int add = cmp + box;
                    arr[9] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_monday.txt", arr);



                }
                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "ECONOMY" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[10]);
                    int add = cmp + box;
                    arr[10] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_monday.txt", arr);



                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "ECONOMY" && e.Text == "MONDAY")
                {
                    cmp = int.Parse(arr[11]);
                    int add = cmp + box;
                    arr[11] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_monday.txt", arr);


                }
            }

        }



        //friday


        public void friday(ComboBox a, ComboBox b, ComboBox c, TextBox d, ComboBox e)
        {
            String[] arr = File.ReadAllLines("search_friday.txt");

            //friday businiss
            box = int.Parse(d.Text);
            if (c.Text == "BUSINESS")
            {
                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[0]);
                    int add = cmp + box;
                    arr[0] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_friday.txt", arr);


                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[1]);
                    int add = cmp + box;
                    arr[1] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_friday.txt", arr);


                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[2]);
                    int add = cmp + box;
                    arr[2] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_friday.txt", arr);


                }

                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[3]);
                    int add = cmp + box;
                    arr[3] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_friday.txt", arr);



                }
                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[4]);
                    int add = cmp + box;
                    arr[4] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_friday.txt", arr);


                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[5]);
                    int add = cmp + box;
                    arr[5] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_friday.txt", arr);


                }
            }


            ///FRIDAY ECONOME

            if (c.Text == "ECONOMY")
            {
                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "ECONOMY" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[6]);
                    int add = cmp + box;
                    arr[6] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_friday.txt", arr);

                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "ECONOMY" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[7]);
                    int add = cmp + box;
                    arr[7] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_friday.txt", arr);

                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "ECONOMY" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[8]);
                    int add = cmp + box;
                    arr[8] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_friday.txt", arr);


                }

                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "ECONOMY" && e.Text == "FRIDAY")
                {

                    cmp = int.Parse(arr[9]);
                    int add = cmp + box;
                    arr[9] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_friday.txt", arr);

                }
                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "ECONOMY" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[10]);
                    int add = cmp + box;
                    arr[10] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_friday.txt", arr);


                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "ECONOMY" && e.Text == "FRIDAY")
                {
                    cmp = int.Parse(arr[11]);
                    int add = cmp + box;
                    arr[11] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_friday.txt", arr);

                }
            }
        }

        //sunday



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
                    int add = cmp + box;
                    arr[0] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_sunday.txt", arr);



                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[1]);
                    int add = cmp + box;
                    arr[1] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_sunday.txt", arr);

                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "BUSINESS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[2]);
                    int add = cmp + box;
                    arr[2] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_sunday.txt", arr);


                }

                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[3]);
                    int add = cmp + box;
                    arr[3] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_sunday.txt", arr);

                }
                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "BUSINESS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[4]);
                    int add = cmp + box;
                    arr[4] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_sunday.txt", arr);
                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "BUSINESS" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[5]);
                    int add = cmp + box;
                    arr[5] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_sunday.txt", arr);

                }
            }


            //sunday ECONOME
            if (c.Text == "ECONOMY")
            {



                if (a.Text == "KARACHI" && b.Text == "ISLAMABAD" && c.Text == "ECONOMY" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[6]);
                    int add = cmp + box;
                    arr[6] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_sunday.txt", arr);

                }
                if (a.Text == "KARACHI" && b.Text == "LAHORE" && c.Text == "ECONOMY" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[7]);
                    int add = cmp + box;
                    arr[7] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_sunday.txt", arr);

                }

                if (a.Text == "ISLAMABAD" && b.Text == "LAHORE" && c.Text == "ECONOMY" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[8]);
                    int add = cmp + box;
                    arr[8] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_sunday.txt", arr);
                }

                if (a.Text == "ISLAMABAD" && b.Text == "KARACHI" && c.Text == "ECONOMY" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[9]);
                    int add = cmp + box;
                    arr[9] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_sunday.txt", arr);

                }
                if (a.Text == "LAHORE" && b.Text == "KARACHI" && c.Text == "ECONOMY" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[10]);
                    int add = cmp + box;
                    arr[10] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_sunday.txt", arr);

                }
                if (a.Text == "LAHORE" && b.Text == "ISLAMABAD" && c.Text == "ECONOMY" && e.Text == "SUNDAY")
                {
                    cmp = int.Parse(arr[11]);
                    int add = cmp + box;
                    arr[11] = add.ToString();
                    MessageBox.Show("ADD");
                    File.WriteAllLines("search_sunday.txt", arr);

                }
            }

        }
    }
}
