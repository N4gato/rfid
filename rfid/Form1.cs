using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rfid
{
    public partial class Form1 : Form
    {
        public Form1() //constructer
        {
            InitializeComponent();
            //initiate the tag reader from serial
            RfidSerial rf = new RfidSerial();
            //subscribe to event
            rf.DataReceived += Rf_DataReceived;  
            //  Rf_DataReceived is a methode here. if its in another class. instance that class and call it

           // rf.startCommuniation();
        }

        private void Rf_DataReceived(object source, string tagid)
        {
            throw new NotImplementedException();
           // label1.Text = "Im from the on receied in form";
            //send it to data bae or file....

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox36_Enter(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }
    }
}
