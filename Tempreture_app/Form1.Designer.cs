namespace Tempreture_app
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
            celsius = new TextBox();
            fahrenheit = new TextBox();
            F_to_C = new Button();
            C_to_F = new Button();
            Clear = new Button();
            K_to_F_button = new Button();
            SuspendLayout();
            // 
            // celsius
            // 
            celsius.Location = new Point(455, 131);
            celsius.Name = "celsius";
            celsius.Size = new Size(125, 27);
            celsius.TabIndex = 0;
            // 
            // fahrenheit
            // 
            fahrenheit.Location = new Point(135, 131);
            fahrenheit.Name = "fahrenheit";
            fahrenheit.Size = new Size(125, 27);
            fahrenheit.TabIndex = 1;
            // 
            // F_to_C
            // 
            F_to_C.Location = new Point(303, 131);
            F_to_C.Name = "F_to_C";
            F_to_C.Size = new Size(94, 29);
            F_to_C.TabIndex = 2;
            F_to_C.Text = "F to C ->";
            F_to_C.UseVisualStyleBackColor = true;
            F_to_C.Click += button1_Click;
            // 
            // C_to_F
            // 
            C_to_F.Location = new Point(303, 189);
            C_to_F.Name = "C_to_F";
            C_to_F.Size = new Size(94, 29);
            C_to_F.TabIndex = 3;
            C_to_F.Text = "<- C to F ";
            C_to_F.UseVisualStyleBackColor = true;
            C_to_F.Click += C_to_F_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Blue;
            Clear.Location = new Point(303, 284);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 29);
            Clear.TabIndex = 4;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // K_to_F_button
            // 
            K_to_F_button.Location = new Point(303, 237);
            K_to_F_button.Name = "K_to_F_button";
            K_to_F_button.Size = new Size(94, 29);
            K_to_F_button.TabIndex = 5;
            K_to_F_button.Text = "F to K ->";
            K_to_F_button.UseVisualStyleBackColor = true;
            K_to_F_button.Click += K_to_F_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(K_to_F_button);
            Controls.Add(Clear);
            Controls.Add(C_to_F);
            Controls.Add(F_to_C);
            Controls.Add(fahrenheit);
            Controls.Add(celsius);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox celsius;
        private TextBox fahrenheit;
        private Button F_to_C;
        private Button C_to_F;
        private Button Clear;
        private Button K_to_F_button;
    }
}