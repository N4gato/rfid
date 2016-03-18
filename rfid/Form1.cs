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
        delegate void addItemCallback(string id); // creati delegate 
        int LatsId = 0;
        public Form1() //constructer
        {
            InitializeComponent();
            //initiate the tag reader from serial
            RfidSerial rf = new RfidSerial();
            Db db = new Db();
            //subscribe to event
            rf.DataReceived += Rf_DataReceived;
            rf.DataReceived += db.storeId;
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
            //Console.WriteLine(datas);
            addItemCallback aic = new addItemCallback(addItem); //init the delegate 
            this.Invoke(aic, datas); // this tread please invoke or take controle of datas that belong to other thread 
            //with my methode Additem

            //this.Invoke is like : take my methode addItem and give to it 
        }

        void addItem(string id)
        {
            //Db db = new Db();
            //SqlDataReader lastId = db.getlastId();
            //lastId.Read();
            //int lastID = (int) lastId["Id"];
            //ListViewItem lvi = new ListViewItem((lastID + 1 ).ToString());
            ListViewItem lvi = new ListViewItem("1");
            lvi.SubItems.Add(id);
            lvi.SubItems.Add(System.DateTime.Now.ToString());
            lvi.SubItems.Add("Rabat");
            lvi.SubItems.Add("Out");
            //listView1.Items.Clear();
            listView1.Items.Add(lvi);
        }

        //public void setLastId() {
        //    Db db = new Db();
        //    SqlDataReader lastId = db.getlastId();
        //    lastId.Read();
        //    int lastID = (int)lastId["Id"];
        //}

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
               // listView1.Items.Clear();
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

        private void button26_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //removeselected
            if (listView1.SelectedItems.Count == 0) {
                MessageBox.Show("Select an item");
            }else listView1.SelectedItems[0].Remove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an item");
                return;
            }
             
                string Iditem =  listView1.SelectedItems[0].SubItems[0].Text ;
            if (Iditem == "1") {
                MessageBox.Show("Delete this item from History");
                return;
            }
            //delet from da with id = Iditem
            Db db = new Db();
            db.deletItem(Iditem);
            listView1.SelectedItems[0].Remove();


        }

        private void label59_Click(object sender, EventArgs e)
        {

        }
    }
}
