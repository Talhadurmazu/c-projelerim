public static string sıfre_coz(string mtn)
{
    int ılk = ToInt32(mtn[0]) / 2;
    string mtn2 = null;
    int sayı;
    for (int i = 1; i < mtn.Length; i++)
    {
        sayı = ToInt32(mtn[i]);
        sayı -= ToInt32(ılk * 2);
        sayı = sayı / 2;
        mtn2 = mtn2 + ToChar(sayı);
    }
    return mtn2;
}