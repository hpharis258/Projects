using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

/*********************************************************************
 * Sorting Algorithm Visualization by Haroldas Varanauskas
 *********************************************************************/
namespace SortingAlgorithmApplication
{
    public partial class Form1 : Form
    {
        // initialising an array and a graphics object
        int[] arrrayToSort;
        Graphics g;
        // Boolean to check if the array is sorted
        private bool _sorted = false;
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            //Creating a graphics object on the form
            g = panel1.CreateGraphics();
            // variables that hold the current state of the array
            int maxValue = panel1.Height; // maximum value in the array can only be as high as the panel
            int arrayItems = panel1.Width; // maximum entries in the array are set to the width of the panel

            // Setting the array size to the array items
            arrrayToSort = new int[arrayItems];

            // initialising the background of the panel to black
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, arrayItems, maxValue);

            // random number generator
            Random gen = new Random();

            // Creating a random number between 0 and max height of the panel and adding it to the array
            for(int i = 0; i < arrayItems; i++)
            {
                arrrayToSort[i] = gen.Next(0, maxValue);
            }

            // Drawing each item in the array as 1 pixel wide bar on to the panel
            for(int i = 0; i < arrayItems; i++)
            {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, maxValue - arrrayToSort[i], 1, maxValue);
            }

        }

        // Method to check id the array is sorted, Goes through each index in the array comparing it to the next one if current index is higher than the next one returns false else the array is sorted
        private bool isSorted()
        {
            for (int i = 0; i < arrrayToSort.Count() - 1; i++)
            {
                if (arrrayToSort[i] > arrrayToSort[i + 1]) return false;
            }
            return true;
        }


        //SORTING METHOD
        /* While sorted is not true, go through each item in the array comparing it to the next index if current index is bigger than the next one swap them, repeat until sorted test is passsed */
        public void bubbleSort(int[] array)
        {
             while (!_sorted)
            {
                for(int i = 0; i < arrrayToSort.Count() - 1; i++)
                {
                    if(arrrayToSort[i] > arrrayToSort[i+1])
                    {
                        swap(i, i + 1);
                    }
                }
                _sorted = isSorted();
            }
             // resets _sorted boolen back to false, so that if a new array is generated bubble sort method can be reused 
            _sorted = false; 
        }

       

        // Swap method
        public void swap(int i, int j)
        {
            // Swaps the values using temporary variable 
            int temp = arrrayToSort[i];
            arrrayToSort[i] = arrrayToSort[i + 1];
            arrrayToSort[i + 1] = temp;

            // Deletes the old values of the panel

            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), i, 0, 1, panel1.Height);
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), j, 0, 1, panel1.Height);

            // Draws new values on to the panel
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, panel1.Height - arrrayToSort[i], 1, panel1.Height);
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), j, panel1.Height - arrrayToSort[j], 1, panel1.Height);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Clears the screen before the sorting method starts.
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, arrrayToSort.Length, panel1.Height);

            // Starts the bubbleSort method
            bubbleSort(arrrayToSort);
            

        }

        public void insertionSort(int [] arrayToSort ) 
        {
            int i = 1; //Starting index 
            int j = i; //index of the element that is going to be swapped if needed
            int temp = 0; // temporary variable used to swap

            while(i < arrrayToSort.Length)
            {
               
                j = i; // Set the index of the current item that is being comapred 
                // if there is a number to the left that has not been compared we swap our current element one position back
                while(j > 0 && arrrayToSort[j - 1] > arrrayToSort[j])
                {
                    // Swaps j and j- 1 current index with backward index
                    temp = arrrayToSort[j]; // assigns j to temporary variable
                    arrrayToSort[j] = arrrayToSort[j - 1]; // moves j - 1 into j, the elemnent on the left to the element on the right
                    arrrayToSort[j - 1] = temp; // moves j into j - 1, element on the right to the left.
                    j--; // decrement to compare the next element on the left.
                }
                i++; // Move to the next element, to insert backwards into the array
            }
        }

        // Insertion Sort Button
        private void button3_Click(object sender, EventArgs e)
        {
            // Clears the screen before the sorting method starts.
            

            insertionSort(arrrayToSort);

            
            // Draws the sorted array on the screen. 
            for(int i = 0; i < arrrayToSort.Length; i++)
            {
                
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black),i, 0 , 1, panel1.Height);

                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, panel1.Height - arrrayToSort[i], 1, panel1.Height);
                Thread.Sleep(5);
            }
            
        }
    }
}
