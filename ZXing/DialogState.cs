using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZXing
{
    public class DialogState
    {
        public DialogResult result;

        public SaveFileDialog dialog;

        public void ThreadProcShowDialog()
        {

            result = dialog.ShowDialog();

        }

    }
}
