﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            /*tadbirPrint.UserId = new InArgument<int>(1);
            tadbirPrint.WorkspaceId = new InArgument<int>(11);
            tadbirPrint.FPId = new InArgument<int>(2);
            tadbirPrint.SubsystemId = new InArgument<int>(5);
            tadbirPrint.ReportName = new InArgument<string>("پیش فاکتور فروش");
            tadbirPrint.ParamTypes = new InArgument<string>(new JavaScriptSerializer().Serialize(new String[] { "NUM" }));
            tadbirPrint.ParamValues = new InArgument<string>(new JavaScriptSerializer().Serialize(new String[] { "2" }));*/

            System.Activities.WorkflowInvoker.Invoke<string>(tadbirPrint);
        }
    }
}