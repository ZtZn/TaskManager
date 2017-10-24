namespace TaskManager
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.erdftgyhuiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fdghjkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиВыключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerOn = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFileName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxtaskqueue = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxLanValueOff = new System.Windows.Forms.TextBox();
            this.textBoxProcessorValueOff = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonOffTime = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcProcessor = new System.Diagnostics.PerformanceCounter();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timerOff = new System.Windows.Forms.Timer(this.components);
            this.timerproc = new System.Windows.Forms.Timer(this.components);
            this.timerlan = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePickerOff = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcProcessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erdftgyhuiToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // erdftgyhuiToolStripMenuItem
            // 
            this.erdftgyhuiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fdghjkToolStripMenuItem,
            this.настройкиВыключенияToolStripMenuItem});
            this.erdftgyhuiToolStripMenuItem.Name = "erdftgyhuiToolStripMenuItem";
            this.erdftgyhuiToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.erdftgyhuiToolStripMenuItem.Text = "Настройки";
            this.erdftgyhuiToolStripMenuItem.Click += new System.EventHandler(this.erdftgyhuiToolStripMenuItem_Click);
            // 
            // fdghjkToolStripMenuItem
            // 
            this.fdghjkToolStripMenuItem.Name = "fdghjkToolStripMenuItem";
            this.fdghjkToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.fdghjkToolStripMenuItem.Text = "Настройки запуска";
            this.fdghjkToolStripMenuItem.Click += new System.EventHandler(this.fdghjkToolStripMenuItem_Click);
            // 
            // настройкиВыключенияToolStripMenuItem
            // 
            this.настройкиВыключенияToolStripMenuItem.Name = "настройкиВыключенияToolStripMenuItem";
            this.настройкиВыключенияToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.настройкиВыключенияToolStripMenuItem.Text = "Настройки выключения";
            this.настройкиВыключенияToolStripMenuItem.Click += new System.EventHandler(this.настройкиВыключенияToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerOff);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.richTextBoxMessage);
            this.panel1.Controls.Add(this.dateTimePickerOn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.richTextBoxtaskqueue);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(15, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 340);
            this.panel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Время окончания отправки";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(219, 176);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(138, 146);
            this.richTextBoxMessage.TabIndex = 12;
            this.richTextBoxMessage.Text = "";
            // 
            // dateTimePickerOn
            // 
            this.dateTimePickerOn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerOn.Location = new System.Drawing.Point(582, 198);
            this.dateTimePickerOn.Name = "dateTimePickerOn";
            this.dateTimePickerOn.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerOn.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(582, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Установить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Время начала отправки";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Отправляемое сообщение";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelFileName);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBoxTime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(394, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 132);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(3, 13);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(35, 13);
            this.labelFileName.TabIndex = 8;
            this.labelFileName.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(234, 47);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(76, 20);
            this.textBoxTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите промежуток времени (мин)";
            // 
            // richTextBoxtaskqueue
            // 
            this.richTextBoxtaskqueue.Location = new System.Drawing.Point(19, 19);
            this.richTextBoxtaskqueue.Name = "richTextBoxtaskqueue";
            this.richTextBoxtaskqueue.Size = new System.Drawing.Size(178, 303);
            this.richTextBoxtaskqueue.TabIndex = 2;
            this.richTextBoxtaskqueue.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить файл для запуска";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.textBoxLanValueOff);
            this.panel3.Controls.Add(this.textBoxProcessorValueOff);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.buttonOffTime);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(12, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 339);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2016, 6, 1, 13, 20, 45, 0);
            // 
            // textBoxLanValueOff
            // 
            this.textBoxLanValueOff.Location = new System.Drawing.Point(324, 161);
            this.textBoxLanValueOff.Name = "textBoxLanValueOff";
            this.textBoxLanValueOff.Size = new System.Drawing.Size(53, 20);
            this.textBoxLanValueOff.TabIndex = 13;
            // 
            // textBoxProcessorValueOff
            // 
            this.textBoxProcessorValueOff.Location = new System.Drawing.Point(324, 125);
            this.textBoxProcessorValueOff.Name = "textBoxProcessorValueOff";
            this.textBoxProcessorValueOff.Size = new System.Drawing.Size(53, 20);
            this.textBoxProcessorValueOff.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Выключить компьютер если загрузка ЦП меньше ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Выключить компьютер если загрузка сети меньше";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(444, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Установить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(444, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Установить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonOffTime
            // 
            this.buttonOffTime.Location = new System.Drawing.Point(444, 47);
            this.buttonOffTime.Name = "buttonOffTime";
            this.buttonOffTime.Size = new System.Drawing.Size(75, 23);
            this.buttonOffTime.TabIndex = 3;
            this.buttonOffTime.Text = "Установить";
            this.buttonOffTime.UseVisualStyleBackColor = true;
            this.buttonOffTime.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Время выключения компьютера";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcProcessor
            // 
            this.pcProcessor.CategoryName = "Процессор";
            this.pcProcessor.CounterName = "% загруженности процессора";
            this.pcProcessor.InstanceName = "_Total";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(179, 373);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(92, 18);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.Location = new System.Drawing.Point(28, 373);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(35, 13);
            this.lblProcessor.TabIndex = 7;
            this.lblProcessor.Text = "label3";
            this.lblProcessor.Click += new System.EventHandler(this.lblProcessor_Click);
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "TCPv4";
            this.performanceCounter1.CounterName = "Segments Received/sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(597, 373);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 8;
            // 
            // timerOff
            // 
            this.timerOff.Tick += new System.EventHandler(this.timerOff_Tick);
            // 
            // timerproc
            // 
            this.timerproc.Tick += new System.EventHandler(this.timerproc_Tick);
            // 
            // timerlan
            // 
            this.timerlan.Tick += new System.EventHandler(this.timerlan_Tick);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // dateTimePickerOff
            // 
            this.dateTimePickerOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerOff.Location = new System.Drawing.Point(582, 246);
            this.dateTimePickerOff.Name = "dateTimePickerOff";
            this.dateTimePickerOff.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerOff.TabIndex = 15;
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 403);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProcessor);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Планировщик задач";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcProcessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem erdftgyhuiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fdghjkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиВыключенияToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox richTextBoxtaskqueue;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pcProcessor;
        private System.Windows.Forms.Label lblProcessor;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonOffTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerOff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLanValueOff;
        private System.Windows.Forms.TextBox textBoxProcessorValueOff;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timerproc;
        private System.Windows.Forms.Timer timerlan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.DateTimePicker dateTimePickerOn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DateTimePicker dateTimePickerOff;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

