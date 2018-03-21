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
    public partial class CustomerLookup : Form
    {
        public CustomerLookup()
        {
            InitializeComponent();
        }


        private void CustomerLookup_Load(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            CustGridView.DataSource = context.Customers.
                Select(x => new
                {
                    x.CustomerID,
                    x.CustomerName,
                    x.MemberCategory
                }).ToList();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string TheValue
        {          
            get {
                int pos = CustGridView.CurrentCell.RowIndex;
                string test = CustGridView.Rows[pos].Cells[0].Value.ToString();
                return test;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
