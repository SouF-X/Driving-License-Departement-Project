using SFX_DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.ApplicationTypes
{
    public partial class frmListApplicationTypes: Form
    {
        private DataTable _dtAllApplicationTypes;

        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _dtAllApplicationTypes = clsApplicationType.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = _dtAllApplicationTypes;
            lblRecordsCount.Text = dgvApplicationTypes.Rows.Count.ToString();

            if (dgvApplicationTypes.Rows.Count > 0)
            {
                dgvApplicationTypes.Columns["ApplicationTypeTitle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvApplicationTypes.Columns["ApplicationTypeID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvApplicationTypes.Columns["ApplicationFees"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvApplicationTypes.Columns["ApplicationFees"].DefaultCellStyle.Format = "$#,0.00";
            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationTypes frm = new frmEditApplicationTypes((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageApplicationTypes_Load(null, null);

        }

    }
}
