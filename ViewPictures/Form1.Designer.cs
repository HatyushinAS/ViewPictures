namespace ViewPictures
{
    partial class ViewPicture
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
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopButton = new System.Windows.Forms.Button();
            this.PictureList = new System.Windows.Forms.ListBox();
            this.trackBarBright = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarTransparency = new System.Windows.Forms.TrackBar();
            this.checkBoxGray = new System.Windows.Forms.CheckBox();
            this.checkBoxNoise = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransparency)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftButton
            // 
            this.LeftButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LeftButton.Location = new System.Drawing.Point(16, 248);
            this.LeftButton.Margin = new System.Windows.Forms.Padding(4);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(76, 28);
            this.LeftButton.TabIndex = 0;
            this.LeftButton.Text = "back";
            this.LeftButton.UseVisualStyleBackColor = false;
            this.LeftButton.Click += new System.EventHandler(this.ButtonImageChange);
            // 
            // RightButton
            // 
            this.RightButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RightButton.Location = new System.Drawing.Point(100, 248);
            this.RightButton.Margin = new System.Windows.Forms.Padding(4);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(76, 28);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = "next";
            this.RightButton.UseVisualStyleBackColor = false;
            this.RightButton.Click += new System.EventHandler(this.ButtonImageChange);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(184, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TopButton
            // 
            this.TopButton.Location = new System.Drawing.Point(16, 4);
            this.TopButton.Margin = new System.Windows.Forms.Padding(4);
            this.TopButton.Name = "TopButton";
            this.TopButton.Size = new System.Drawing.Size(160, 31);
            this.TopButton.TabIndex = 3;
            this.TopButton.Text = "Выбор картинок";
            this.TopButton.UseVisualStyleBackColor = true;
            this.TopButton.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // PictureList
            // 
            this.PictureList.FormattingEnabled = true;
            this.PictureList.ItemHeight = 16;
            this.PictureList.Location = new System.Drawing.Point(16, 44);
            this.PictureList.Margin = new System.Windows.Forms.Padding(4);
            this.PictureList.Name = "PictureList";
            this.PictureList.Size = new System.Drawing.Size(159, 196);
            this.PictureList.TabIndex = 4;
            this.PictureList.SelectedIndexChanged += new System.EventHandler(this.PictureList_SelectedIndexChanged);
            // 
            // trackBarBright
            // 
            this.trackBarBright.Location = new System.Drawing.Point(16, 316);
            this.trackBarBright.Maximum = 100;
            this.trackBarBright.Minimum = -100;
            this.trackBarBright.Name = "trackBarBright";
            this.trackBarBright.Size = new System.Drawing.Size(159, 56);
            this.trackBarBright.TabIndex = 5;
            this.trackBarBright.Scroll += new System.EventHandler(this.trackBarBright_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ярокость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Прозрачность";
            // 
            // trackBarTransparency
            // 
            this.trackBarTransparency.Location = new System.Drawing.Point(16, 378);
            this.trackBarTransparency.Maximum = 100;
            this.trackBarTransparency.Name = "trackBarTransparency";
            this.trackBarTransparency.Size = new System.Drawing.Size(159, 56);
            this.trackBarTransparency.TabIndex = 7;
            // 
            // checkBoxGray
            // 
            this.checkBoxGray.AutoSize = true;
            this.checkBoxGray.Location = new System.Drawing.Point(28, 440);
            this.checkBoxGray.Name = "checkBoxGray";
            this.checkBoxGray.Size = new System.Drawing.Size(134, 21);
            this.checkBoxGray.TabIndex = 9;
            this.checkBoxGray.Text = "Оттенок серого";
            this.checkBoxGray.UseVisualStyleBackColor = true;
            this.checkBoxGray.CheckedChanged += new System.EventHandler(this.checkBoxGray_CheckedChanged);
            // 
            // checkBoxNoise
            // 
            this.checkBoxNoise.AutoSize = true;
            this.checkBoxNoise.Location = new System.Drawing.Point(28, 478);
            this.checkBoxNoise.Name = "checkBoxNoise";
            this.checkBoxNoise.Size = new System.Drawing.Size(57, 21);
            this.checkBoxNoise.TabIndex = 10;
            this.checkBoxNoise.Text = "Шум";
            this.checkBoxNoise.UseVisualStyleBackColor = true;
            this.checkBoxNoise.CheckedChanged += new System.EventHandler(this.checkBoxNoise_CheckedChanged);
            // 
            // ViewPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 555);
            this.Controls.Add(this.checkBoxNoise);
            this.Controls.Add(this.checkBoxGray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarTransparency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarBright);
            this.Controls.Add(this.PictureList);
            this.Controls.Add(this.TopButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewPicture";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransparency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TopButton;
        private System.Windows.Forms.ListBox PictureList;
        private System.Windows.Forms.TrackBar trackBarBright;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarTransparency;
        private System.Windows.Forms.CheckBox checkBoxGray;
        private System.Windows.Forms.CheckBox checkBoxNoise;
    }
}

