namespace Lab07
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            gvTowns.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "�����";
            gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Country";
            column.Name = "�����";
            gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Region";
            column.Name = "�����";
            gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Population";
            column.Name = "���������";
            gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearIncome";
            column.Name = "г��. �����";
            gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Square";
            column.Name = "�����";
            column.Width = 80;
            gvTowns.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasPort";
            column.Name = "����";
            column.Width = 60;
            gvTowns.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasAirport";
            column.Name = "��������";
            column.Width = 60;
            gvTowns.Columns.Add(column);

            bindSrcTowns.Add(new Town("����", "������", "�������� ���.", 800000, 2000000, 400, false, true));
            EventArgs args = new EventArgs();
            OnResize(args);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            fTownn ft = new fTownn();
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.Add(ft.NewTown);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Town town = (Town)bindSrcTowns.List[bindSrcTowns.Position];
            fTownn ft = new fTownn();
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.List[bindSrcTowns.Position] = ft.NewTown;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�������� �������� �����?", "��������� ������", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcTowns.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�������� �������?\n\n�� ��� ������ �������", "�������� �����", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcTowns.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("������� ����������?", "����� � ��������", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
