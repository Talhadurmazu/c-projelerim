public static string sıfrele(string mtn)
{
    int ılk_harf = mtn[0] * 2;
    string donecek = null;
    int sayı;
    foreach (char harf in mtn)
    {
        sayı = harf;
        sayı = (sayı * 2) + ılk_harf;
        donecek = donecek + ToChar(sayı);
    }
    donecek = ToChar(ılk_harf) + donecek;
    return donecek;
}
