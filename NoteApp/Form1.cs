using System.Data;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        int currentReadIdx;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Message", typeof(string));
            dataGridView1.DataSource = table;

            dataGridView1.Columns["Message"].Visible = false;
        }

        private void Clear()
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);
            Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            currentReadIdx = dataGridView1.CurrentCell.RowIndex;

            if (currentReadIdx > -1)
            {
                txtTitle.Text = table.Rows[currentReadIdx].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[currentReadIdx].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if(index == currentReadIdx)
            {
                Clear();
            }
            table.Rows[index].Delete();
        }

        private void txtBox_Changed(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
