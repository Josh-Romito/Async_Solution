/**************
 * Josh Romito
 * CP_220
 * Assignment 4
 **************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Assignment_4
{
    public partial class PeasantForm : Form
    {
        public PeasantForm()
        {
            InitializeComponent();
        }

        //Random number is being created here to allow more "Randomness" - it is later passed into the constructor and live life method
        Random r = new Random();

        //main button click
        public async void btnStart_Click(object sender, EventArgs e)
        {
            //clearing listboxes
            peasantOutput1.Items.Clear();
            peasantOutput2.Items.Clear();
            //changing button and label status, 
            label1.Text = "Simulation running...";
            btnStart.Enabled = false;
            btnStart.Text = "Please wait...";
           
            //creating peasants - passing in a listbox, a name, and the random number object
            
            Peasant derp = new Peasant(peasantOutput2, "Gary", r);
            Peasant derp2 = new Peasant(peasantOutput1, "Bob", r);

            //calling the liveLifeAsync methods
            //await Task.Run (() => { Task x = derp.liveLifeAsync(r); });
            //await Task.Run (() => { Task x = derp2.liveLifeAsync(r); });
            

            // NEW EASY WAY OF WAITING - makes the statusAync function redundant
            Task first = derp.liveLifeAsync(r);
            Task second = derp2.liveLifeAsync(r);

            await Task.WhenAll(first, second);
            btnStart.Enabled = true;
            label1.Text = "Simulation Finished...";
            btnStart.Text = "Start simulation";

            //calling the statusAsync method
            //await Task.Run(() => { Task x = statusAsync(); });
        }

        //quite ridiculous... but it works - clears the list boxes, and handles label/button changes
        public async Task statusAsync()
        {
            await Task.Run (() =>
            {
                while (true)
                {
                    if (peasantOutput1.Items.Contains("Dead"))
                    {
                        if (peasantOutput2.Items.Contains("Dead"))
                        {
                            Action change = () => { label1.Text = "Simulation Complete!"; btnStart.Enabled = true; btnStart.Text = "Start Simulation"; };
                            label1.Invoke(change);
                            break;
                        }
                    }
                }
           });
        }
    }
}
