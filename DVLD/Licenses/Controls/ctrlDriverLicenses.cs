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
using DVLD;
//using DVLD.Licenses.International_Licenses;

namespace DVLD.Licenses.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID;
        private clsDriver _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;

        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        private void _LoadLocalLicenseInfo()
        {

            _dtDriverLocalLicensesHistory = clsDriver.GetLicenses(_DriverID);


            dgvLocalLicensesHistory.DataSource = _dtDriverLocalLicensesHistory;
            lblLocalLicensesRecords.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

            if (dgvLocalLicensesHistory.Rows.Count > 0)
            {
                dgvLocalLicensesHistory.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicensesHistory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                dgvLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
                dgvLocalLicensesHistory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;



                dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                dgvLocalLicensesHistory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicensesHistory.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicensesHistory.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvLocalLicensesHistory.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            }
        }

        private void _LoadInternationalLicenseInfo()
        {

            _dtDriverInternationalLicensesHistory = clsDriver.GetInternationalLicenses(_DriverID);


            dgvInternationalLicensesHistory.DataSource = _dtDriverInternationalLicensesHistory;
            lblInternationalLicensesRecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();

            if (dgvInternationalLicensesHistory.Rows.Count > 0)
            {

                dgvInternationalLicensesHistory.Columns[0].HeaderText = "Int.Lic ID";
                dgvInternationalLicensesHistory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                dgvInternationalLicensesHistory.Columns[1].HeaderText = "App.ID";
                dgvInternationalLicensesHistory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                dgvInternationalLicensesHistory.Columns[2].HeaderText = "L.License ID";

                dgvInternationalLicensesHistory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                dgvInternationalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicensesHistory.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                dgvInternationalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicensesHistory.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                dgvInternationalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicensesHistory.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDriver.FindByDriverID(_DriverID);

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();

        }

        public void LoadInfoByPersonID(int PersonID)
        {

            _Driver = clsDriver.FindByPersonID(PersonID);
            if (_Driver != null)
            {
                _DriverID = clsDriver.FindByPersonID(PersonID).DriverID;
            }

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }

/*        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLocalLicensesHistory.CurrentRow.Cells[0].Value;
            DriverLicense.frmShowLicenseInfo frm = new DriverLicense.frmShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }*/

        public void Clear()
        {
            _dtDriverLocalLicensesHistory.Clear();

        }

/*        private void InternationalLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvInternationalLicensesHistory.CurrentRow.Cells[0].Value;
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(InternationalLicenseID);
            frm.ShowDialog();
        }*/
    }
}
