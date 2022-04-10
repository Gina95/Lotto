
namespace Sorsolas
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
            this.Sorsol_Button = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sorsol_Button
            // 
            this.Sorsol_Button.Location = new System.Drawing.Point(663, 29);
            this.Sorsol_Button.Name = "Sorsol_Button";
            this.Sorsol_Button.Size = new System.Drawing.Size(75, 23);
            this.Sorsol_Button.TabIndex = 0;
            this.Sorsol_Button.Text = "Sorsolás";
            this.Sorsol_Button.UseVisualStyleBackColor = true;
            this.Sorsol_Button.Click += new System.EventHandler(this.Sorsol_Button_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(24, 29);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(624, 388);
            this.panel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bezárás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Sorsol_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sorsol_Button;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button1;
    }
}

