using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //RESİMLERİ KENDİ DİZİNİMDEN ÇEKTİĞİM İÇİN PİCTURBOX EKLENTİSİNİ VE KODLARINI KALDIRMAK ZORUNDA KALDIM.
        int aktifburc, aktifyukselen;
        string[] burc = { "Yükseleniniz KOVA", "Yükseleniniz BALIK", "Yükseleniniz KOÇ", "Yükseleniniz BOĞA", "Yükseleniniz İKİZLER", "Yükseleniniz YENGEÇ", "Yükseleniniz ASLAN", "Yükseleniniz BAŞAK", "Yükseleniniz TERAZİ", "Yükseleniniz AKREP", "Yükseleniniz YAY", "Yükseleniniz OĞLAK" };
        string gelen;
        string[] resimdizi = { "D:\\kova.png", "D:\\balik.png", "D:\\koc.png", "D:\\boga.png", "D:\\ikizler.png", "D:\\yengec.png", "D:\\aslan.png", "D:\\basak.png", "D:\\terazi.png", "D:\\akrep.png", "D:\\yay.png", "D:\\oglak.png" }; 
        string[] link = { "ova burç yorumları: </strong></span>", "lık burç yorumları: </strong></span>", "Koç burç yorumları: </strong></span>", "oğa burç yorumları: </strong></span>", "ler burç yorumları: </strong></span>", "geç burç yorumları: </strong></span>", "lan burç yorumları: </strong></span>", "şak burç yorumları: </strong></span>", "azi burç yorumları: </strong></span>", "rep burç yorumları:", "Yay burç yorumları: </strong></span>", "lak burç yorumları: </strong></span>" };
        private void button1_Click(object sender, EventArgs e)
        {
            int ay, gun;
            ay = Convert.ToInt32(dateTimePicker1.Value.Month);
            gun = Convert.ToInt32(dateTimePicker1.Value.Day);
            if ((ay == 1 & gun >= 21) || (ay == 2 & gun <= 18))
            {
                label1.Text = ("Burcunuz KOVA");
                aktifburc = 0;
                richTextBox2.Text = "Hayal güçleri sınırsız olmakla birlikte, düşünceleri bulundukları anın ötesinde, akılcı ve sezgiseldir. Kova 'lar dik kafalıdırlar. Kendilerini dinleyenlerin ne demek istediklerini anlamadıklarını sanırlar. Kovaları tanımlayan sözcük 'Biliyorum' dur. Kova burcu insanları sevecen tavırları ile tanınırlar. Bu kişiler bencil değildirler. Irk, cinsiyet ve sosyal durumuna bakmaksızın, herkesin ayni olanaklara sahip olmasını isterler. Modern görünüşlerine karşın, inatçı ve sabit fikirli olurlar. Onlara yaklaşmak çok zordur, çünkü ne kadar dostça davranırlarsa davransınlar, arada her zaman bir mesafe bırakırlar.";
            }
            else if ((ay == 2 & gun >= 19) || (ay == 3 & gun <= 20))
            {
                label1.Text = ("Burcunuz BALIK");
                aktifburc = 1;
                richTextBox2.Text = "Balık burcu olan kişiler genel olarak sabırlı, eli açık ve de duyarlı olan insanlardır. Bu kişilerin her daim büyük bir inandırma yetenekleri bulunmaktadır. Dürüst, sadık, vicdan sahibi ve de uysaldırlar. Her çevreye kolay bir şekilde ayak uydurabilirler. Genellikle hayal dünyalarında yaşarlar. Hayat görüşleri ciddi ancak gerçekçi değildirler. Balık burcu olan kişiler diğer burçlar arasında bulunan dış etkenlerden en fazla etkilenen kişilerdir. Hayal dünyasında çok mutlu olurlar.";
            }
            else if ((ay == 3 & gun >= 21) || (ay == 4 & gun <= 20))
            {
                label1.Text = ("Burcunuz KOÇ");
                aktifburc = 2;
                richTextBox2.Text = "Koç, Burçlar kuşağının ilk burcudur. Hareketli ve enerjik oluşları ile tanınırlar. Ben egoları çok fazla gelişmiştir. BEN, onların aynası olmuştur adeta. Bu burçta doğanlar çok pratiktirler. Olaylar karşısında coşkularını gizleyemezler. Yaşam yolunda canlılıklarını ve atılganlıklarını yitirmeden heyecanla ilerlerler. Merak ettikleri konularda olabildiğince yaratıcılardır. Amaçları doğrultusunda ilerlerken, kendilerini eylemleri ile kanıtlamak isterler. Eğer Koç'lar girişimde bulunacakları zaman izleyecekleri rotayı ayrıntıları ile planlarsa, enerjik yapılarının da yardımı ile daha da üretken olabilirler.";
            }
            else if ((ay == 4 & gun >= 21) || (ay == 5 & gun <= 21))
            {
                label1.Text = ("Burcunuz BOĞA");
                aktifburc = 3;
                richTextBox2.Text = "Boğa'lar hedefleri doğrultusunda ilerlerken, tüm dikkatlerini toplayabilme yeteneklerinin yanında maddecilikleri ile tanınırlar. SAHİP olma onların yaşam gerçekleridir. Bireysel ilişkiler konusunda son derece güvenilir olan Boğa'lar, insanlara yardım etmekten hoşlanırlar. Yaşamları boyunca güven ararlar ve bu yüzden kendilerini riske atmazlar. Amaçladıkları işler konusunda gösterdikleri sabır, bazen diğer kişileri çatlatacak boyutlarda olabilir."; 
            }
            else if ((ay == 5 & gun >= 22) || (ay == 6 & gun <= 21))
            {
                label1.Text = ("Burcunuz İKİZLER");
                aktifburc = 4;
                richTextBox2.Text = "İkizler burcu insanları hızlı düşüncelerine uygun çabuk hareket ederler. Ayni anda birkaç işi birden yapabilirler. Onların adapte olamayacakları iş yoktur. Bu yüzden değişik karakterli olmaları ile tanınırlar. Bu yapılarını her zaman görebilmek mümkündür. Son derece neşeli ve mutlu oldukları bir anda, aniden mutsuz olabilirler. Çevreleri tarafından sürekli yanlış anlaşılabilirler.";
            }
            else if ((ay == 6 & gun >= 22) || (ay == 7 & gun <= 22))
            {
                label1.Text = ("Burcunuz YENGEÇ");
                aktifburc = 5;
                richTextBox2.Text = "Yaşamlarındaki her konuda aşırı bir şekilde hassas, alıngan ve kuruntulu olan Yengeç'leri tanımlayan sözcük 'Hissederim' dir. Sorumluluk duyguları çok gelişmiştir. Her işte olağanüstü olan ayrıntıcılıkları, işlerinde mükemmeliyetçiliği getirir. Ayni sorumlulukları karşılarındakilerden de beklerler. Yengeç'ler duygusallıkları ve duyarlılıkları ile tanınırlar. Çevresindeki her insandan da ayni hassasiyeti bekledikleri için, kolay geçinilir tipler değildir.";
            }
            else if ((ay == 7 & gun >= 23) || (ay == 8 & gun <= 23))
            {
                label1.Text = ("Burcunuz ASLAN");
                aktifburc = 6;
                richTextBox2.Text = "Aslan kraldır, önderdir. Başkalarının yaşantılarını da onlar adına düzenlemek isterler. Her şeye karışırlar, kibirlidirler. Bu nedenle onları tanımlayan sözcük 'Yönetirim' dir. Yaşam sahnesinde her zaman parlayarak, odak noktası olmak isterler. Organizasyon güçleri çok fazladır. İsteklerini başkalarına kabul ettirmek, onlar için yaşamlarının 'olmazsa olmaz' şartıdır. ";
            }
            else if ((ay == 8 & gun >= 24) || (ay == 9 & gun <= 22))
            {
                label1.Text = ("Burcunuz BAŞAK");
                aktifburc = 7;
                richTextBox2.Text = "Yönetici gezegeninizden dolayı hep bilgiyi ararlar. Zekalarını kendilerine yardımcı olan bir hizmetçi gibi görürler. Bu nedenle Başak burcunu tanımlayan sözcük 'İncelerim “ dir. Başak'lar çalışkan ve pratik insanlar olup, yaşamlarındaki en önemli konu İş' tir. Güvendikleri kişilere yardım etmeyi sevmelerine rağmen, inanmadıkları ve tembel olduklarını bildikleri kişilere karşı soğuk davranırlar.";
            }
            else if ((ay == 9 & gun >= 23) || (ay == 10 & gun <= 23))
            {
                label1.Text = ("Burcunuz TERAZİ");
                aktifburc = 8;
                richTextBox2.Text = "Terazi burcu olan kişiler genellikle uyumlu ve sevecen olurlar. Bunun yanı sıra dengeli ve doğru bir şekilde hareket ederler. Bunun yanı sıra terazi burçları en sinirli anlarda bile mutlu olmayı başarırlar. Bu burçtaki kişiler çalışmayı ve yeni şeyler öğrenmeyi de çok severler. Aşkı ve sanatı çok seven terazi burçları bu alanlarda çalışmayı severler. Yaşamdan keyif almak için doğru adımlar atarlar.";
            }
            else if ((ay == 10 & gun >= 24) || (ay == 11 & gun <= 23))
            {
                label1.Text = ("Burcunuz AKREP");
                aktifburc = 9;
                richTextBox2.Text = "Akrepler kadar yaşamda tutkuyla yaşayan az insan vardır. Bu nedenle onları simgeleyen sözcük 'Arzuluyorum' dur. Hiçbir şeyi yarım bırakmazlar. Akreplerin güçleri gözlerinden okunur. Mimiklerini kontrol altında tutsalar bile, bakışları ile sevgilerini ya da nefretlerini aktarabilirler. Duygularına kapılırlarsa, tehlikeli olabilirler.";
            }
            else if ((ay == 11 & gun >= 23) || (ay == 12 & gun <= 21))
            {
                label1.Text = ("Burcunuz YAY");
                aktifburc = 10;
                richTextBox2.Text = "Kavrama yetenekleri gelişmiş olduğundan becerikliliklerinin de katkısı ile ele aldıkları her işte, özellikle ciddi işlerde ve felsefe konularında başarılı olurlar. Bu nedenle Yay Burcunu tanımlayan sözcük 'Görüyorum' dur. Yay burcu insanları içtenlikleri ve iyimser yaşam görüşleri ile tanınırlar. Gençliklerinde dikkatsiz, heyecanlı ve geleneklere aykırı davranışlar içinde olsalar da, geçmiş yanılgılarından en çok ders alan kişiler bu burçtan çıkar. Özgürlüklerine aşırı düşkünlerdir";
            }
            else if ((ay == 12 & gun >= 22) || (ay == 1 & gun <= 20))
            {
                label1.Text = ("Burcunuz OĞLAK");
                aktifburc = 11;
                richTextBox2.Text = "Geleceği ayrıntılı biçimde planlamaya çalışan Oğlak'lar bu özellikleri nedeniyle sık sık kuruntulara kapılarak, depresyona girerler. İşleri ile aşırı meşgul olduklarından, insanlarla zor ilişki kurarlar. Fakat, hiçbir zaman kendilerini yalnız hissetmezler. Bu nedenle onları tanımlayan sözcük 'Kullanırım' dır. Oğlaklar ciddilikleri, tutuculukları ve güçlü iradeleri ile tanımlanırlar.";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string adres = "https://indigodergisi.com/2021/12/astroloji-2022-burc-yorumlari/";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenbilgiler = new StreamReader(cevap.GetResponseStream(), System.Text.Encoding.UTF8);
            gelen = donenbilgiler.ReadToEnd().Replace("&#8217;", "'").Replace("&#8211;", "").Replace("&#8220;", " ").Replace("&#8221;", "");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {           
            int baslikbaslangic = gelen.IndexOf(link[aktifburc]) + 36;
            int baslangicbitis = gelen.Substring(baslikbaslangic).IndexOf("</p>");
            string baslik = gelen.Substring(baslikbaslangic, baslangicbitis);
            richTextBox1.Text = baslik;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            aktifyukselen=comboBox1.SelectedIndex + aktifburc;
            if (aktifyukselen <= 11)
            {
                label2.Text = burc[aktifyukselen];
            }
            else if (aktifyukselen > 11)
            {
                label2.Text = burc[aktifyukselen % 12];
            }
        }
    }
}
