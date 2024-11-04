using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// SUNJU CHOI, Sprint ONE
// Date: 16.09.2024
// Version: 1.0
// Astronomical Processing
// This program stores and allows modifacation of the number of neutrino interactions per hour in a 24 element array.
// it uses the bubble sort algorithm to sort the data and the binary search algorithm to search through the data.
// The user enter a value to edit or search for in the textbox and press button they want , the result will be displayed in the List Box. 


namespace Astronomical_Processing
{
    public partial class Form1 : Form
    {
        // Array for 24 hours
        const int hourMax = 24;
        int[] hourArray = new int[hourMax];

        // checking if the array is sorted
        bool isSorted = false;

        public Form1()
        {
            InitializeComponent();
            FillArray();
            ShowArray();

        }

        /// <summary>
        ///  Fill array with random integers between 10 and 90
        /// </summary>
        private void FillArray()
        {
            Random randData = new Random();
            for (int i = 0; i < hourMax; i++)
            {

                hourArray[i] = randData.Next(10, 91);

            }
        }

        /// <summary>
        ///  Sort button click
        /// </summary>
        /// <param name="sender"> the source of the event </param>
        /// <param name="e"> contains the event data </param>
        private void ButtonSort_Click(object sender, EventArgs e)
        {

            BubbleSort();
            ShowArray();
            MessageBox.Show("Data sorted successfully!");
        }

        /// <summary>
        ///  Bubble Sort Algorithm
        /// </summary>
        private void BubbleSort()
        {
            int temp = 0;

            for (int outer = 0; outer < hourMax; outer++)
            {
                for (int inner = 0; inner < hourMax - 1; inner++)
                {
                    if (hourArray[inner] > hourArray[inner + 1])
                    {
                        temp = hourArray[inner + 1];
                        hourArray[inner + 1] = hourArray[inner];
                        hourArray[inner] = temp;

                    }
                }
            }

            isSorted = true;
        }

        /// <summary>
        ///  Display data in the ListBox
        /// </summary>
        private void ShowArray()
        {
            ListBoxResults.Items.Clear();
            TextBoxInput.Clear();
            for (int i = 0; i < hourMax; i++)
            {
                ListBoxResults.Items.Add(hourArray[i]);

            }
        }

        /// <summary>
        ///  Search button Click
        /// </summary>
        /// <param name="sender"> the source of the event </param>
        /// <param name="e"> contains the event data </param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {

            TextboxClear();

            if (string.IsNullOrWhiteSpace(TextBoxInput.Text))
            {
                MessageBox.Show("Please enter the data you want to search");
                return;
            }

            if (int.TryParse(TextBoxInput.Text, out int searchData))
            {
                if (!isSorted)
                {
                    MessageBox.Show("Please sort before you search");
                    return;

                }

                int resultSearch = BinarySearch(searchData);


                if (resultSearch != -1)
                {
                    ShowArray();
                    ListBoxResults.SelectedIndex = resultSearch;
                    MessageBox.Show("Success!");
                }
                else
                {
                    ShowArray();
                    MessageBox.Show("not found!");
                    return;
                }
                TextBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Enter vaild data!");
                return;
            }
        }

        /// <summary>
        ///  Binary Search Algorithm
        /// </summary>
        /// <param name="target"> this is the value entered by user in the text box to search </param> 
        private int BinarySearch(int target)
        {
            int mid;
            int startPoint = 0;
            int endPoint = hourMax - 1;
            while (startPoint <= endPoint)
            {
                mid = (startPoint + endPoint) / 2;
                if (hourArray[mid] == target)
                {
                    ListBoxResults.Items.Clear();

                    return mid;

                }
                else if (hourArray[mid] > target)
                {
                    endPoint = mid - 1;
                }
                else
                {
                    startPoint = mid + 1;
                }
            }
            return -1;

        }

        /// <summary>
        ///  Edit,Save Button Click
        /// </summary>
        /// <param name="sender"> the source of the event </param>
        /// <param name="e"> contains the event data </param>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {

            TextboxClear();

