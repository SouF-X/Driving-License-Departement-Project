using DVLD.Classes;
using DVLD.Tests.Controls;
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

namespace DVLD.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _AppointmentID;
        private clsTestType.enTestType _TestType;

        private int _TestID = -1;
        private clsTest _Test;


        public frmTakeTest(int AppointmentID, clsTestType.enTestType TestType)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _TestType = TestType;

        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduledTest2.TestTypeID = _TestType;

            ctrlScheduledTest2.LoadInfo(_AppointmentID);

            if (ctrlScheduledTest2.TestAppointmentID == -1)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;


            int _TestID = ctrlScheduledTest2.TestID;

            if (_TestID != -1)
            {
                _Test = clsTest.Find(_TestID);

                if (_Test.TestResult)
                    rbPass.Checked = true;
                else
                {
                    rbFail.Checked = true;
                    txtNotes.Text = _Test.Notes;
                }

                groupBox1.Visible = false;
                rbFail.Enabled = false;
                rbPass.Enabled = false;
                btnSave.Visible = false;
                kryptonButton1.Location = new Point(180, 734);
            }

            else
                _Test = new clsTest();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            _Test.TestAppointmentID = _AppointmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }
    }
}
