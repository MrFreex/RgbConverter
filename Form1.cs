using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RgbConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string freex_truncate(string input,int type)
        {
            if (type == 255)
            {
                float ToReturn = (((float)Math.Truncate((float.Parse(input) / 255) * 10000)) / 10000);
                string ToReturnStr = string.Format("{0}", ToReturn);
                string[] toReturnStr_words = ToReturnStr.Split(',');
                if (toReturnStr_words.Count() == 2)
                {
                    ToReturnStr = string.Format("{0}.{1}", toReturnStr_words[0], toReturnStr_words[1]);
                } else
                {
                    ToReturnStr = string.Format("{0}",ToReturnStr);
                }
                return ToReturnStr;
            } else {
                string[] splittedInput = input.Split('.');
                if (splittedInput.Count() == 2) {
                    var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                    culture.NumberFormat.NumberDecimalSeparator = ".";
                    float inputNum = float.Parse(input,culture);
                    //MessageBox.Show(Convert.ToString(inputNum));
                    
                    string ToReturnStr = string.Format("{0}", (((float)Math.Truncate((inputNum * 255) * 10000)) / 10000));
                    ToReturnStr = ToReturnStr.Replace(',','.');
                    //MessageBox.Show(ToReturnStr);
                    return ToReturnStr;
                } else
                {
                    float inputNum = float.Parse(input);
                    return string.Format("{0}", (((float)Math.Truncate((inputNum * 255) * 10000)) / 10000));
                }
            }
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            string toConvert = toConvert_text.Text;
            string[] toConvert_words = toConvert.Split(',');
            if (toConvert == "" || toConvert_words.Count() != 4)
            {
                MessageBox.Show("Please input a valid text");
            } else
            {
                string firstNumber = toConvert_words[0];
                string secondNumber = toConvert_words[1];
                string thirdNumber = toConvert_words[2];
                string fourthNumber = toConvert_words[3];
                if (inverse_check.Checked)
                {
                    firstNumber = freex_truncate(firstNumber, 1);
                    secondNumber = freex_truncate(secondNumber, 1);
                    thirdNumber = freex_truncate(thirdNumber, 1);
                    fourthNumber = freex_truncate(fourthNumber, 1);
                    if (!(firstNumber == "error" || secondNumber == "error" || thirdNumber == "error" || fourthNumber == "error")) {
                            converted_text.Text = string.Format("{0},{1},{2},{3}", firstNumber, secondNumber, thirdNumber, fourthNumber);
                    } else
                    {
                        converted_text.Text = "Syntax Error";
                    }

                } else
                {
                    firstNumber = freex_truncate(firstNumber, 255);
                    secondNumber = freex_truncate(secondNumber, 255);
                    thirdNumber = freex_truncate(thirdNumber, 255);
                    fourthNumber = freex_truncate(fourthNumber, 255);
                    if (!noArma3_check.Checked)
                    {
                        if (!(firstNumber == "error" || secondNumber == "error" || thirdNumber == "error" || fourthNumber == "error"))
                        {
                            converted_text.Text = string.Format("#(rgb,8,8,3)color({0},{1},{2},{3});", firstNumber, secondNumber, thirdNumber, fourthNumber);
                        } else
                        {
                            converted_text.Text = "Syntax Error";
                        }
                    }
                    else
                    {
                        if (!(firstNumber == "error" || secondNumber == "error" || thirdNumber == "error" || fourthNumber == "error"))
                        {
                            converted_text.Text = string.Format("{0},{1},{2},{3}", firstNumber, secondNumber, thirdNumber, fourthNumber);
                        } else
                        {
                            converted_text.Text = "Syntax Error";
                        }
                    }
                }
                
            }
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(converted_text.Text);
        }
    }
}
