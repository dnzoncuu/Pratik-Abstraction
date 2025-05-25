using Pratik___Abstraction;

Yazilimci yazilim = new Yazilimci
{
    _ad = "Deniz",
    _soyad = "Öncü",
    _departman = "Bilgi İşlem",
    
};
yazilim.BilgileriYazdır();
yazilim.Görev();
Console.WriteLine("-------------------------------------------");
ProjeYonetimi yönetici = new ProjeYonetimi
{
    _ad = "Sergen",
    _soyad = "Yalçın",
    _departman = "yönetici"
};
yönetici.BilgileriYazdır();
yönetici.Görev();
Console.WriteLine("-------------------------------------------");
Patron  patron = new Patron
{
    _ad = "Ali",
    _soyad = "Koç",
    _departman = "İstifa etme bizi bırakma"
};
patron.BilgileriYazdır();
patron.Görev();