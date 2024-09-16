using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astronomical_Processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillArray();
        }

        static int hourMax = 24;
        int[] hourArray = new int[hourMax];
       

        private void FillArray()
        {
            Random randData = new Random();
            for (int i = 0; i < hourMax; i++)
            {
                // Random number
                hourArray[i] = randData.Next(10,91);
               // Console.WriteLine(hourArray[i]);
            }
        }      

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            BubbleSort();
            ShowArray(0, 23);
            MessageBox.Show("success!");
        }

        private void BubbleSort() 
        {
            int temp = 0;
            for (int outer = 0; outer < hourMax ; outer++)
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
            
        }
        private void ShowArray(int start, int end) 
        {
            ListBoxResults.Items.Clear();
            for (int i = start; i < end; i++) 
            {
                ListBoxResults.Items.Add(hourArray[i]);
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {           
            Binary_Search();
        }
        private void Binary_Search() 
        {
            int target;
            int mid;
            int startPoint = 0;
            int endPoint = hourMax;
            int.TryParse(TextBoxInput.Text, out target);
            while (startPoint <= endPoint) 
            {
                mid = (startPoint + endPoint) /2;
                if (hourArray[mid] == target)
                {
                    return;
                }
                else if (hourArray[mid] > target)
                {
                    endPoint = mid - 1;
                }
                else 
                {
                    startPoint = mid +1;
                }
            }
            ShowArray(startPoint, endPoint);

        }
    }
}
