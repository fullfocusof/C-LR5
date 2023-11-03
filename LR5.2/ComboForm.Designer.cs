namespace LR5._2
{
    partial class ComboForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSunAndClouds = new System.Windows.Forms.Button();
            this.buttonRecSquare = new System.Windows.Forms.Button();
            this.buttonChess = new System.Windows.Forms.Button();
            this.buttonSinX = new System.Windows.Forms.Button();
            this.buttonSnowflakeRec = new System.Windows.Forms.Button();
            this.buttonFallSnowflake = new System.Windows.Forms.Button();
            this.buttonRecEllipse = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSunAndClouds
            // 
            this.buttonSunAndClouds.Location = new System.Drawing.Point(39, 12);
            this.buttonSunAndClouds.Name = "buttonSunAndClouds";
            this.buttonSunAndClouds.Size = new System.Drawing.Size(127, 23);
            this.buttonSunAndClouds.TabIndex = 0;
            this.buttonSunAndClouds.Text = "Солнце и облака";
            this.buttonSunAndClouds.UseVisualStyleBackColor = true;
            this.buttonSunAndClouds.Click += new System.EventHandler(this.buttonSunAndClouds_Click);
            // 
            // buttonRecSquare
            // 
            this.buttonRecSquare.Location = new System.Drawing.Point(34, 41);
            this.buttonRecSquare.Name = "buttonRecSquare";
            this.buttonRecSquare.Size = new System.Drawing.Size(139, 23);
            this.buttonRecSquare.TabIndex = 1;
            this.buttonRecSquare.Text = "Рекурсивный квадрат";
            this.buttonRecSquare.UseVisualStyleBackColor = true;
            this.buttonRecSquare.Click += new System.EventHandler(this.buttonRecSquare_Click);
            // 
            // buttonChess
            // 
            this.buttonChess.Location = new System.Drawing.Point(44, 70);
            this.buttonChess.Name = "buttonChess";
            this.buttonChess.Size = new System.Drawing.Size(118, 23);
            this.buttonChess.TabIndex = 2;
            this.buttonChess.Text = "Шахматная доска";
            this.buttonChess.UseVisualStyleBackColor = true;
            this.buttonChess.Click += new System.EventHandler(this.buttonChess_Click);
            // 
            // buttonSinX
            // 
            this.buttonSinX.Location = new System.Drawing.Point(48, 99);
            this.buttonSinX.Name = "buttonSinX";
            this.buttonSinX.Size = new System.Drawing.Size(109, 23);
            this.buttonSinX.TabIndex = 3;
            this.buttonSinX.Text = "График синуса";
            this.buttonSinX.UseVisualStyleBackColor = true;
            this.buttonSinX.Click += new System.EventHandler(this.buttonSinX_Click);
            // 
            // buttonSnowflakeRec
            // 
            this.buttonSnowflakeRec.Location = new System.Drawing.Point(64, 128);
            this.buttonSnowflakeRec.Name = "buttonSnowflakeRec";
            this.buttonSnowflakeRec.Size = new System.Drawing.Size(75, 23);
            this.buttonSnowflakeRec.TabIndex = 4;
            this.buttonSnowflakeRec.Text = "Снежинка";
            this.buttonSnowflakeRec.UseVisualStyleBackColor = true;
            this.buttonSnowflakeRec.Click += new System.EventHandler(this.buttonSnowflakeRec_Click);
            // 
            // buttonFallSnowflake
            // 
            this.buttonFallSnowflake.Location = new System.Drawing.Point(34, 157);
            this.buttonFallSnowflake.Name = "buttonFallSnowflake";
            this.buttonFallSnowflake.Size = new System.Drawing.Size(139, 23);
            this.buttonFallSnowflake.TabIndex = 5;
            this.buttonFallSnowflake.Text = "Падающие снежинки";
            this.buttonFallSnowflake.UseVisualStyleBackColor = true;
            this.buttonFallSnowflake.Click += new System.EventHandler(this.buttonFallSnowflake_Click);
            // 
            // buttonRecEllipse
            // 
            this.buttonRecEllipse.Location = new System.Drawing.Point(34, 186);
            this.buttonRecEllipse.Name = "buttonRecEllipse";
            this.buttonRecEllipse.Size = new System.Drawing.Size(139, 23);
            this.buttonRecEllipse.TabIndex = 6;
            this.buttonRecEllipse.Text = "Рекурсивные круги";
            this.buttonRecEllipse.UseVisualStyleBackColor = true;
            this.buttonRecEllipse.Click += new System.EventHandler(this.buttonRecEllipse_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(64, 257);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Закрыть";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ComboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 292);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRecEllipse);
            this.Controls.Add(this.buttonFallSnowflake);
            this.Controls.Add(this.buttonSnowflakeRec);
            this.Controls.Add(this.buttonSinX);
            this.Controls.Add(this.buttonChess);
            this.Controls.Add(this.buttonRecSquare);
            this.Controls.Add(this.buttonSunAndClouds);
            this.Name = "ComboForm";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSunAndClouds;
        private System.Windows.Forms.Button buttonRecSquare;
        private System.Windows.Forms.Button buttonChess;
        private System.Windows.Forms.Button buttonSinX;
        private System.Windows.Forms.Button buttonSnowflakeRec;
        private System.Windows.Forms.Button buttonFallSnowflake;
        private System.Windows.Forms.Button buttonRecEllipse;
        private System.Windows.Forms.Button buttonExit;
    }
}

