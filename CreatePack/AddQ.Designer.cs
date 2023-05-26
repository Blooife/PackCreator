using System.ComponentModel;

namespace CreatePack
{
    partial class AddQ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPicture = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.rtQuestion = new System.Windows.Forms.RichTextBox();
            this.bOpen = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.rtAnswer = new System.Windows.Forms.RichTextBox();
            this.nPoints = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPicture);
            this.groupBox1.Controls.Add(this.rbText);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select type of question";
            // 
            // rbPicture
            // 
            this.rbPicture.Location = new System.Drawing.Point(6, 49);
            this.rbPicture.Name = "rbPicture";
            this.rbPicture.Size = new System.Drawing.Size(104, 24);
            this.rbPicture.TabIndex = 1;
            this.rbPicture.TabStop = true;
            this.rbPicture.Text = "Picture";
            this.rbPicture.UseVisualStyleBackColor = true;
            this.rbPicture.Enter += new System.EventHandler(this.rbPicture_Enter);
            // 
            // rbText
            // 
            this.rbText.Location = new System.Drawing.Point(6, 19);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(104, 24);
            this.rbText.TabIndex = 0;
            this.rbText.TabStop = true;
            this.rbText.Text = "Text";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.Enter += new System.EventHandler(this.rbText_Enter);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(256, 48);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(250, 200);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            // 
            // rtQuestion
            // 
            this.rtQuestion.Location = new System.Drawing.Point(256, 48);
            this.rtQuestion.Name = "rtQuestion";
            this.rtQuestion.Size = new System.Drawing.Size(250, 200);
            this.rtQuestion.TabIndex = 2;
            this.rtQuestion.Text = "";
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(431, 12);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(75, 23);
            this.bOpen.TabIndex = 3;
            this.bOpen.Text = "Open File";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bOk
            // 
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Location = new System.Drawing.Point(431, 298);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 4;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // rtAnswer
            // 
            this.rtAnswer.Location = new System.Drawing.Point(32, 140);
            this.rtAnswer.Name = "rtAnswer";
            this.rtAnswer.Size = new System.Drawing.Size(183, 52);
            this.rtAnswer.TabIndex = 5;
            this.rtAnswer.Text = "";
            // 
            // nPoints
            // 
            this.nPoints.Location = new System.Drawing.Point(26, 249);
            this.nPoints.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.nPoints.Name = "nPoints";
            this.nPoints.Size = new System.Drawing.Size(183, 20);
            this.nPoints.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(256, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter text of question";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Answer";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter points for question";
            // 
            // AddQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nPoints);
            this.Controls.Add(this.rtAnswer);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.rtQuestion);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddQ";
            this.Text = "AddQ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPoints)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.NumericUpDown nPoints;

        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.RichTextBox rtAnswer;

        private System.Windows.Forms.RichTextBox rtQuestion;
        private System.Windows.Forms.Button bOpen;

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pBox;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbPicture;

        #endregion
    }
}