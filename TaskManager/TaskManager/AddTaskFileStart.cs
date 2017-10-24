using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class AddTaskFileStart : Form
    {
        public String Path;
        public String Time;
        public AddTaskFileStart()
        {
            InitializeComponent();
        }

        private void AddTaskFileStart_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Path = textBoxFeliName.Text;
            Time = textBoxTime.Text;
            
            
            this.Close();
        }
    }
}
