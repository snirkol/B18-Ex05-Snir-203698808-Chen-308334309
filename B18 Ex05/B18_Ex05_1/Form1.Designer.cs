namespace B18_Ex05_1
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.labelPlayr1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.CheckBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.TextBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 36);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "6X6";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(221, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 36);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "8X8";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(451, 48);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(135, 36);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "10X10";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroupBox
            // 
            this.radioButtonGroupBox.Controls.Add(this.radioButton1);
            this.radioButtonGroupBox.Controls.Add(this.radioButton3);
            this.radioButtonGroupBox.Controls.Add(this.radioButton2);
            this.radioButtonGroupBox.Location = new System.Drawing.Point(28, 49);
            this.radioButtonGroupBox.Name = "radioButtonGroupBox";
            this.radioButtonGroupBox.Size = new System.Drawing.Size(705, 101);
            this.radioButtonGroupBox.TabIndex = 4;
            this.radioButtonGroupBox.TabStop = false;
            this.radioButtonGroupBox.Text = "Board Size";
            // 
            // labelPlayr1
            // 
            this.labelPlayr1.AutoSize = true;
            this.labelPlayr1.Location = new System.Drawing.Point(49, 236);
            this.labelPlayr1.Name = "labelPlayr1";
            this.labelPlayr1.Size = new System.Drawing.Size(127, 32);
            this.labelPlayr1.TabIndex = 5;
            this.labelPlayr1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Players:";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(249, 236);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(180, 38);
            this.textBoxPlayer1.TabIndex = 7;
            // 
            // CheckBoxPlayer2
            // 
            this.CheckBoxPlayer2.AutoSize = true;
            this.CheckBoxPlayer2.Location = new System.Drawing.Point(55, 298);
            this.CheckBoxPlayer2.Name = "CheckBoxPlayer2";
            this.CheckBoxPlayer2.Size = new System.Drawing.Size(165, 36);
            this.CheckBoxPlayer2.TabIndex = 8;
            this.CheckBoxPlayer2.Text = "PLyer 2: ";
            this.CheckBoxPlayer2.UseVisualStyleBackColor = true;
            this.CheckBoxPlayer2.CheckedChanged += new System.EventHandler(this.CheckBoxPlayer2_CheckedChanged);
            // 
            // TextBoxPlayer2
            // 
            this.TextBoxPlayer2.Enabled = false;
            this.TextBoxPlayer2.Location = new System.Drawing.Point(249, 298);
            this.TextBoxPlayer2.Name = "TextBoxPlayer2";
            this.TextBoxPlayer2.Size = new System.Drawing.Size(180, 38);
            this.TextBoxPlayer2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 64);
            this.button1.TabIndex = 10;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxPlayer2);
            this.Controls.Add(this.CheckBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPlayr1);
            this.Controls.Add(this.radioButtonGroupBox);
            this.Name = "Form1";
            this.Text = "Game Settings";
            this.radioButtonGroupBox.ResumeLayout(false);
            this.radioButtonGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox radioButtonGroupBox;
        private System.Windows.Forms.Label labelPlayr1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.CheckBox CheckBoxPlayer2;
        private System.Windows.Forms.TextBox TextBoxPlayer2;
        private System.Windows.Forms.Button button1;
    }
}

