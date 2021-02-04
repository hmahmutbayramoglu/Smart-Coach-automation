using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCoachTester
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
        ICalismaProgramiService _dersCalismaService = new DersCalismaManager(new EfCalismaProgramiDal());

        private void TestForm_Load(object sender, EventArgs e)
        {

            try
            {
                DataGrid1.DataSource = _dersCalismaService.GetAll();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }



        }
    }
}
