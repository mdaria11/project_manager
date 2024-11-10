namespace Project_Manager
{
    partial class EntryPage
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
            this.main_panel = new System.Windows.Forms.Panel();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickmebutton
            // 
            this.clickmebutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clickmebutton.Location = new System.Drawing.Point(420, 80);
            this.clickmebutton.Name = "clickmebutton";
            this.clickmebutton.Size = new System.Drawing.Size(125, 55);
            this.clickmebutton.TabIndex = 0;
            this.clickmebutton.Text = "Click me :)";
            this.clickmebutton.UseVisualStyleBackColor = true;
            this.clickmebutton.Click += new System.EventHandler(this.clickmebutton_Click);
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.BackColor = System.Drawing.SystemColors.Control;
            this.main_panel.Controls.Add(this.clickmebutton);
            this.main_panel.Location = new System.Drawing.Point(12, 12);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(992, 514);
            this.main_panel.TabIndex = 1;
            // 
            // EntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 550);
            this.Controls.Add(this.main_panel);
            this.Name = "EntryPage";
            this.Text = "Project Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickmebutton;
        private System.Windows.Forms.Panel main_panel;
    }
}

