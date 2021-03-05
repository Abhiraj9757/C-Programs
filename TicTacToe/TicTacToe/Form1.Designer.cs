namespace TicTacToe
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
            this.A00 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Draw = new System.Windows.Forms.Label();
            this.Owin = new System.Windows.Forms.Label();
            this.Xwin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(12, 12);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(119, 112);
            this.A00.TabIndex = 0;
            this.A00.TabStop = false;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(12, 129);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(119, 112);
            this.A10.TabIndex = 1;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(12, 247);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(119, 112);
            this.A20.TabIndex = 2;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(137, 12);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(119, 112);
            this.A01.TabIndex = 3;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(137, 129);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(119, 112);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(137, 247);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(119, 112);
            this.A21.TabIndex = 5;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(262, 12);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(119, 112);
            this.A02.TabIndex = 6;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(262, 130);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(119, 112);
            this.A12.TabIndex = 7;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(262, 247);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(119, 112);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 390);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(104, 36);
            this.button10.TabIndex = 9;
            this.button10.Text = "Start";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(137, 390);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(103, 36);
            this.button11.TabIndex = 10;
            this.button11.Text = "Reset";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(262, 390);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(103, 36);
            this.button12.TabIndex = 11;
            this.button12.Text = "Exit";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Draw
            // 
            this.Draw.AutoSize = true;
            this.Draw.Location = new System.Drawing.Point(419, 294);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(51, 20);
            this.Draw.TabIndex = 13;
            this.Draw.Text = "label1";
            // 
            // Owin
            // 
            this.Owin.AutoSize = true;
            this.Owin.Location = new System.Drawing.Point(419, 176);
            this.Owin.Name = "Owin";
            this.Owin.Size = new System.Drawing.Size(51, 20);
            this.Owin.TabIndex = 14;
            this.Owin.Text = "label1";
            // 
            // Xwin
            // 
            this.Xwin.AutoSize = true;
            this.Xwin.Location = new System.Drawing.Point(419, 58);
            this.Xwin.Name = "Xwin";
            this.Xwin.Size = new System.Drawing.Size(51, 20);
            this.Xwin.TabIndex = 15;
            this.Xwin.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.Xwin);
            this.Controls.Add(this.Owin);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label Draw;
        private System.Windows.Forms.Label Owin;
        private System.Windows.Forms.Label Xwin;
    }
}

