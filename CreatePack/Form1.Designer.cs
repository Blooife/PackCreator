namespace CreatePack
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
            this.panel = new System.Windows.Forms.Panel();
            this.bSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 72);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(766, 421);
            this.panel.TabIndex = 3;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(647, 12);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(131, 42);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Save pack";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 505);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Pack Creator";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bSave;

        private System.Windows.Forms.Panel panel;

        #endregion
    }
}