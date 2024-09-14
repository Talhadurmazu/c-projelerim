static void Main(string[] args)
{
    Write("Metin: ");
    string mtn = ReadLine();
    string sıfre = sıfrele(mtn);
    WriteLine();
    WriteLine($"Orjinal Metin: {mtn}");
    WriteLine();
    WriteLine($"Şifreli Metin: {sıfre}");
    WriteLine();
    WriteLine($"Çözülen Şifre: {sıfre_coz(sıfre)}");
}
