using System.Security.Policy;

namespace Lab072
{
    public partial class fCarr : Form
    {
        public fCarr()
        {
            InitializeComponent();
        }
        public Car NewCar { get; private set; }
        public class fCar
        {
            public string Brand;
            public string Model;
            public int Year;
            public double VEngine;
            public string TypeFuel;
            public int Probig;
            public double SerednyaVitrataFuel;
            public double Price;
            public double FuelPrice;
            public double FuelPricePer100Km
            {
                get
                {
                    return GetFuelPricePer100Km();
                }
            }
            public double GetFuelPricePer100Km()
            {
                return SerednyaVitrataFuel * FuelPrice;
            }

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Brand = tbBrand.Text;
            car.Model = tbModel.Text;
            car.Year = int.Parse(tbYear.Text);
            car.VEngine = double.Parse(tbVEngine.Text);
            car.TypeFuel = tbTypeFuel.Text;
            car.Probig = int.Parse(tbProbig.Text);
            car.SerednyaVitrataFuel = double.Parse(tbSerednyaVitrataFuel.Text);
            car.Price = double.Parse(tbPrice.Text);
            car.FuelPrice = double.Parse(tbFuelPrice.Text);

            NewCar = car;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
