using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.StudentManagement
{
    public partial class CreateForm : Form
    {
        private LogicLayer Business;
        public CreateForm()
        {
            InitializeComponent();
            this.Business = new LogicLayer();
            this.Load += CreateForm_Load;
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var code = this.txtCode.Text;
            var name = this.txtCode.Text;
            var birthday = this.dtp.Value;
            var class_id = (int)this.cboClass.SelectedValue;
            this.Business.CreateStudent(code, name, birthday, class_id);
            MessageBox.Show("Create student succesfully.");
            this.Close();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void CreateForm_Load(object sender, EventArgs e)
        {
            this.cboClass.DataSource = this.Business.GetClasses();
            this.cboClass.DisplayMember = "Name";
            this.cboClass.ValueMember = "id";
        }



    }
}
