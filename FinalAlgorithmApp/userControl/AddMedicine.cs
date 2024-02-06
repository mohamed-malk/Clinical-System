using System;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class AddMedicine : Form
    {
        private int apoitmentIndex;
        private DetailAppDocCon
            perentCon;

        public DetailAppDocCon
            PerentCon
        {
            set => perentCon = value;
            get => perentCon;
        }

        public AddMedicine(int apoitmentIndex)
        {
            this.apoitmentIndex = apoitmentIndex;

            InitializeComponent();
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                Medicine med = new Medicine
                    (nameTxt.Text, int.Parse(quantity.Text));

                // add (as) neew medicine to appoitment of doctor 
                ((Appoitment)perentCon.ParentForm.
                     doctor.Appoitments[apoitmentIndex]).
                     addMedicine(ref med);

                // add new Medicine to grid view
                perentCon.AddtoGridMed(nameTxt.Text,
                     int.Parse(quantity.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show(Messages.Numeric);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
