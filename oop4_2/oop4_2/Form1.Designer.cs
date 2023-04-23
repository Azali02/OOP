namespace oop4_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numA = new NumericUpDown();
            textA = new TextBox();
            tbA = new TrackBar();
            tBB = new TrackBar();
            numB = new NumericUpDown();
            numC = new NumericUpDown();
            textB = new TextBox();
            textC = new TextBox();
            tBC = new TrackBar();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tBB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tBC).BeginInit();
            SuspendLayout();
            // 
            // numA
            // 
            numA.Location = new Point(115, 234);
            numA.Name = "numA";
            numA.Size = new Size(163, 27);
            numA.TabIndex = 0;
            numA.ValueChanged += numA_ValueChanged;
            // 
            // textA
            // 
            textA.BackColor = Color.MistyRose;
            textA.Location = new Point(115, 267);
            textA.MaxLength = 3;
            textA.Name = "textA";
            textA.Size = new Size(163, 27);
            textA.TabIndex = 2;
            textA.KeyDown += textA_KeyDown;
            textA.KeyPress += text_KeyPress;
            // 
            // tbA
            // 
            tbA.Location = new Point(115, 136);
            tbA.Maximum = 100;
            tbA.Name = "tbA";
            tbA.Size = new Size(163, 56);
            tbA.TabIndex = 3;
            tbA.Scroll += tbA_Scroll;
            // 
            // tBB
            // 
            tBB.Location = new Point(431, 136);
            tBB.Maximum = 100;
            tBB.Name = "tBB";
            tBB.Size = new Size(163, 56);
            tBB.TabIndex = 4;
            tBB.Scroll += tBB_Scroll;
            // 
            // numB
            // 
            numB.Location = new Point(431, 234);
            numB.Name = "numB";
            numB.Size = new Size(163, 27);
            numB.TabIndex = 5;
            numB.ValueChanged += numB_ValueChanged;
            // 
            // numC
            // 
            numC.Location = new Point(731, 234);
            numC.Name = "numC";
            numC.Size = new Size(163, 27);
            numC.TabIndex = 6;
            numC.ValueChanged += numC_ValueChanged;
            // 
            // textB
            // 
            textB.BackColor = Color.MistyRose;
            textB.Location = new Point(431, 267);
            textB.MaxLength = 3;
            textB.Name = "textB";
            textB.Size = new Size(163, 27);
            textB.TabIndex = 7;
            textB.KeyDown += textB_KeyDown;
            textB.KeyPress += text_KeyPress;
            // 
            // textC
            // 
            textC.BackColor = Color.MistyRose;
            textC.Location = new Point(731, 267);
            textC.MaxLength = 3;
            textC.Name = "textC";
            textC.Size = new Size(163, 27);
            textC.TabIndex = 8;
            textC.KeyDown += textC_KeyDown;
            textC.KeyPress += text_KeyPress;
            // 
            // tBC
            // 
            tBC.Location = new Point(731, 136);
            tBC.Maximum = 100;
            tBC.Name = "tBC";
            tBC.Size = new Size(163, 56);
            tBC.TabIndex = 9;
            tBC.Scroll += tBC_Scroll;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(449, 393);
            button1.Name = "button1";
            button1.Size = new Size(108, 45);
            button1.TabIndex = 10;
            button1.Text = "Очистить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(162, 47);
            label1.Name = "label1";
            label1.Size = new Size(72, 68);
            label1.TabIndex = 11;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(475, 47);
            label2.Name = "label2";
            label2.Size = new Size(69, 68);
            label2.TabIndex = 12;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(773, 47);
            label3.Name = "label3";
            label3.Size = new Size(72, 68);
            label3.TabIndex = 13;
            label3.Text = "C";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1014, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(tBC);
            Controls.Add(textC);
            Controls.Add(textB);
            Controls.Add(numC);
            Controls.Add(numB);
            Controls.Add(tBB);
            Controls.Add(tbA);
            Controls.Add(textA);
            Controls.Add(numA);
            Name = "Form1";
            Text = "Laba 4.2";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numA).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbA).EndInit();
            ((System.ComponentModel.ISupportInitialize)tBB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numC).EndInit();
            ((System.ComponentModel.ISupportInitialize)tBC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numA;
        private TextBox textA;
        private TrackBar tbA;
        private TrackBar tBB;
        private NumericUpDown numB;
        private NumericUpDown numC;
        private TextBox textB;
        private TextBox textC;
        private TrackBar tBC;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}