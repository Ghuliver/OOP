using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Dronecontroller : Component
    {
        public Dronecontroller()
        {
            InitializeComponent();
        }
        public string model { get; set; }
        public int batterylevel { get; set; }
        public Dronecontroller(string model)
        {
            model = model;
            batterylevel = 100;
        }
        public void takeoff()
        {
            batterylevel -= 10;
        }
        public void land()
        {
            batterylevel -= 5;
        }

        public void fly(int distance)
        {
           
            
        }
    }
  }
