using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTran
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            IssueTran i = context.IssueTrans.
                Where(x => x.TransactionID.ToString() == tb_transactionID.Text).First();
            i.RentalStatus = "in";
            i.DateActualReturn = DTP_DateReturn.Value;

            Movie m = context.Movies.
                Where(x => x.VideoCode == i.VideoCode).First();
            m.NumberRented--;

            context.SaveChanges();
        }
    }
}
