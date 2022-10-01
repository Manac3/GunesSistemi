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
            

            //MessageBox.Show(nameof(GokCismiBase)); //parantez i�indekinin ad�n� d�ner classa class ad� de�ilse i�te ne ad�ysa onu d�ner

            if (gokCismi.GetType() == typeof(Yildiz))
            {
               Yildiz yildiz =  (gokCismi as Yildiz); //type of da da tipini d�ner gokcismini yildiz olarak alg�lad� ��nk� biz gokcismini 3 farkl� �ekilde tan�mlam��t�k
                MessageBox.Show($"Id: {yildiz.Id}\nAd�: {yildiz.Adi}\nYar��ap: {yildiz.YariCap}\nS�cakl�k : {yildiz.SicaklikC} C ({yildiz.SicaklikF} F)", nameof(Yildiz));

            }

            else if (gokCismi.GetType() == typeof(Uydu))
            {
                Uydu uydu = (gokCismi as Uydu); 

                MessageBox.Show($"Id: {uydu.Id}\nAd�: {uydu.Adi}\nYar��ap: {uydu.YariCap}\nGezegenId:  {uydu.GezegenId}", nameof(Uydu));
            }

            else 
            {
                Gezegen gezegen = (gokCismi as Gezegen);
                string yasam = gezegen.YasamVarMi ? "ya�am var" : " ya�am yok";
                MessageBox.Show($"Id: {gezegen.Id}\nAd�: {gezegen.Adi}\nYar��ap: {gezegen.YariCap}\nYasamVarmi :  {yasam} \nY�ld�z Id :  {gezegen.YildizId}", nameof(Gezegen));
            }
            //en son name of yazarak message boxa bi g�rev daha verdik ve �ste olay�n ad�n� yazd�rd�k... 
        }
    }
}