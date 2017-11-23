﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PAIN_Forms
{
    public partial class CarAdd : Form
    {
        ParentView parent;

        public CarAdd(ParentView parent_, int initImage_)
        {
            InitializeComponent();

            tableLayoutPanel1.Controls.Add(chooser, 1, 4);
            tableLayoutPanel1.SetColumnSpan(chooser, 2);

            parent = parent_;
            chooser.imageIndex = initImage_;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            BrandTextBox_Validated(null, null);
            ProdYearTextBox_Validated(null, null);
            MaxVelocityTextBox_Validated(null, null);
            if(
                errorProvider1.GetError(BrandTextBox)    == String.Empty &&
                errorProvider1.GetError(ProdYearTextBox)      == String.Empty &&
                errorProvider1.GetError(MaxVelocityTextBox) == String.Empty
              )
            {
                Car c = new PAIN_Forms.Car(
                    0,
                    BrandTextBox.Text,
                    int.Parse(MaxVelocityTextBox.Text),
                    int.Parse(ProdYearTextBox.Text),
                    chooser.choosedType
                );
                parent.AddCar(c);
                this.Close();
            }
            
        }

        private void choosed_typeChanged(object sender, CarTypeChanged e)
        {
            typeTextBox.Text = e.newType;
        }

        private void BrandTextBox_Validated(object sender, EventArgs e)
        {
            if(BrandTextBox.Text == "")
            {
                errorProvider1.SetError(BrandTextBox, "Fill this field!");
            }
            else if(!new Regex("^[A-Z][A-Za-z 0-9]+$").IsMatch(BrandTextBox.Text))
            {
                errorProvider1.SetError(
                    BrandTextBox,
                    "First letter is big, minimal length 2!"
                );
            }
            else
            {
                errorProvider1.SetError(BrandTextBox, String.Empty);
            }
        }

        private void ProdYearTextBox_Validated(object sender, EventArgs e)
        {
            if (ProdYearTextBox.Text == "")
            {
                errorProvider1.SetError(ProdYearTextBox, "Fill this field!");
            }
            else if (!new Regex("^[1-2][0-9][0-9][0-9]$").IsMatch(ProdYearTextBox.Text))
            {
                errorProvider1.SetError(
                    ProdYearTextBox,
                    "YYYY!"
                );
            }
            else
            {
                errorProvider1.SetError(ProdYearTextBox, String.Empty);
            }
        }

        private void MaxVelocityTextBox_Validated(object sender, EventArgs e)
        {
            if (MaxVelocityTextBox.Text == "")
            {
                errorProvider1.SetError(MaxVelocityTextBox, "Fill this field!");
            }
            else if (!new Regex("^[0-9]+$").IsMatch(MaxVelocityTextBox.Text))
            {
                errorProvider1.SetError(
                    MaxVelocityTextBox,
                    "Only numbers!"
                );
            }
            else
            {
                errorProvider1.SetError(MaxVelocityTextBox, String.Empty);
            }
        }
    }
}
