
namespace ytd
{
    partial class frmConvertTomp3
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
            this.btnopenvideo = new System.Windows.Forms.Button();
            this.btnsaveto = new System.Windows.Forms.Button();
            this.btnConvertToMp3 = new System.Windows.Forms.Button();
            this.labeloutput = new System.Windows.Forms.Label();
            this.textBoxoutput = new System.Windows.Forms.TextBox();
            this.listBox_ConvertTomp3 = new System.Windows.Forms.ListBox();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnopenvideo
            // 
            this.btnopenvideo.Location = new System.Drawing.Point(281, 42);
            this.btnopenvideo.Name = "btnopenvideo";
            this.btnopenvideo.Size = new System.Drawing.Size(75, 23);
            this.btnopenvideo.TabIndex = 0;
            this.btnopenvideo.Text = "open video";
            this.btnopenvideo.UseVisualStyleBackColor = true;
            this.btnopenvideo.Click += new System.EventHandler(this.btnopenvideo_Click);
            // 
            // btnsaveto
            // 
            this.btnsaveto.Location = new System.Drawing.Point(499, 358);
            this.btnsaveto.Name = "btnsaveto";
            this.btnsaveto.Size = new System.Drawing.Size(75, 23);
            this.btnsaveto.TabIndex = 1;
            this.btnsaveto.Text = "save to";
            this.btnsaveto.UseVisualStyleBackColor = true;
            this.btnsaveto.Click += new System.EventHandler(this.btnsaveto_Click);
            // 
            // btnConvertToMp3
            // 
            this.btnConvertToMp3.Location = new System.Drawing.Point(281, 407);
            this.btnConvertToMp3.Name = "btnConvertToMp3";
            this.btnConvertToMp3.Size = new System.Drawing.Size(75, 23);
            this.btnConvertToMp3.TabIndex = 2;
            this.btnConvertToMp3.Text = "convert";
            this.btnConvertToMp3.UseVisualStyleBackColor = true;
            this.btnConvertToMp3.Click += new System.EventHandler(this.btnConvertToMp3_Click);
            // 
            // labeloutput
            // 
            this.labeloutput.AutoSize = true;
            this.labeloutput.Location = new System.Drawing.Point(48, 365);
            this.labeloutput.Name = "labeloutput";
            this.labeloutput.Size = new System.Drawing.Size(44, 15);
            this.labeloutput.TabIndex = 5;
            this.labeloutput.Text = "save to";
            // 
            // textBoxoutput
            // 
            this.textBoxoutput.Location = new System.Drawing.Point(190, 358);
            this.textBoxoutput.Name = "textBoxoutput";
            this.textBoxoutput.Size = new System.Drawing.Size(291, 23);
            this.textBoxoutput.TabIndex = 7;
            this.textBoxoutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxoutput_KeyDown);
            // 
            // listBox_ConvertTomp3
            // 
            this.listBox_ConvertTomp3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox_ConvertTomp3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox_ConvertTomp3.FormattingEnabled = true;
            this.listBox_ConvertTomp3.ItemHeight = 15;
            this.listBox_ConvertTomp3.Location = new System.Drawing.Point(21, 93);
            this.listBox_ConvertTomp3.Name = "listBox_ConvertTomp3";
            this.listBox_ConvertTomp3.Size = new System.Drawing.Size(596, 259);
            this.listBox_ConvertTomp3.TabIndex = 8;
            this.listBox_ConvertTomp3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_ConvertTomp3_KeyDown);
            this.listBox_ConvertTomp3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox_ConvertTomp3_MouseMove);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(554, 34);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(75, 23);
            this.btnEXIT.TabIndex = 9;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // frmConvertTomp3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 442);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.listBox_ConvertTomp3);
            this.Controls.Add(this.textBoxoutput);
            this.Controls.Add(this.labeloutput);
            this.Controls.Add(this.btnConvertToMp3);
            this.Controls.Add(this.btnsaveto);
            this.Controls.Add(this.btnopenvideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConvertTomp3";
            this.Text = "video to mp3 converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnopenvideo;
        private System.Windows.Forms.Button btnsaveto;
        private System.Windows.Forms.Button btnConvertToMp3;
        private System.Windows.Forms.Label labeloutput;
        private System.Windows.Forms.TextBox textBoxoutput;
        private System.Windows.Forms.ListBox listBox_ConvertTomp3;
        private System.Windows.Forms.Button btnEXIT;
    }
}