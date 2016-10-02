using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlokusBot
{
    public partial class Interface : Form
    {
        // temp vars
        public CheckBox[] boxes = new CheckBox[196];
        public bool curPlayer = true;
        public Color[,] boxColor = {
            {System.Drawing.Color.BurlyWood ,System.Drawing.Color.DarkOrange} , 
            {System.Drawing.Color.Violet  ,System.Drawing.Color.DarkViolet}
        };

        public Interface()
        {
            InitializeComponent();

            // Get all boxes in one array
            int ind = 0;
            foreach (Control c in this.Controls)
            {                
                if (c is CheckBox)
                {
                    boxes[ind++] = c as CheckBox;
                    boxes[ind-1].CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
                }
            }

            //Set inital player turn label
            lblCurrentTurn.Text = "Player " + (curPlayer ? "1":"2");
        }

        
        private void btnConfirmMove_Click(object sender, EventArgs e)
        {
            //disables all checked boxes
            foreach (CheckBox cb in boxes)
            {
                if (cb.Checked)
                {
                    cb.BackColor = boxColor[(curPlayer ? 0 : 1), 1];
                    cb.Enabled = false;
                    cb.Checked = false;
                }
            }
            //updates player turn label
            curPlayer = !curPlayer;
            lblCurrentTurn.Text = "Player " + (curPlayer ? "1" : "2");
            
        }

        //When any of the checkboxes gets changed
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Enabled)
            {
                if (cb.BackColor == System.Drawing.SystemColors.ControlDark)
                    cb.BackColor = boxColor[(curPlayer ? 0 : 1), 0];
                else
                    cb.BackColor = System.Drawing.SystemColors.ControlDark;
            }
        }
    }
}
