using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rfid
{
    
    class RfidSerial{

        public delegate void DataReceivedHandler(Object source,string tagid);
        public event DataReceivedHandler DataReceived;
        private Thread t = new Thread(run);
        public static readonly byte[] READ_TAG = { 0xa0, 0x03, 0x82, 0x00, 0xdb };
        static SerialPort serialport;

        public void startCommuniation()
        {
            t = new Thread(run);
            t.Start();
        }

        public void stopCommuniation()
        {
            t.Join();
            t.Interrupt();
        }


        static void run()
        {
            serialport = new SerialPort();
            serialport.PortName = "COM4";
            //timeout to wait for respond
            serialport.ReadTimeout = 3000;
            byte[] data = new byte[20];
            try
            {
                serialport.Open();
            }
            catch { }
            while (serialport.IsOpen) {
                //ask the reader to read tag.
                serialport.Write(READ_TAG, 0, READ_TAG.Length);
                try{
                    for (int i = 0; i < 17; i++)
                        data[i] = (byte)serialport.ReadByte();

                    //traitement de donnee//
                    string id = "";
                    RfidSerial rf = new RfidSerial();
                    rf.OnDataReveived(id);
                    Thread.Sleep(100);
                }
                catch (TimeoutException) { }//check if time out counter = 3000 is dead
            }

            if (serialport.IsOpen)
                serialport.Close();
        }

        public virtual void OnDataReveived(String tagId) {
            if (DataReceived != null) ;
                DataReceived(this , tagId);
        }
        

    }
}
