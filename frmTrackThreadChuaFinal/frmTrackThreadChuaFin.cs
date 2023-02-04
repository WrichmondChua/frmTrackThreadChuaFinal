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

namespace frmTrackThreadChuaFinal
{
    public partial class frmTrackThreadChuaFin : Form
    {
        public frmTrackThreadChuaFin()
        {
            InitializeComponent();
        }
        public void MyThreads()
        {
            LabelThread.Text = "-Thread Starts-";

            Debug.WriteLine("-Thread Starts-");

            MyThreadClass ThreadClass = new MyThreadClass();

            Thread threadA = new Thread(new ThreadStart(ThreadClass.thread1));

            Thread threadB = new Thread(new ThreadStart(ThreadClass.thread2));

            Thread threadC = new Thread(new ThreadStart(ThreadClass.thread1));

            Thread threadD = new Thread(new ThreadStart(ThreadClass.thread2));

            threadA.Priority = ThreadPriority.Highest;
            threadA.Name = "Thread A Process";

            threadB.Priority = ThreadPriority.Normal;
            threadB.Name = "Thread B Process";

            threadC.Priority = ThreadPriority.AboveNormal;
            threadC.Name = "Thread C Process";

            threadD.Priority = ThreadPriority.BelowNormal;
            threadD.Name = "Thread D Process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();
            Debug.WriteLine("-End of Thread-");

            LabelThread.Text = "-End of Thread-";

        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            MyThreads();
        }
    }
}
