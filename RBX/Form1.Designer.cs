namespace RBX
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.dllPath1 = new System.Windows.Forms.TextBox();
            this.browseBtn1 = new System.Windows.Forms.Button();
            this.browseBtn2 = new System.Windows.Forms.Button();
            this.dllPath2 = new System.Windows.Forms.TextBox();
            this.browseBtn3 = new System.Windows.Forms.Button();
            this.dllPath3 = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.startBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // dllPath1
            // 
            this.dllPath1.Location = new System.Drawing.Point(618, 12);
            this.dllPath1.Name = "dllPath1";
            this.dllPath1.ReadOnly = true;
            this.dllPath1.Size = new System.Drawing.Size(239, 20);
            this.dllPath1.TabIndex = 1;
            // 
            // browseBtn1
            // 
            this.browseBtn1.Location = new System.Drawing.Point(863, 10);
            this.browseBtn1.Name = "browseBtn1";
            this.browseBtn1.Size = new System.Drawing.Size(32, 23);
            this.browseBtn1.TabIndex = 2;
            this.browseBtn1.Text = "...";
            this.browseBtn1.UseVisualStyleBackColor = true;
            this.browseBtn1.Click += new System.EventHandler(this.browseBtn1_Click);
            // 
            // browseBtn2
            // 
            this.browseBtn2.Location = new System.Drawing.Point(863, 36);
            this.browseBtn2.Name = "browseBtn2";
            this.browseBtn2.Size = new System.Drawing.Size(32, 23);
            this.browseBtn2.TabIndex = 4;
            this.browseBtn2.Text = "...";
            this.browseBtn2.UseVisualStyleBackColor = true;
            // 
            // dllPath2
            // 
            this.dllPath2.Location = new System.Drawing.Point(618, 38);
            this.dllPath2.Name = "dllPath2";
            this.dllPath2.ReadOnly = true;
            this.dllPath2.Size = new System.Drawing.Size(239, 20);
            this.dllPath2.TabIndex = 3;
            // 
            // browseBtn3
            // 
            this.browseBtn3.Location = new System.Drawing.Point(863, 62);
            this.browseBtn3.Name = "browseBtn3";
            this.browseBtn3.Size = new System.Drawing.Size(32, 23);
            this.browseBtn3.TabIndex = 6;
            this.browseBtn3.Text = "...";
            this.browseBtn3.UseVisualStyleBackColor = true;
            // 
            // dllPath3
            // 
            this.dllPath3.Location = new System.Drawing.Point(618, 64);
            this.dllPath3.Name = "dllPath3";
            this.dllPath3.ReadOnly = true;
            this.dllPath3.Size = new System.Drawing.Size(239, 20);
            this.dllPath3.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "\"DLLs|*.dll\"";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(618, 105);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(277, 56);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 627);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.browseBtn3);
            this.Controls.Add(this.dllPath3);
            this.Controls.Add(this.browseBtn2);
            this.Controls.Add(this.dllPath2);
            this.Controls.Add(this.browseBtn1);
            this.Controls.Add(this.dllPath1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TextBox dllPath1;
        private System.Windows.Forms.Button browseBtn1;
        private System.Windows.Forms.Button browseBtn2;
        private System.Windows.Forms.TextBox dllPath2;
        private System.Windows.Forms.Button browseBtn3;
        private System.Windows.Forms.TextBox dllPath3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button startBtn;
    }
}

