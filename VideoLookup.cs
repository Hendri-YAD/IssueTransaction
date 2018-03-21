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
    public partial class VideoLookup : Form
    {
        public VideoLookup()
        {
            InitializeComponent();
        }

        private void VideoLookup_Load(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            gridView_Video.DataSource = context.Movies.
                Select(x => new
                {
                    x.VideoCode,
                    x.MovieTitle,
                    x.MovieType
                }).ToList();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string TheValue
        {
            get
            {
                int pos = gridView_Video.CurrentCell.RowIndex;
                string test = gridView_Video.Rows[pos].Cells[0].Value.ToString();
                return test;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
