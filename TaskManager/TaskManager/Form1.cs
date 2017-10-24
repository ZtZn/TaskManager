using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.Management.Instrumentation;


namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void настройкаЗапускаПрограммToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fdghjkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void erdftgyhuiToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

       
      
        private void Form1_Load(object sender, EventArgs e)
        {


            
            
        }
        // выбираем файл
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                labelFileName.Text = openFileDialog1.FileName;

                sr.Close();
            }
            panel2.Visible=true;
        }

        private void textBoxFeliName_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        { 
            //добавляет в тексбокс
            richTextBoxtaskqueue.AppendText("\n");
            richTextBoxtaskqueue.AppendText(labelFileName.Text);
            richTextBoxtaskqueue.AppendText("--------");
            richTextBoxtaskqueue.AppendText(textBoxTime.Text);
            panel2.Visible = false;
            //запуск асинхронного кода
            if (backgroundWorker1.IsBusy != true)
            {
                
                backgroundWorker1.RunWorkerAsync();
            }
            
            
           
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //загрузка процессора
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 1000000;
            progressBar1.Value = (int)(pcProcessor.NextValue());
            lblProcessor.Text = "Загрузка процессора: " + progressBar1.Value.ToString() + "%";
            // сетевой обмен
            progressBar2.Value = (int)(performanceCounter1.NextValue());
            label3.Text = "Интенсивность сетевого обмена: " + progressBar2.Value.ToString() + "received/sec";
        }
        //вывод формы
        private void настройкиВыключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lblProcessor_Click(object sender, EventArgs e)
        {

        }
        // таймер выключения по времени
        private void timerOff_Tick(object sender, EventArgs e)
        {


            if (ShowTime > DateTime.Now.TimeOfDay)
            {
                TimeSpan ts = ShowTime - DateTime.Now.TimeOfDay;
               label7.Text = "Осталось времени до выключения:" + ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds;
                label7.Visible = true;
            }
            else
            {
                Process.Start("shutdown", "/s /t 0");
                Close();
            }
        }
         
         TimeSpan ShowTime;
         // запуск таймера выключения по времени
        private void button3_Click(object sender, EventArgs e)
        {            
           ShowTime = dateTimePicker1.Value.TimeOfDay;
                   timerOff.Start();

        }
        // запуск таймера выключения по процессору
        private void button4_Click(object sender, EventArgs e)      {
            timerproc.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timerlan.Start();
        }
        // таймер для выключения по прецессору
        private void timerproc_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt16(textBoxProcessorValueOff.Text) >  Convert.ToInt16((pcProcessor.NextValue())))
            {
                Process.Start("shutdown", "/s /t 0");
                Close();
            }
        }
        // таймер по сети
        private void timerlan_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt16(textBoxLanValueOff.Text) > (int)(performanceCounter1.NextValue())) ;
            {
                Process.Start("shutdown", "/s /t 0");
                Close();
            }
        }
        
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
        // выполнянт асинхронный код для запуска файлов
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ClassTasks cs = new ClassTasks(openFileDialog1.FileName, Convert.ToDouble(textBoxTime.Text));
            backgroundWorker1.RunWorkerAsync(cs);
        }
        // устанавливает время открывания закрывания консоли и отправляемое сообщение
        private void button3_Click_1(object sender, EventArgs e)
        {
            
            if (backgroundWorker2.IsBusy != true)
            {

                backgroundWorker2.RunWorkerAsync();
                
                timer2.Start();
                
            }
            if (backgroundWorker3.IsBusy != true)
            {

                backgroundWorker3.RunWorkerAsync();


            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            
            
        }
        Process proc1 = new Process();

        // открывет консоль и вызывает перегруженный метод класса где посылаются сообщения
        private void timer2_Tick(object sender, EventArgs e)
        {
            

           ClassTasks css = new ClassTasks(richTextBoxMessage.Text, dateTimePickerOn.Value.TimeOfDay, dateTimePickerOff.Value.TimeOfDay);
            backgroundWorker2.RunWorkerAsync(css);
           if (dateTimePickerOff.Value.TimeOfDay < DateTime.Now.TimeOfDay)
           {
               proc1.CloseMainWindow();
           }

        }
        // открывает консоль новый поток
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
           proc1  = Process.Start("NewProcess.exe");
           
        }
        //кнопка выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
        
    

