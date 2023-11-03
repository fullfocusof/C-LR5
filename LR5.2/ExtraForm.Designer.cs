namespace LR5._2
{
    partial class ExtraForm
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
            this.components = new System.ComponentModel.Container();
            this.timerSunUp = new System.Windows.Forms.Timer(this.components);
            this.timerSunDown = new System.Windows.Forms.Timer(this.components);
            this.textBoxRecSquareCnt = new System.Windows.Forms.TextBox();
            this.buttonRecSquare = new System.Windows.Forms.Button();
            this.textBoxRecSquareLength = new System.Windows.Forms.TextBox();
            this.labelRecSquareLength = new System.Windows.Forms.Label();
            this.labelRecSquareCnt = new System.Windows.Forms.Label();
            this.buttonSnowFlakeRec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerSunUp
            // 
            this.timerSunUp.Interval = 300;
            this.timerSunUp.Tick += new System.EventHandler(this.timerSun_Tick);
            // 
            // timerSunDown
            // 
            this.timerSunDown.Interval = 300;
            this.timerSunDown.Tick += new System.EventHandler(this.timerSunDown_Tick);
            // 
            // textBoxRecSquareCnt
            // 
            this.textBoxRecSquareCnt.Location = new System.Drawing.Point(1817, 900);
            this.textBoxRecSquareCnt.Name = "textBoxRecSquareCnt";
            this.textBoxRecSquareCnt.Size = new System.Drawing.Size(75, 20);
            this.textBoxRecSquareCnt.TabIndex = 0;
            this.textBoxRecSquareCnt.Visible = false;
            // 
            // buttonRecSquare
            // 
            this.buttonRecSquare.Location = new System.Drawing.Point(1817, 926);
            this.buttonRecSquare.Name = "buttonRecSquare";
            this.buttonRecSquare.Size = new System.Drawing.Size(75, 23);
            this.buttonRecSquare.TabIndex = 1;
            this.buttonRecSquare.Text = "Построить";
            this.buttonRecSquare.UseVisualStyleBackColor = true;
            this.buttonRecSquare.Visible = false;
            this.buttonRecSquare.Click += new System.EventHandler(this.buttonRecSquare_Click);
            // 
            // textBoxRecSquareLength
            // 
            this.textBoxRecSquareLength.Location = new System.Drawing.Point(1817, 874);
            this.textBoxRecSquareLength.Name = "textBoxRecSquareLength";
            this.textBoxRecSquareLength.Size = new System.Drawing.Size(75, 20);
            this.textBoxRecSquareLength.TabIndex = 2;
            this.textBoxRecSquareLength.Visible = false;
            // 
            // labelRecSquareLength
            // 
            this.labelRecSquareLength.AutoSize = true;
            this.labelRecSquareLength.Location = new System.Drawing.Point(1725, 877);
            this.labelRecSquareLength.Name = "labelRecSquareLength";
            this.labelRecSquareLength.Size = new System.Drawing.Size(86, 13);
            this.labelRecSquareLength.TabIndex = 3;
            this.labelRecSquareLength.Text = "Длина стороны";
            this.labelRecSquareLength.Visible = false;
            // 
            // labelRecSquareCnt
            // 
            this.labelRecSquareCnt.AutoSize = true;
            this.labelRecSquareCnt.Location = new System.Drawing.Point(1652, 903);
            this.labelRecSquareCnt.Name = "labelRecSquareCnt";
            this.labelRecSquareCnt.Size = new System.Drawing.Size(159, 13);
            this.labelRecSquareCnt.TabIndex = 4;
            this.labelRecSquareCnt.Text = "Количество вложенных фигур";
            this.labelRecSquareCnt.Visible = false;
            // 
            // buttonSnowFlakeRec
            // 
            this.buttonSnowFlakeRec.Location = new System.Drawing.Point(1817, 926);
            this.buttonSnowFlakeRec.Name = "buttonSnowFlakeRec";
            this.buttonSnowFlakeRec.Size = new System.Drawing.Size(75, 23);
            this.buttonSnowFlakeRec.TabIndex = 5;
            this.buttonSnowFlakeRec.Text = "Построить";
            this.buttonSnowFlakeRec.UseVisualStyleBackColor = true;
            this.buttonSnowFlakeRec.Visible = false;
            this.buttonSnowFlakeRec.Click += new System.EventHandler(this.buttonSnowFlakeRec_Click);
            // 
            // ExtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.buttonSnowFlakeRec);
            this.Controls.Add(this.labelRecSquareCnt);
            this.Controls.Add(this.labelRecSquareLength);
            this.Controls.Add(this.textBoxRecSquareLength);
            this.Controls.Add(this.buttonRecSquare);
            this.Controls.Add(this.textBoxRecSquareCnt);
            this.Name = "ExtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.ExtraForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerSunUp;
        private System.Windows.Forms.Timer timerSunDown;
        private System.Windows.Forms.TextBox textBoxRecSquareCnt;
        private System.Windows.Forms.Button buttonRecSquare;
        private System.Windows.Forms.TextBox textBoxRecSquareLength;
        private System.Windows.Forms.Label labelRecSquareLength;
        private System.Windows.Forms.Label labelRecSquareCnt;
        private System.Windows.Forms.Button buttonSnowFlakeRec;
    }
}