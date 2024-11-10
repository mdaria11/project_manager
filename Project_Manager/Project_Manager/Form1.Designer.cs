namespace Project_Manager
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
            this.clickmebutton = new System.Windows.Forms.Button();
            this.text_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickmebutton
            // 
            this.clickmebutton.Location = new System.Drawing.Point(392, 145);
            this.clickmebutton.Name = "clickmebutton";
            this.clickmebutton.Size = new System.Drawing.Size(154, 42);
            this.clickmebutton.TabIndex = 0;
            this.clickmebutton.Text = "Click me :)";
            this.clickmebutton.UseVisualStyleBackColor = true;
            this.clickmebutton.Click += new System.EventHandler(this.clickmebutton_Click);
            // 
            // text_label
            // 
            this.text_label.AutoSize = true;
            this.text_label.Location = new System.Drawing.Point(440, 232);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(0, 16);
            this.text_label.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 554);
            this.Controls.Add(this.text_label);
            this.Controls.Add(this.clickmebutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickmebutton;
        private System.Windows.Forms.Label text_label;
    }
}

