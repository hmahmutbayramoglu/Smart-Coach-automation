using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCoachTestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ICalismaProgramiService _calismaProgramiService = new DersCalismaManager(new EfCalismaProgramiDal());
        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = _calismaProgramiService.GetAll();
        }
    }
}
