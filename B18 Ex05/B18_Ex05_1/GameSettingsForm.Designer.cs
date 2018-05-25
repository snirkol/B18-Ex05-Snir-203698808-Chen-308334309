namespace B18_Ex05_1
{
    partial class GameSettingsForm
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
            this.CenterToScreen();
            this.radioButton6X6 = new System.Windows.Forms.RadioButton();
            this.radioButton8X8 = new System.Windows.Forms.RadioButton();
            this.radioButton10X10 = new System.Windows.Forms.RadioButton();
            this.radioButtonGroupBoxSizeOfBoard = new System.Windows.Forms.GroupBox();
            this.labelPlayr1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.CheckBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.TextBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.radioButtonGroupBoxSizeOfBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton6X6
            // 
            this.radioButton6X6.AutoSize = true;
            this.radioButton6X6.Location = new System.Drawing.Point(0, 48);
            this.radioButton6X6.Name = "radioButton6X6";
            this.radioButton6X6.Size = new System.Drawing.Size(103, 36);
            this.radioButton6X6.TabIndex = 1;
            this.radioButton6X6.TabStop = true;
            this.radioButton6X6.Text = "6X6";
            this.radioButton6X6.UseVisualStyleBackColor = true;
            // 
            // radioButton8X8
            // 
            this.radioButton8X8.AutoSize = true;
            this.radioButton8X8.Location = new System.Drawing.Point(221, 48);
            this.radioButton8X8.Name = "radioButton8X8";
            this.radioButton8X8.Size = new System.Drawing.Size(103, 36);
            this.radioButton8X8.TabIndex = 2;
            this.radioButton8X8.TabStop = true;
            this.radioButton8X8.Text = "8X8";
            this.radioButton8X8.UseVisualStyleBackColor = true;
            // 
            // radioButton10X10
            // 
            this.radioButton10X10.AutoSize = true;
            this.radioButton10X10.Location = new System.Drawing.Point(451, 48);
            this.radioButton10X10.Name = "radioButton10X10";
            this.radioButton10X10.Size = new System.Drawing.Size(135, 36);
            this.radioButton10X10.TabIndex = 3;
            this.radioButton10X10.TabStop = true;
            this.radioButton10X10.Text = "10X10";
            this.radioButton10X10.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroupBoxSizeOfBoard
            // 
            this.radioButtonGroupBoxSizeOfBoard.Controls.Add(this.radioButton6X6);
            this.radioButtonGroupBoxSizeOfBoard.Controls.Add(this.radioButton10X10);
            this.radioButtonGroupBoxSizeOfBoard.Controls.Add(this.radioButton8X8);
            this.radioButtonGroupBoxSizeOfBoard.Location = new System.Drawing.Point(28, 30);
            this.radioButtonGroupBoxSizeOfBoard.Name = "radioButtonGroupBoxSizeOfBoard";
            this.radioButtonGroupBoxSizeOfBoard.Size = new System.Drawing.Size(705, 101);
            this.radioButtonGroupBoxSizeOfBoard.TabIndex = 4;
            this.radioButtonGroupBoxSizeOfBoard.TabStop = false;
            this.radioButtonGroupBoxSizeOfBoard.Text = "Board Size";
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
            this.textBoxPlayer1.Size = new System.Drawing.Size(215, 38);
            this.textBoxPlayer1.TabIndex = 7;
            // 
            // CheckBoxPlayer2
            // 
            this.CheckBoxPlayer2.AutoSize = true;
            this.CheckBoxPlayer2.Location = new System.Drawing.Point(55, 298);
            this.CheckBoxPlayer2.Name = "CheckBoxPlayer2";
            this.CheckBoxPlayer2.Size = new System.Drawing.Size(156, 36);
            this.CheckBoxPlayer2.TabIndex = 8;
            this.CheckBoxPlayer2.Text = "Plyer 2: ";
            this.CheckBoxPlayer2.UseVisualStyleBackColor = true;
            this.CheckBoxPlayer2.CheckedChanged += new System.EventHandler(this.CheckBoxPlayer2_CheckedChanged);
            // 
            // TextBoxPlayer2
            // 
            this.TextBoxPlayer2.Enabled = false;
            this.TextBoxPlayer2.Location = new System.Drawing.Point(249, 298);
            this.TextBoxPlayer2.Name = "TextBoxPlayer2";
            this.TextBoxPlayer2.Size = new System.Drawing.Size(215, 38);
            this.TextBoxPlayer2.TabIndex = 9;
            this.TextBoxPlayer2.Text = "[Computer]";
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(479, 374);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(254, 64);
            this.buttonDone.TabIndex = 10;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.TextBoxPlayer2);
            this.Controls.Add(this.CheckBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPlayr1);
            this.Controls.Add(this.radioButtonGroupBoxSizeOfBoard);
            this.Name = "GameSettingsForm";
            this.Text = "Game Settings";
            this.radioButtonGroupBoxSizeOfBoard.ResumeLayout(false);
            this.radioButtonGroupBoxSizeOfBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton6X6;
        private System.Windows.Forms.RadioButton radioButton8X8;
        private System.Windows.Forms.RadioButton radioButton10X10;
        private System.Windows.Forms.GroupBox radioButtonGroupBoxSizeOfBoard;
        private System.Windows.Forms.Label labelPlayr1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.CheckBox CheckBoxPlayer2;
        private System.Windows.Forms.TextBox TextBoxPlayer2;
        private System.Windows.Forms.Button buttonDone;
    }
}

