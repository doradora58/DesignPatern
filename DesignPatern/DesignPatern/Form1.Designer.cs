namespace DesignPatern
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
            panel1 = new Panel();
            RightButton = new Button();
            AButton = new Button();
            MarioRadioButton = new RadioButton();
            LuigRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 314);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // RightButton
            // 
            RightButton.Location = new Point(12, 367);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(124, 38);
            RightButton.TabIndex = 1;
            RightButton.Text = "→";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // AButton
            // 
            AButton.Location = new Point(142, 367);
            AButton.Name = "AButton";
            AButton.Size = new Size(124, 38);
            AButton.TabIndex = 2;
            AButton.Text = "A";
            AButton.UseVisualStyleBackColor = true;
            AButton.Click += AButton_Click;
            // 
            // MarioRadioButton
            // 
            MarioRadioButton.AutoSize = true;
            MarioRadioButton.Checked = true;
            MarioRadioButton.Location = new Point(28, 22);
            MarioRadioButton.Name = "MarioRadioButton";
            MarioRadioButton.Size = new Size(56, 19);
            MarioRadioButton.TabIndex = 3;
            MarioRadioButton.TabStop = true;
            MarioRadioButton.Text = "Mario";
            MarioRadioButton.UseVisualStyleBackColor = true;
            MarioRadioButton.CheckedChanged += CheckedChanged;
            // 
            // LuigRadioButton
            // 
            LuigRadioButton.AutoSize = true;
            LuigRadioButton.Location = new Point(162, 22);
            LuigRadioButton.Name = "LuigRadioButton";
            LuigRadioButton.Size = new Size(48, 19);
            LuigRadioButton.TabIndex = 4;
            LuigRadioButton.Text = "Luig";
            LuigRadioButton.UseVisualStyleBackColor = true;
            LuigRadioButton.CheckedChanged += CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LuigRadioButton);
            Controls.Add(MarioRadioButton);
            Controls.Add(AButton);
            Controls.Add(RightButton);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button RightButton;
        private Button AButton;
        private RadioButton MarioRadioButton;
        private RadioButton LuigRadioButton;
    }
}
