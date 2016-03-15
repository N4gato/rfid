using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rfid
{
    class RfidSerial
    {
        public static readonly byte[] READ_TAG = { 0xa0, 0x03, 0x82, 0x00, 0xdb };
        public static readonly byte[] NO_TAG_RESP = { 0xe4, 0x04, 0x82, 0x00, 0x05, 0x91 };

        Queue<byte> data = new Queue<byte>();
        //byte[] data = new byte[256];
        int counter = 0;

        public delegate void DataReceivedHandler(Object source, byte[] tagid);
        public event DataReceivedHandler DataReceived;
        private SerialPort serialport;
        private System.Windows.Forms.Timer timer;

        public RfidSerial()
        {
            serialport = new SerialPort("COM3");
            serialport.DataReceived += Serialport_DataReceived;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 300;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            serialport.Write(READ_TAG, 0, READ_TAG.Length);
        }

        private void Serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            for (int i = 0; i < serialport.BytesToRead; i++)
            {
                data.Enqueue((byte)serialport.ReadByte());
            }
            while (data.Count > 0)
            {
                if (data.Peek() == 0xe0)
                {
                    if (data.Count >= 18)
                    {
                        counter = 0;
                        /*string sdata = "";
                        for (int j = 0; j < 18; j++)
                            sdata += data[j].ToString("X");*/
                        byte[] d = new byte[18];
                        for (int j = 0; j < 18; j++)
                            d[j] = data.Dequeue();  
                        this.DataReceived(this, d);
                    }
                    else break;
                }
                else if (data.Peek() == 0xe0)
                {
                    if (data.Count >= NO_TAG_RESP.Length)
                    {
                        for (int j = 0; j < NO_TAG_RESP.Length; j++)
                            data.Dequeue();
                    }
                    else break;
                }
                else data.Dequeue();
            }
        }

        public void startCommuniation()
        {
            serialport.Open();
            timer.Start();
        }

        public void stopCommuniation()
        {
            timer.Stop();
            serialport.Close();
        }
    }
}
