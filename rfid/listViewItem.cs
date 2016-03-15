using System;
using System.Windows.Forms;

namespace rfid
{
    internal class listViewItem
    {
        public object SubItems { get; internal set; }

        public static implicit operator listViewItem(ListViewItem v)
        {
            throw new NotImplementedException();
        }
    }
}