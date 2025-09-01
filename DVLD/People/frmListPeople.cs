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

namespace DVLD.People
{
    public partial class frmListPeople: Form
    {
        public frmListPeople()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();

        //only select the columns that you want to show in the grid
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName",
                                                                                "GenderCaption", "DateOfBirth", "CountryName", "Phone", "Email");

        private void _RefreshPeopleList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName",
                                                                    "GenderCaption", "DateOfBirth", "CountryName", "Phone", "Email");

            dgvPeople.DataSource = _dtPeople;
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {

            dgvPeople.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();

            dgvPeople.Columns[0].HeaderText = "Person ID";
            dgvPeople.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvPeople.Columns[1].HeaderText = "National No";
            dgvPeople.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvPeople.Columns[2].HeaderText = "First Name";
            dgvPeople.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPeople.Columns[3].HeaderText = "Second Name";
            dgvPeople.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPeople.Columns[4].HeaderText = "Third Name";
            dgvPeople.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPeople.Columns[5].HeaderText = "Last Name";
            dgvPeople.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPeople.Columns[6].HeaderText = "Gender";
            dgvPeople.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvPeople.Columns[7].HeaderText = "Date Of Birth";
            dgvPeople.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPeople.Columns[8].HeaderText = "Nationality";
            dgvPeople.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvPeople.Columns[9].HeaderText = "Phone";
            dgvPeople.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPeople.Columns[10].HeaderText = "Email";
            dgvPeople.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        //////////////////////////// Filter Methods /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gender":
                    FilterColumn = "GenderCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value contains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = ""; // 🔹 Clears filter.
                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }



            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id is selected.
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            _dtPeople.DefaultView.RowFilter = ""; // 🔹 Clears filter.
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
        }

        //////////////////////////// Context Menu Methods ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                //Perform Delete and refresh
                if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void sendEmailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void phoneCallToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void dgvPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
