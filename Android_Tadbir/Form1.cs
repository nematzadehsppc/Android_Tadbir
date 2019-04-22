using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Android_Tadbir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasePrint.TadbirPrint tadbirPrint = new BasePrint.TadbirPrint();

            tadbirPrint.UserId = new InArgument<int>(1);
            tadbirPrint.WorkspaceId = new InArgument<int>(12);
            tadbirPrint.FPId = new InArgument<int>(4);
            tadbirPrint.SubsystemId = new InArgument<int>(5);
            tadbirPrint.ReportName = new InArgument<string>("پیش فاکتور فروش");
            tadbirPrint.ParamTypes =  "NUM"; 
            tadbirPrint.ParamValues = "1";

            System.Activities.WorkflowInvoker.Invoke<string>(tadbirPrint);
        }
    }
}
