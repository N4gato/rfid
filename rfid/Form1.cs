using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        delegate void addItemCallback(string id); // creati delegate , 
        public Form1() //constructer
        {
            InitializeComponent();
            //initiate the tag reader from serial
            RfidSerial rf = new RfidSerial();
            //subscribe to event
            rf.DataReceived += Rf_DataReceived;
            //  Rf_DataReceived is a methode here. if its in another class. instance that class and call it

            rf.startCommuniation();
            // rf.stopCommuniation();





        }

        private void Rf_DataReceived(object source, byte[] tagId )
        {
            // label1.Text = "Im from the on receied in form";
            //send it to data bae or file....
            string datas="";
            for (int i = 5; i < 10; i++) {
                datas +=tagId[i].ToString("X");
            }
            Console.WriteLine(datas);
            addItemCallback aic = new addItemCallback(addItem);
            this.Invoke(aic, datas); // because add item 
        }

        void addItem(string id)
        {
            ListViewItem lvi = new ListViewItem("1");
            lvi.SubItems.Add(id);
            lvi.SubItems.Add("12/16/2016");
            lvi.SubItems.Add("Rabat");
            lvi.SubItems.Add("Out");
            //listView1.Items.Clear();
            listView1.Items.Add(lvi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            SqlDataReader reader = db.dbGet();

            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader["id"].ToString());
                lvi.SubItems.Add(reader["TagId"].ToString());
                lvi.SubItems.Add(reader["Date"].ToString());
                lvi.SubItems.Add(reader["Destination"].ToString());
                lvi.SubItems.Add(reader["Status"].ToString());
                listView1.Items.Clear();
                listView1.Items.Add(lvi);

            }
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
