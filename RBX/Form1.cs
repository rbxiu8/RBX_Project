﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RBX
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {            
            game.NextStep();
            pictureBox1.Image = gameTimer.BMP;
        }

        private void browseBtn1_Click(object sender, EventArgs e)
        {
           
            if  (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (((Button)sender).Name)
                {
                    case "browseBtn1":
                        {
                            dllPath1.Text = openFileDialog.FileName;
                            break;
                        }
                    case "browseBtn2":
                        {
                            dllPath2.Text = openFileDialog.FileName;
                            break;
                        }
                    case "browseBtn3":
                        {
                            dllPath3.Text = openFileDialog.FileName;
                            break;
                        }
                }
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            game = new Game(dllPath1.Text, dllPath2.Text, dllPath3.Text, 600, 600);
            gameTimer.Enabled = true;
            
        }
    }
}
