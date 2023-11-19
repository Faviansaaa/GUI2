namespace MengerjakanGUI1
{
    public partial class Form1 : Form
    {
        List<Instansi> listInstansi = new List<Instansi>();
        public Form1()
        {
            InitializeComponent();


            DummyData1();
        }

        private void DummyData1()
        {
            Instansi instansi1 = new Instansi();
            instansi1.Nama= "Inspektorat Jember";
            instansi1.Alamat = "Jalan Sudarman Nomor 1 Jember";
            instansi1.Email= "inspektorat@jemberkab.go.id";
            instansi1.No_Telpon = "(0331) 428823";
            instansi1.Kategori = "Pemerintah";
            instansi1.Status_Aktif = true;

            Instansi instansi2 = new Instansi();
            instansi2.Nama = "Dinas Kesehatan Jember";
            instansi2.Alamat = "Jalan Srikoyo I/3 Patrang Jember";
            instansi2.Email = "dinas.kesehatan@jemberkab.go.id";
            instansi2.No_Telpon = "(0331) 487577";
            instansi2.Kategori = "Kesehatan";
            instansi2.Status_Aktif = true;

            Instansi instansi3 = new Instansi();
            instansi3.Nama = "Gogo Fried Chicken";
            instansi3.Alamat = "Jl. Karimata Gg. Merpati";
            instansi3.Email = "gogojember@gmail.com";
            instansi3.No_Telpon = "081216867733";
            instansi3.Kategori = "Ekonomi";
            instansi3.Status_Aktif = true;

            Instansi instansi4 = new Instansi();
            instansi4.Nama = "Mitra Tani Dua Tujuh";
            instansi4.Alamat = "Jl. Brawijaya No.83";
            instansi4.Email = "mitratani27@mitratani27.co.id";
            instansi4.No_Telpon = "(0331) 422222";
            instansi4.Kategori = "Agrikultur";
            instansi4.Status_Aktif = true;

            listInstansi.Add(instansi1);
            listInstansi.Add(instansi2);
            listInstansi.Add(instansi3);
            listInstansi.Add(instansi4);
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = listInstansi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (entriData entriBaru = new entriData())
            {
                if (entriBaru.ShowDialog() == DialogResult.OK)
                {
                    Instansi newInstance = entriBaru.GetInstansi();
                    listInstansi.Add(newInstance);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listInstansi;

                    entriBaru.Close();
                }
                else
                {
                    entriBaru.Close();
                }
            }
        }
    }
}