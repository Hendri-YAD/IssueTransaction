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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }       

        private void CIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    DafestyEntities context = new DafestyEntities();

                    Customer c = context.Customers.
                        Where(x => x.CustomerID == CIDTextBox.Text).First();

                    CustNameTextBox.Text = c.CustomerName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Not Found");
                CustNameTextBox.Text = "";
            }
           
        }
        private void VideoCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    DafestyEntities context = new DafestyEntities();

                    Movie m = context.Movies.
                        Where(x => x.VideoCode.ToString() == VideoCodeTextBox.Text).First();

                    MovieTitleTextBox.Text = m.MovieTitle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Found");
                MovieTitleTextBox.Text = "";
            }
        }

        private void CustLookupButton_Click(object sender, EventArgs e)
        {
            using(CustomerLookup custForm = new CustomerLookup())
            {
                if (custForm.ShowDialog() == DialogResult.OK)
                {
                    CIDTextBox.Text = custForm.TheValue;

                    try
                    {
                        DafestyEntities context = new DafestyEntities();

                        Customer c = context.Customers.
                            Where(x => x.CustomerID == CIDTextBox.Text).First();

                        CustNameTextBox.Text = c.CustomerName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Not Found");
                    }
                    
                }
            }
            
        }

        private void VideoLookupButton_Click(object sender, EventArgs e)
        {
            using(VideoLookup videoForm = new VideoLookup())
            {
                if(videoForm.ShowDialog() == DialogResult.OK)
                {
                    VideoCodeTextBox.Text = videoForm.TheValue;

                    try
                    {
                        DafestyEntities context = new DafestyEntities();

                        Movie m = context.Movies.
                            Where(x => x.VideoCode.ToString() == VideoCodeTextBox.Text).First();

                        MovieTitleTextBox.Text = m.MovieTitle;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Not Found");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int numberOfDaysRent = 3;
            DueDateDTP.Value = IssueDateDTP.Value.AddDays(numberOfDaysRent);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            IssueTran i = new IssueTran();

            i.CustomerID = CIDTextBox.Text;
            i.VideoCode = Convert.ToInt16(VideoCodeTextBox.Text);
            i.DateIssue = IssueDateDTP.Value;
            i.DateDue = DueDateDTP.Value;
            i.RentalStatus = "out";
            i.Remarks = RemarksTextBox.Text;

            context.IssueTrans.Add(i);

            Movie m = context.Movies.
                Where(x => x.VideoCode.ToString() == VideoCodeTextBox.Text).First();

            m.NumberRented++;

            context.SaveChanges();
        }
    }
}
