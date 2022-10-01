using GunesSistemi.Models.Bases;
using GunesSistemi.Services.Bases;

namespace GunesSistemi
{
    public partial class Form1 : Form
    {
        IGokCismiService _servis = new GokCismiService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GokCismiBase[] gokCisimleri = _servis.Listele();
            dgvGokCisimleri.DataSource = gokCisimleri;
            

        }

        

        private void dgvGokCisimleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvGokCisimleri.SelectedRows[0].Cells[0].Value.ToString());
             GokCismiBase gokCismi = _servis.DetayGetir(id);
            

            //MessageBox.Show(nameof(GokCismiBase)); //parantez içindekinin adýný döner classa class adý deðilse iþte ne adýysa onu döner

            if (gokCismi.GetType() == typeof(Yildiz))
            {
               Yildiz yildiz =  (gokCismi as Yildiz); //type of da da tipini döner gokcismini yildiz olarak algýladý çünkü biz gokcismini 3 farklý þekilde tanýmlamýþtýk
                MessageBox.Show($"Id: {yildiz.Id}\nAdý: {yildiz.Adi}\nYarýÇap: {yildiz.YariCap}\nSýcaklýk : {yildiz.SicaklikC} C ({yildiz.SicaklikF} F)", nameof(Yildiz));

            }

            else if (gokCismi.GetType() == typeof(Uydu))
            {
                Uydu uydu = (gokCismi as Uydu); 

                MessageBox.Show($"Id: {uydu.Id}\nAdý: {uydu.Adi}\nYarýÇap: {uydu.YariCap}\nGezegenId:  {uydu.GezegenId}", nameof(Uydu));
            }

            else 
            {
                Gezegen gezegen = (gokCismi as Gezegen);
                string yasam = gezegen.YasamVarMi ? "yaþam var" : " yaþam yok";
                MessageBox.Show($"Id: {gezegen.Id}\nAdý: {gezegen.Adi}\nYarýÇap: {gezegen.YariCap}\nYasamVarmi :  {yasam} \nYýldýz Id :  {gezegen.YildizId}", nameof(Gezegen));
            }
            //en son name of yazarak message boxa bi görev daha verdik ve üste olayýn adýný yazdýrdýk... 
        }
    }
}