namespace Lab07
{
    public partial class fTownn : Form
    {
        public fTownn()
        {
            InitializeComponent();
        }
        public Town NewTown { get; private set; }
        public class fTown
        {
            public string Name;
            public string Country;
            public string Region;
            public int Population;
            public double YearIncome;
            public double Square;
            public bool HasPort;
            public bool HasAirport;
            public double yearIncomePerInhabitant
            {
                get { return GetYearIncomePerInhabitant(); }
            }
            public double GetYearIncomePerInhabitant()
            {
                return Population > 0 ? YearIncome / Population : 0;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Town town = new Town();
            town.Name = tbName.Text;
            town.Country = tbCountry.Text;
            town.Region = tbRegion.Text;
            town.Population = int.Parse(tbPopulation.Text);
            town.YearIncome = double.Parse(tbYearIncome.Text);
            town.Square = double.Parse(tbSquare.Text);
            town.HasPort = cbPort.Checked;
            town.HasAirport = cbAirport.Checked;

            NewTown = town;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancl_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
