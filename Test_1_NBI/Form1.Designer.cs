namespace Test_1_NBI
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
            this.openFileBtn = new System.Windows.Forms.Button();
            this.filePathTxtBox = new System.Windows.Forms.TextBox();
            this.parseBtn = new System.Windows.Forms.Button();
            this.stateLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileBtn
            // 
            this.openFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileBtn.Location = new System.Drawing.Point(444, 62);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(56, 29);
            this.openFileBtn.TabIndex = 0;
            this.openFileBtn.Text = "Open";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // filePathTxtBox
            // 
            this.filePathTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filePathTxtBox.Location = new System.Drawing.Point(12, 62);
            this.filePathTxtBox.Multiline = true;
            this.filePathTxtBox.Name = "filePathTxtBox";
            this.filePathTxtBox.Size = new System.Drawing.Size(426, 29);
            this.filePathTxtBox.TabIndex = 1;
            // 
            // parseBtn
            // 
            this.parseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parseBtn.Location = new System.Drawing.Point(211, 113);
            this.parseBtn.Name = "parseBtn";
            this.parseBtn.Size = new System.Drawing.Size(91, 30);
            this.parseBtn.TabIndex = 2;
            this.parseBtn.Text = "Parse";
            this.parseBtn.UseVisualStyleBackColor = true;
            this.parseBtn.Click += new System.EventHandler(this.parseBtn_Click);
            // 
            // stateLable
            // 
            this.stateLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLable.Location = new System.Drawing.Point(-1, 160);
            this.stateLable.Name = "stateLable";
            this.stateLable.Size = new System.Drawing.Size(514, 71);
            this.stateLable.TabIndex = 3;
            this.stateLable.Text = "База данных обновлена";
            this.stateLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 240);
            this.Controls.Add(this.stateLable);
            this.Controls.Add(this.parseBtn);
            this.Controls.Add(this.filePathTxtBox);
            this.Controls.Add(this.openFileBtn);
            this.Name = "Form1";
            this.Text = "Json files parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox filePathTxtBox;
        private System.Windows.Forms.Button parseBtn;
        private System.Windows.Forms.Label stateLable;
    }
}

