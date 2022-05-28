using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueTestApp
{
    public partial class Form1 : Form
    {
        Queue<string> qStr=new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = new Random().Next().ToString();
            qStr.Enqueue(item);
            lbAdd.Items.Add(item);
            ShowCurrent();
        }
        private void ShowCurrent()
        {
            lbCurrent.Items.Clear();
            foreach (var item in qStr)
            {
                lbCurrent.Items.Add(item);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (qStr.Count > 0)
            {
                string item = qStr.Dequeue();
                lbRemove.Items.Add(item);
                ShowCurrent();
            }
        }
    }

}
