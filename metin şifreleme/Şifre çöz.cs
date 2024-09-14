public static string sıfre_coz(string mtn)
{
    string donecek = null;
    for (int ılk = mtn[0], s1, i = 1; i < mtn.Length; i++)
    {
        s1 = mtn[i];
        s1 = (s1 - ılk) / 2;
        donecek = donecek + ToChar(s1);
    }
    return donecek;
}