            if (ListBoxResults.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an data on the listbox to edit");
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBoxInput.Text))
            {
                MessageBox.Show("Please enter the data you want to edit or save");
                return;
            }

            if (int.TryParse(TextBoxInput.Text, out int newData))
            {

                hourArray[ListBoxResults.SelectedIndex] = newData;
                ShowArray();

                isSorted = false;

                MessageBox.Show("Data uptated successfully!");

            }
            else
            {
                MessageBox.Show("Enter vaild data!");
            }

        }

        /// <summary>
        ///  Sequential Search Button Click
        /// </summary>
        /// <param name="sender"> the source of the event </param>
        /// <param name="e"> contains the event data </param>
        private void ButtonSeqSearch_Click(object sender, EventArgs e)
        {
            TextboxClear();


            if (string.IsNullOrWhiteSpace(TextBoxInput.Text))
            {
                MessageBox.Show("Please enter the data you want to search");
                return;
            }

            if (int.TryParse(TextBoxInput.Text, out int seqSearchData))
            {

                int resultSeqSearch = SequentialSearch(seqSearchData);


                if (resultSeqSearch != -1)
                {
                    ShowArray();
                    ListBoxResults.SelectedIndex = resultSeqSearch;
                    MessageBox.Show("Success!");
                }
                else
                {
                    ShowArray();
                    MessageBox.Show("not found!");
                    return;
                }
                TextBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Enter vaild data!");
                return;
            }
        }

        private int SequentialSearch(int target)
        {
            for (int i = 0; i < hourMax; i++)
            {
                if (hourArray[i] == target)
                {
                    return i;
                }

            }
            return -1;
        }

        /// <summary>
        ///  MidExtreme Button Click
        /// </summary>
        /// <param name="sender"> the source of the event </param>
        /// <param name="e"> contains the event data </param>
        private void ButtonMidExtreme_Click(object sender, EventArgs e)
        {
            double midExtreme = CalculatemidExtreme();
            TextboxMidExtreme.Text = midExtreme.ToString();
        }

        /// <summary>
        ///  Mode Button Click
        /// </summary>
        /// <param name="sender"> the source of the event </param>
        /// <param name="e"> contains the event data </param>
        private void ButtonMode_Click(object sender, EventArgs e)
        {

            int mode = CalculateMode();
            if (mode != -1)
            {
                TextboxMode.Text = mode.ToString();
            }
            else
            {
                MessageBox.Show("There is no mode!");
            }
        }

        /// <summary>
        ///  Average Button Click
        /// </summary>
        /// <param name="sender"> the source of the event </param>
        /// <param name="e"> contains the event data </param>
        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            double average = CalculateAverage();
            TextboxAverage.Text = average.ToString();
        }

        /// <summary>
        ///  Range Button Click
        /// </summary>
        /// <param name="sender"> the source of the event </param>
        /// <param name="e"> contains the event data </param>
        private void ButtonRange_Click(object sender, EventArgs e)
        {
            int range = CalculateRange();
            TextboxRange.Text = range.ToString();
        }

        /// <summary>
        ///  Calculate Mid-Extreme
        /// </summary>
        private double CalculatemidExtreme()
        {
            int minData = hourArray[0];
            int maxData = hourArray[0];

            for (int i = 1; i < hourMax; i++)
            {
                if (hourArray[i] < minData)
                {
                    minData = hourArray[i];
                }
                if (hourArray[i] > maxData)
                {
                    maxData = hourArray[i];
                }
            }
            return (minData + maxData) / 2.0;
        }

        /// <summary>
        ///  Calculate Average
        /// </summary>
        private double CalculateAverage()
        {
            int sumAllData = 0;
            for (int i = 0; i < hourMax; i++)
            {
                sumAllData = sumAllData + hourArray[i];
            }
            return sumAllData / 24;
        }

        /// <summary>
        ///  Calculate Range
        /// </summary>
        private int CalculateRange()
        {
            int minData = hourArray[0];
            int maxData = hourArray[0];

            for (int i = 1; i < hourMax; i++)
            {
                if (hourArray[i] < minData)
                {
                    minData = hourArray[i];
                }
                if (hourArray[i] > maxData)
                {
                    maxData = hourArray[i];
                }
            }
            return maxData - minData;
        }

        /// <summary>
        ///  Calculate Mode
        /// </summary>
        private int CalculateMode()
        {
            int mode = hourArray[0];
            int maxRepeat = 0;
            int repeat = 0;
            bool multiMode = false;

            for (int i = 0; i < hourMax; i++)
            {
                repeat = 0;

                for (int j = 0; j < hourMax; j++)
                {
                    if (hourArray[i] == hourArray[j])
                    {
                        repeat = repeat + 1;
                    }
                }
                if (repeat > maxRepeat)
                {
                    maxRepeat = repeat;
                    mode = hourArray[i];
                    multiMode = false;

                }
                else if (repeat == maxRepeat & hourArray[i] != mode)
                {
                    multiMode = true;
                }
            }
            if (!multiMode)
            {
                return mode;
            }
            return -1;

        }

        /// <summary>
        ///  Reset button Click
        /// </summary>
        /// <param name="sender"> the source of the event </param>
        /// <param name="e"> contains the event data </param>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            FillArray();
            ShowArray();
            TextboxMidExtreme.Clear();
            TextboxMode.Clear();
            TextboxAverage.Clear();
            TextboxRange.Clear();

        }

        /// <summary>
        ///  Textbox clear
        /// </summary>
       
        private void TextboxClear()
        {
            TextboxMidExtreme.Clear();
            TextboxMode.Clear();
            TextboxAverage.Clear();
            TextboxRange.Clear();
        }
    }
}