using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calculator
{
    public partial class Calculator : Form
    {
        public Point mouseLocation;
        public Calculator()
        {
            InitializeComponent();
            textBoxResult.Text = "Result : ";
            HistoryLbl.Text += Environment.NewLine;

        }




        static double FirstValue = 0;
        static string FirstValueAsString = "";

        static double SecondValue = 0;
        static string SecondValueAsString = "";

      
        static double Result = 0;
        static string Operation = "";


        static int CounterForLbl = 1;

        private string EditTextBoxVariable(string V1 ,string V2="",string OP="",string EQ="")
        {
            return V1 + V2 + OP +EQ;
        }

        private void buttonNumberClick(object sender, EventArgs e)
        {
            
           
            if(Operation !="")
            {
                SecondValueAsString += ((Button)sender).Text;
                SecondValue = Convert.ToDouble(SecondValueAsString);
                textBoxVariables.Text = EditTextBoxVariable(FirstValue.ToString(),Operation,SecondValueAsString,"=");
                PrintResult();
                return;
            }            




             FirstValueAsString += ((Button)sender).Text;
             FirstValue= Convert.ToDouble(FirstValueAsString);
             textBoxVariables.Text = EditTextBoxVariable(FirstValueAsString);

             PrintResult();
        }

        void PrintResult()
        {
           
            Result = CalculResult(FirstValue, SecondValue, Operation);
           
            textBoxResult.Text = Result.ToString();

            DisableAllOP(true);

            
        }

        private Double CalculResult(double FirstValue , double SecondValue=0 , string OP = "")
        {
           switch(OP)
            {
                case"+":
                    return (FirstValue + SecondValue);
                   

                case "-":
                    return (FirstValue - SecondValue);
                   

                case "×":
                    return (FirstValue * SecondValue);

                case "÷":
                    return( FirstValue / SecondValue);

                case "%":
                    return (FirstValue % SecondValue);

                case "":
                    return (FirstValue) ;


                default:
                    return -1;

            }
        }

       private void ButtonReset(object sender, EventArgs e)
        {
             FirstValue = 0;
             FirstValueAsString = "";

             SecondValue = 0;
             SecondValueAsString = "";


             Result = 0;
             Operation = "";


            textBoxResult.Text = "";
            textBoxVariables.Text = "";


            DisableAllOP(true);
        }

        private void DisableAllOP(bool C)
        {
            buttonPlus.Enabled =C;
            buttonSub.Enabled = C;
            buttonMin.Enabled = C;
            buttonMul.Enabled = C;
            buttonMod.Enabled = C;

        }


        private void buttonOperationClick(object sender, EventArgs e)
        {
            Button Info =((Button)sender);

            Operation = Info.Text;

            textBoxVariables.Text += Operation;

         
            if (SecondValue==0)
            {
                textBoxResult.Text = FirstValueAsString;
                DisableAllOP(false);
                
                return;
            }

            if(FirstValue!=0 && SecondValue !=0 && Result==0)
            {
                DisableAllOP(true);
                PrintResult();
                FirstValue = Result;
                textBoxVariables.Text = Result.ToString() + Operation;
                Result = 0;
                SecondValue=0;
                SecondValueAsString = "";
                 return;
            }

            if(Result>0)
            {
               
                textBoxVariables.Text = Result.ToString() + Operation;
                FirstValue = Result;
                SecondValueAsString = "";
             

            }




        }


        private void buttonEqual_Click(object sender, EventArgs e)
        {
            PrintResult();
            if (FirstValue != 0 && SecondValue != 0)
            {
                HistoryLbl.Text += FirstValue.ToString() + Operation + SecondValue.ToString() + "=" + Result.ToString() + Environment.NewLine;
            }

        }

     
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
           

        }



        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if(Operation=="" && SecondValue==0)
            {
              

                if (FirstValueAsString.Length == 1 || FirstValueAsString.Length == 0) 
                {
                    FirstValueAsString = "";
                    FirstValue = 0;
                    textBoxResult.Clear();
                    textBoxVariables.Clear();

                    return;
                }


                FirstValueAsString = FirstValueAsString.Substring(0,FirstValueAsString.Length-1);

                FirstValue =Convert.ToDouble( FirstValueAsString);

                textBoxVariables.Text = EditTextBoxVariable(FirstValueAsString);

                PrintResult();
                return;
            }



            if (Operation != "" && SecondValue==0)
            {
                if(textBoxVariables.Text.Length == 0)
                {
                    return;
                }

                Operation = "";
                DisableAllOP(true);
                textBoxVariables.Text = textBoxVariables.Text.Substring(0,textBoxVariables.Text.Length-1);
                return;
            }


           

            if (SecondValueAsString.Length == 1 || SecondValueAsString.Length == 0)
            {
                SecondValueAsString = "";
                SecondValue = 0;

                
                return;
            }

            SecondValueAsString = SecondValueAsString.Substring(0, SecondValueAsString.Length - 1);

            SecondValue = Convert.ToDouble(SecondValueAsString);

            textBoxVariables.Text = EditTextBoxVariable(FirstValue.ToString(), Operation, SecondValue.ToString(), "=");
           
            PrintResult();
           

        }

        private void button14_Click(object sender, EventArgs e)
        {

            if(CounterForLbl%2!=0)
            {
                panel2.Visible = true;
                CounterForLbl++;
                return;
            }

            if (CounterForLbl % 2 == 0)
            {
                panel2.Visible = false;
                CounterForLbl++;
            }







        }
    }
}
