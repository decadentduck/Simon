﻿/*
Created by Kaitlyn Ewing probably in February 
Simon Program 
game based off of the original simon game
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class Form1 : Form
    {
        public static List<int> pattern = new List<int>();

        public Form1()
        {
            InitializeComponent();
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }
        
    }
}
