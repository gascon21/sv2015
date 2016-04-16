namespace EnglishAplication
{
    partial class English_Aplication
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
            this.btCheck = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbEnglish = new System.Windows.Forms.Label();
            this.lbSpanish = new System.Windows.Forms.Label();
            this.lbProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(314, 388);
            this.btCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(120, 66);
            this.btCheck.TabIndex = 2;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(544, 388);
            this.btNext.Margin = new System.Windows.Forms.Padding(2);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(134, 66);
            this.btNext.TabIndex = 3;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(35, 388);
            this.btBack.Margin = new System.Windows.Forms.Padding(2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(182, 66);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "English Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Spanish Word";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbEnglish
            // 
            this.lbEnglish.AutoSize = true;
            this.lbEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnglish.Location = new System.Drawing.Point(37, 247);
            this.lbEnglish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEnglish.Name = "lbEnglish";
            this.lbEnglish.Size = new System.Drawing.Size(129, 36);
            this.lbEnglish.TabIndex = 7;
            this.lbEnglish.Text = "Example";
            // 
            // lbSpanish
            // 
            this.lbSpanish.AutoSize = true;
            this.lbSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpanish.Location = new System.Drawing.Point(494, 247);
            this.lbSpanish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSpanish.Name = "lbSpanish";
            this.lbSpanish.Size = new System.Drawing.Size(122, 36);
            this.lbSpanish.TabIndex = 8;
            this.lbSpanish.Text = "Ejemplo";
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(363, 489);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(34, 13);
            this.lbProgress.TabIndex = 9;
            this.lbProgress.Text = "1 of 1";
            // 
            // English_Aplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 531);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.lbSpanish);
            this.Controls.Add(this.lbEnglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btCheck);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "English_Aplication";
            this.Text = "English Review";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbEnglish;
        private System.Windows.Forms.Label lbSpanish;
        private System.Windows.Forms.Label lbProgress;
    }
}