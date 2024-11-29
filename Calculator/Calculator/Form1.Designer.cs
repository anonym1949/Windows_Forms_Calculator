namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonpoint = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonMod = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.textBoxVariables = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HistoryLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPlus.FlatAppearance.BorderSize = 5;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.ImageIndex = 1;
            this.buttonPlus.Location = new System.Drawing.Point(224, 232);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(68, 54);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // buttonSub
            // 
            this.buttonSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.ImageIndex = 1;
            this.buttonSub.Location = new System.Drawing.Point(224, 391);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(68, 53);
            this.buttonSub.TabIndex = 1;
            this.buttonSub.Text = "÷";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // buttonMul
            // 
            this.buttonMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMul.ImageIndex = 1;
            this.buttonMul.Location = new System.Drawing.Point(224, 335);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(68, 54);
            this.buttonMul.TabIndex = 2;
            this.buttonMul.Text = "×";
            this.buttonMul.UseVisualStyleBackColor = false;
            this.buttonMul.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMin.ImageIndex = 1;
            this.buttonMin.Location = new System.Drawing.Point(224, 282);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(68, 54);
            this.buttonMin.TabIndex = 3;
            this.buttonMin.Text = "-";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.Cyan;
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.ImageIndex = 1;
            this.buttonEqual.Location = new System.Drawing.Point(76, 390);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(142, 54);
            this.buttonEqual.TabIndex = 4;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageIndex = 1;
            this.button4.Location = new System.Drawing.Point(2, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 54);
            this.button4.TabIndex = 16;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ImageIndex = 1;
            this.button7.Location = new System.Drawing.Point(2, 282);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 54);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageIndex = 1;
            this.button1.Location = new System.Drawing.Point(2, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 54);
            this.button1.TabIndex = 13;
            this.button1.Tag = "";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageIndex = 1;
            this.button5.Location = new System.Drawing.Point(76, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 54);
            this.button5.TabIndex = 19;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ImageIndex = 1;
            this.button8.Location = new System.Drawing.Point(76, 282);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 54);
            this.button8.TabIndex = 18;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageIndex = 1;
            this.button2.Location = new System.Drawing.Point(76, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 54);
            this.button2.TabIndex = 17;
            this.button2.Tag = "";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ImageIndex = 1;
            this.button6.Location = new System.Drawing.Point(150, 232);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 54);
            this.button6.TabIndex = 22;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ImageIndex = 1;
            this.button9.Location = new System.Drawing.Point(150, 282);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 54);
            this.button9.TabIndex = 21;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 5;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageIndex = 1;
            this.button3.Location = new System.Drawing.Point(150, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 54);
            this.button3.TabIndex = 20;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button0.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ImageIndex = 1;
            this.button0.Location = new System.Drawing.Point(2, 335);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(68, 54);
            this.button0.TabIndex = 23;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonpoint
            // 
            this.buttonpoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonpoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpoint.ImageIndex = 1;
            this.buttonpoint.Location = new System.Drawing.Point(76, 335);
            this.buttonpoint.Name = "buttonpoint";
            this.buttonpoint.Size = new System.Drawing.Size(68, 54);
            this.buttonpoint.TabIndex = 24;
            this.buttonpoint.Text = ".";
            this.buttonpoint.UseVisualStyleBackColor = false;
            this.buttonpoint.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.DimGray;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(2, 131);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(290, 49);
            this.textBoxResult.TabIndex = 25;
            // 
            // buttonMod
            // 
            this.buttonMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.ImageIndex = 1;
            this.buttonMod.Location = new System.Drawing.Point(150, 335);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(68, 54);
            this.buttonMod.TabIndex = 26;
            this.buttonMod.Text = "%";
            this.buttonMod.UseVisualStyleBackColor = false;
            this.buttonMod.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 36);
            this.panel1.TabIndex = 30;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Image = global::Calculator.Properties.Resources.icons8_minimize_32;
            this.button13.Location = new System.Drawing.Point(213, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 28);
            this.button13.TabIndex = 33;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Image = global::Calculator.Properties.Resources.icons8_minimize_sign_321;
            this.button12.Location = new System.Drawing.Point(175, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(32, 28);
            this.button12.TabIndex = 32;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Image = global::Calculator.Properties.Resources.this_close;
            this.button11.Location = new System.Drawing.Point(251, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(32, 28);
            this.button11.TabIndex = 31;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // ButtonDel
            // 
            this.ButtonDel.BackColor = System.Drawing.Color.Black;
            this.ButtonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonDel.FlatAppearance.BorderSize = 5;
            this.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDel.Image = global::Calculator.Properties.Resources.icons8_delete_key_50;
            this.ButtonDel.Location = new System.Drawing.Point(224, 180);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(68, 54);
            this.ButtonDel.TabIndex = 31;
            this.ButtonDel.UseVisualStyleBackColor = false;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button10.FlatAppearance.BorderSize = 5;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Image = global::Calculator.Properties.Resources.icons8_reset_24;
            this.button10.Location = new System.Drawing.Point(2, 390);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 54);
            this.button10.TabIndex = 27;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.ButtonReset);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button14.FlatAppearance.BorderSize = 5;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(2, 445);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(290, 44);
            this.button14.TabIndex = 32;
            this.button14.Text = "History";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBoxVariables
            // 
            this.textBoxVariables.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxVariables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVariables.Location = new System.Drawing.Point(2, 38);
            this.textBoxVariables.Multiline = true;
            this.textBoxVariables.Name = "textBoxVariables";
            this.textBoxVariables.ReadOnly = true;
            this.textBoxVariables.Size = new System.Drawing.Size(290, 100);
            this.textBoxVariables.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.HistoryLbl);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(2, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 313);
            this.panel2.TabIndex = 33;
            this.panel2.Visible = false;
            // 
            // HistoryLbl
            // 
            this.HistoryLbl.AutoSize = true;
            this.HistoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryLbl.ForeColor = System.Drawing.Color.White;
            this.HistoryLbl.Location = new System.Drawing.Point(10, 19);
            this.HistoryLbl.Name = "HistoryLbl";
            this.HistoryLbl.Size = new System.Drawing.Size(72, 18);
            this.HistoryLbl.TabIndex = 0;
            this.HistoryLbl.Text = "History :";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(294, 494);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.textBoxVariables);
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonpoint);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.button9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonpoint;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button ButtonDel;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBoxVariables;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HistoryLbl;
    }
}

