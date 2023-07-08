namespace TimeSyncApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timeOutput = new System.Windows.Forms.TextBox();
            this.ipAdressField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timeOutputLocal = new System.Windows.Forms.TextBox();
            this.updateRateLabel = new System.Windows.Forms.Label();
            this.successLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущее время сервера";
            // 
            // timeOutput
            // 
            this.timeOutput.Location = new System.Drawing.Point(26, 49);
            this.timeOutput.Name = "timeOutput";
            this.timeOutput.Size = new System.Drawing.Size(296, 20);
            this.timeOutput.TabIndex = 1;
            this.timeOutput.Text = "Нажмите кнопку \"Обновить\"";
            // 
            // ipAdressField
            // 
            this.ipAdressField.Location = new System.Drawing.Point(444, 49);
            this.ipAdressField.Name = "ipAdressField";
            this.ipAdressField.Size = new System.Drawing.Size(287, 20);
            this.ipAdressField.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Обновить время сервера";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showTime);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Time Sync";
            this.notifyIcon1.Visible = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Адрес NTP-сервера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Настройки автоматического обновления";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(444, 224);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(271, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Включить автоматическое обновление времени";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Период обновления:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(444, 317);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(271, 45);
            this.trackBar1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Настойка периода обновления";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Применить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.setSettings);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(444, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Синхронизировать время на компьютере";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.updateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Текущее время компьютера";
            // 
            // timeOutputLocal
            // 
            this.timeOutputLocal.Location = new System.Drawing.Point(26, 98);
            this.timeOutputLocal.Name = "timeOutputLocal";
            this.timeOutputLocal.Size = new System.Drawing.Size(296, 20);
            this.timeOutputLocal.TabIndex = 1;
            this.timeOutputLocal.Text = "Нажмите кнопку \"Обновить\"";
            // 
            // updateRateLabel
            // 
            this.updateRateLabel.AutoSize = true;
            this.updateRateLabel.Location = new System.Drawing.Point(558, 271);
            this.updateRateLabel.Name = "updateRateLabel";
            this.updateRateLabel.Size = new System.Drawing.Size(0, 13);
            this.updateRateLabel.TabIndex = 0;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.BackColor = System.Drawing.SystemColors.Control;
            this.successLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.successLabel.Location = new System.Drawing.Point(539, 404);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(99, 13);
            this.successLabel.TabIndex = 0;
            this.successLabel.Text = "Задача запущена.";
            this.successLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.successLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ipAdressField);
            this.Controls.Add(this.timeOutputLocal);
            this.Controls.Add(this.timeOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateRateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Time Sync";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeOutput;
        private System.Windows.Forms.TextBox ipAdressField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox timeOutputLocal;
        private System.Windows.Forms.Label updateRateLabel;
        private System.Windows.Forms.Label successLabel;
    }
}

