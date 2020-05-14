using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie17_WagiMiaryPredkosci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        public void IncorrectInputValue()
        {
            textBox_Conversion.Text = String.Empty;
            textBox_Conversion.BackColor = Color.Red;
            lbl_UnitsInfo.Text = "Input should be number greater than zero !!!";
        }


        private void listBox_UnitsToConvert_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (listBox_UnitsToConvert.SelectedIndex)
            {

                case 0:     // Gram->Ounce

                    if (numUpDown_Input.Value <= 0)
                    {
                        IncorrectInputValue();
                    }
                    else
                    {
                        textBox_Conversion.BackColor = Color.White;
                        textBox_Conversion.Text = String.Format((numUpDown_Input.Value * 0.03527m).ToString());

                        if (textBox_Conversion.Text == "1")
                        {
                            lbl_UnitsInfo.Text = "ounce";
                        }
                        else
                        {
                            lbl_UnitsInfo.Text = "ounces";
                        }
                    }
                    break;

                case 1:     // Ounce->Gram

                    if (numUpDown_Input.Value <= 0)
                    {
                        IncorrectInputValue();
                    }
                    else
                    {

                        textBox_Conversion.BackColor = Color.White;
                        textBox_Conversion.Text = String.Format((numUpDown_Input.Value * 28.3495m).ToString());
                        if (textBox_Conversion.Text == "1")
                        {
                            lbl_UnitsInfo.Text = "gram";
                        }
                        else
                        {
                            lbl_UnitsInfo.Text = "grams";
                        }
                    }
                    break;

                case 2:     // Kilogram->Pound

                    if (numUpDown_Input.Value <= 0)
                    {
                        IncorrectInputValue();
                    }
                    else
                    {
                        textBox_Conversion.BackColor = Color.White;
                        textBox_Conversion.Text = String.Format((numUpDown_Input.Value * 2.2046m).ToString());
                        if (textBox_Conversion.Text == "1")
                        {
                            lbl_UnitsInfo.Text = "pound";
                        }
                        else
                        {
                            lbl_UnitsInfo.Text = "pounds";
                        }
                    }
                    break;

                 case 3:     // Pound->Kilogram

                    if (numUpDown_Input.Value <= 0)
                    {
                        IncorrectInputValue();
                    }
                    else
                    {
                        textBox_Conversion.BackColor = Color.White;
                        textBox_Conversion.Text = String.Format((numUpDown_Input.Value * 0.45359m).ToString());
                        if (textBox_Conversion.Text == "1")
                        {
                            lbl_UnitsInfo.Text = "kilogram";
                        }
                        else
                        {
                            lbl_UnitsInfo.Text = "kilograms";
                        }
                    }
                    break;

                case 4:     // Kilogram->Russian Pound

                    if (numUpDown_Input.Value <= 0)
                    {
                        IncorrectInputValue();
                    }
                    else
                    {
                        textBox_Conversion.BackColor = Color.White;
                        textBox_Conversion.Text = String.Format((numUpDown_Input.Value * 2.44189m).ToString());
                        if (textBox_Conversion.Text == "1")
                        {
                            lbl_UnitsInfo.Text = "Russian pound";
                        }
                        else
                        {
                            lbl_UnitsInfo.Text = "Russian pounds";
                        }
                    }
                    break;

                case 5:     // Russian Pound->Kilogram

                    if (numUpDown_Input.Value <= 0)
                    {
                        IncorrectInputValue();
                    }
                    else
                    {
                        textBox_Conversion.BackColor = Color.White;
                        textBox_Conversion.Text = String.Format((numUpDown_Input.Value * 0.4095m).ToString());
                        if (textBox_Conversion.Text == "1")
                        {
                            lbl_UnitsInfo.Text = "Russian pound";
                        }
                        else
                        {
                            lbl_UnitsInfo.Text = "Russian pounds";
                        }
                    }
                    break;

                case 6:     // Celsius->Fahrenheit

                    textBox_Conversion.BackColor = Color.White;
                    textBox_Conversion.Text = String.Format(((numUpDown_Input.Value * 1.8m) + 32m).ToString());
                    if (textBox_Conversion.Text == "1")
                    {
                        lbl_UnitsInfo.Text = "degree Fahrenheit";
                    }
                    else
                    {
                        lbl_UnitsInfo.Text = "degrees Fahrenheit";
                    }
                    break;

                case 7:     // Farhenheit->Cel

                    textBox_Conversion.BackColor = Color.White;
                    textBox_Conversion.Text = String.Format(((numUpDown_Input.Value - 32m) * 0.555m ).ToString());
                    if (textBox_Conversion.Text == "1")
                    {
                        lbl_UnitsInfo.Text = "degree Celsius";
                    }
                    else
                    {
                        lbl_UnitsInfo.Text = "degrees Celsius";
                    }
                    break;

               case 8:     // Kilometer per hour->Knot

                    if (numUpDown_Input.Value <= 0)
                    {
                        IncorrectInputValue();
                    }
                    else
                    {
                        textBox_Conversion.BackColor = Color.White;
                        textBox_Conversion.Text = String.Format((numUpDown_Input.Value * 0.5399m).ToString());
                        if (textBox_Conversion.Text == "1")
                        {
                            lbl_UnitsInfo.Text = "knot";
                        }
                        else
                        {
                            lbl_UnitsInfo.Text = "knots";
                        }
                    }
                    break;

                case 9:     // Knot->Kilometer per hour

                    if (numUpDown_Input.Value <= 0)
                    {
                        IncorrectInputValue();
                    }
                    else
                    {
                        textBox_Conversion.BackColor = Color.White;
                        textBox_Conversion.Text = String.Format((numUpDown_Input.Value * 1.852m).ToString());
                        if (textBox_Conversion.Text == "1")
                        {
                            lbl_UnitsInfo.Text = "kilometer per hour";
                        }
                        else
                        {
                            lbl_UnitsInfo.Text = "kilometers per hour";
                        }
                    }
                    break;

                case 10:     // Meter->Yard

                    if (numUpDown_Input.Value <= 0)
                    {
                        IncorrectInputValue();
                    }
                    else
                    {
                        textBox_Conversion.BackColor = Color.White;
                        textBox_Conversion.Text = String.Format((numUpDown_Input.Value * 1.0936m).ToString());
                        if (textBox_Conversion.Text == "1")
                        {
                            lbl_UnitsInfo.Text = "yard";
                        }
                        else
                        {
                            lbl_UnitsInfo.Text = "yards";
                        }
                    }
                    break;

                case 11:     // Yard->Meter

                    if (numUpDown_Input.Value <= 0)
                    {
                        IncorrectInputValue();
                    }
                    else
                    {
                        textBox_Conversion.BackColor = Color.White;
                        textBox_Conversion.Text = String.Format((numUpDown_Input.Value * 0.9144m).ToString());
                        if (textBox_Conversion.Text == "1")
                        {
                            lbl_UnitsInfo.Text = "meter";
                        }
                        else
                        {
                            lbl_UnitsInfo.Text = "meters";
                        }
                    }
                    break;

                case 12:     // Liter - US Liqiud Gallon

                    if (numUpDown_Input.Value <= 0)
                    {
                        IncorrectInputValue();
                    }
                    else
                    {
                        textBox_Conversion.BackColor = Color.White;
                        textBox_Conversion.Text = String.Format((numUpDown_Input.Value * 0.26417m).ToString());
                        if (textBox_Conversion.Text == "1")
                        {
                            lbl_UnitsInfo.Text = "gallon";
                        }
                        else
                        {
                            lbl_UnitsInfo.Text = "gallons";
                        }
                    }
                    break;

                case 13:     // US Liquid Gallon - Liter

                    if (numUpDown_Input.Value <= 0)
                    {
                        IncorrectInputValue();
                    }
                    else
                    {
                        textBox_Conversion.BackColor = Color.White;
                        textBox_Conversion.Text = String.Format((numUpDown_Input.Value * 3.7854m).ToString());
                        if (textBox_Conversion.Text == "1")
                        {
                            lbl_UnitsInfo.Text = "liter";
                        }
                        else
                        {
                            lbl_UnitsInfo.Text = "liters";
                        }
                    }
                    break;

                default:
                    break;

            }
        }

        private void btn_ClearEntry_Click(object sender, EventArgs e)
        {
            textBox_Conversion.BackColor = Color.White;
            textBox_Conversion.Text = String.Empty;
            lbl_UnitsInfo.Text = String.Empty;
            numUpDown_Input.Value = 0;
            listBox_UnitsToConvert.ClearSelected();
        }
    }
}
