namespace oop4_1
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
            btn_Delete = new Button();
            chb_Ctrl = new CheckBox();
            chb_flag = new CheckBox();
            SuspendLayout();
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(387, 12);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 52);
            btn_Delete.TabIndex = 0;
            btn_Delete.Text = "Очистить форму";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += button1_Click;
            // 
            // chb_Ctrl
            // 
            chb_Ctrl.AutoSize = true;
            chb_Ctrl.Location = new Point(12, 12);
            chb_Ctrl.Name = "chb_Ctrl";
            chb_Ctrl.Size = new Size(64, 24);
            chb_Ctrl.TabIndex = 1;
            chb_Ctrl.Text = "CTRL";
            chb_Ctrl.UseVisualStyleBackColor = true;
            chb_Ctrl.CheckedChanged += chb_Ctrl_CheckedChanged;
            // 
            // chb_flag
            // 
            chb_flag.AutoSize = true;
            chb_flag.Location = new Point(12, 42);
            chb_flag.Name = "chb_flag";
            chb_flag.Size = new Size(369, 24);
            chb_flag.TabIndex = 2;
            chb_flag.Text = "Выделять несколько объектов при пересечении";
            chb_flag.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(chb_flag);
            Controls.Add(chb_Ctrl);
            Controls.Add(btn_Delete);
            Name = "Form1";
            Text = "OOP_4.1";
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Delete;
        private CheckBox chb_Ctrl;
        private CheckBox chb_flag;
    }
}