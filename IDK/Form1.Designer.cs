namespace IDK
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNeg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(12, 30);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(219, 20);
            this.txtConsole.TabIndex = 20;
            this.txtConsole.TabStop = false;
            this.txtConsole.Text = "0";
            this.txtConsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(156, 85);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(47, 66);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(29, 23);
            this.btnSub.TabIndex = 13;
            this.btnSub.Text = "&-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(82, 66);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(29, 23);
            this.btnMult.TabIndex = 14;
            this.btnMult.Text = " &x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(117, 66);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(29, 23);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "&/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 114);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 37);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "&1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.num_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(60, 114);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 37);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "&2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.num_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(108, 114);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 37);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "&3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.num_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 157);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(42, 37);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "&4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.num_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(60, 157);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 37);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "&5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.num_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(108, 157);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(42, 37);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "&6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.num_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 200);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(42, 37);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "&7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.num_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(60, 200);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(42, 37);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "&8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.num_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(108, 200);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(42, 37);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "&9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.num_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 243);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(42, 37);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "&0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.num_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(60, 243);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(42, 37);
            this.btnDot.TabIndex = 10;
            this.btnDot.Text = "&.";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.num_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(156, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(156, 114);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 123);
            this.btnEnter.TabIndex = 18;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(156, 56);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label";
            // 
            // btnNeg
            // 
            this.btnNeg.Location = new System.Drawing.Point(108, 243);
            this.btnNeg.Name = "btnNeg";
            this.btnNeg.Size = new System.Drawing.Size(42, 37);
            this.btnNeg.TabIndex = 11;
            this.btnNeg.Text = "(&-)";
            this.btnNeg.UseVisualStyleBackColor = true;
            this.btnNeg.Click += new System.EventHandler(this.num_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 300);
            this.Controls.Add(this.btnNeg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtConsole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Aaron\'s Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNeg;
    }
}

