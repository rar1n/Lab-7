namespace Lab072
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
            gvCars.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Brand";
            column.Name = "�����";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "������";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Year";
            column.Name = "г� �������";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "VEngine";
            column.Name = "��'�� �������";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TypeFuel";
            column.Name = "��� ��������";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Probig";
            column.Name = "�����";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SerednyaVitrataFuel";
            column.Name = "������� ������� ��������";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "ֳ�� ���������";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "FuelPrice";
            column.Name = "ֳ�� ��������";
            gvCars.Columns.Add(column);

            bindSrcCars.Add(new Car("Mercedes", "CLE 450 Coupe", 2024, 3.0, "������", 10000, 8, 4000000, 57));
            EventArgs args = new EventArgs();
            OnResize(args);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fCarr fc = new fCarr();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                bindSrcCars.Add(fc.NewCar);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Car car = (Car)bindSrcCars.List[bindSrcCars.Position];
            fCarr fc = new fCarr();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                bindSrcCars.List[bindSrcCars.Position] = fc.NewCar;
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�������� �������� �����?", "��������� ������", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcCars.RemoveCurrent();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�������� �������?\n\n�� ��� ������ �������", "�������� �����", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcCars.Clear();
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
