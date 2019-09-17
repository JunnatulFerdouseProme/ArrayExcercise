using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayExcercise
{
    public partial class Form1 : Form
    {
        const int size = 10;
        int[] array = new int[size];

        int index = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
           
            for( index=0;index<size;index++)
            {
           
                array[index] = Convert.ToInt32(arraytextbox.Text);
                if(index<size)
                {
                    itemrichtextbox.Text = arraytextbox.Text;
                    index++;
                }
                

            }
            
                
               
           

        }

      
    }
}
