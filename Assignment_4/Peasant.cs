/**************
 * Josh Romito
 * CP_220
 * Assignment 4
 **************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Assignment_4
{
    class Peasant
    {
        //Fields 
        private Stopwatch _lifetime = new Stopwatch();
        private string _name;
        private double _eventOccurance;
        private int _occurance;
        private ListBox _peasantOutput;

        //Properties
        public ListBox peasantOutput { get { return _peasantOutput; } set { _peasantOutput = value; } }
        public string name { get { return _name; } set { _name = value; } }

        //Method to grab the current elapsed time of the peds life
        public int UpTime()
        {
            return (int)_lifetime.Elapsed.TotalMilliseconds;
        }

        //Constructor - takes in a listbox (added the listbox, or else we would not be able to decide where the output is going!), a string, and a random number (this was done so that the event occurance time would be more random).
        //assigns the name and listbox respectively, starts the stop watch, and invokes a delegate action in order to perform cross-threading procedures
        public Peasant(ListBox listbox, string name, Random r)
        {
            _name = name;
            _peasantOutput = listbox;
            Action init = () => _peasantOutput.Items.Add("Peasant " + _name + " was born into the world...");
            _peasantOutput.Invoke(init);
            Debug.WriteLine("Peasant " + _name + " was born into the world...");
            _lifetime.Start();
            //using my Random extension to generate a double between 0.5 and 2.0
            _eventOccurance = r.RandomDecimal(0.5, 2.0);
        }

        //live life async method - passing in the same random variable created in the main form - 
        public async Task liveLifeAsync(Random r)
        {
            await Task.Run(() =>
            {
                //setting the eventOccurance to milliseconds format
                _eventOccurance *= 1000;
                //casting the double to an int.... so it can be used with Thread.Sleep() 
                _occurance = (int)_eventOccurance;

                //loop for the peds lifespan (15 secs)
                while (_lifetime.ElapsedMilliseconds <= 15000)
                {
                    //generating a random scenario string - of things to do w/ stuff
                    string scenario = ThingsToDo.stuff[r.Next(0, 10)];
                    //sleeping the amount of the event occurance time
                    Thread.Sleep(_occurance);
                    //Action delegate
                    Action update = () => Print(_name, UpTime(), scenario);
                    //delegate invoked
                    _peasantOutput.Invoke(update);
                    Debug.WriteLine("At age " + UpTime() + ", " + _name + " was " + scenario);
                }
                //When the life is over.. we output dead to the listbox
                Action finish = () => _peasantOutput.Items.Add("Dead");
                _peasantOutput.Invoke(finish);
                Debug.WriteLine("Done");
            });
        }

        //just a method to print to the required data to the list box
        public string Print(string name, double life, string task)
        {
            string output = ("At age " + life.ToString() + ", " + name + " was " + task.ToString());
            peasantOutput.Items.Add(output);
            return output;
        }
    }


    //fancy pants extension method :)  used to generate a random double with an easy to use min/max
    public static class Randomizer
    {
        public static double RandomDecimal(this Random r, double min, double max)
        {
            return r.NextDouble() * (max - min) + min;
        }
    }

    //static class to hold all the things...
    public static class ThingsToDo
    {
        public static string[] stuff = new string[10] 
        {
            "working...", "protecting the farm...", "running scared...!?",
            "eating...", "sleeping...", "staring at a wall...", "mixing moonshine...",
            "in jail...", "not being smart...", "drinking moonshine..."
        };
    }
}

