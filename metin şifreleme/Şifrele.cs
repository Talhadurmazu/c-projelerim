public static string sıfrele(string mtn)
{
    int ılk = ToInt32(mtn[0]) * 2;
    string mtn2 = null;
    int sayı;
    foreach (char item in mtn)
    {
        sayı = ToInt32(item);
        sayı = sayı * 2 + ToInt32(ılk);
        mtn2 = mtn2 + ToChar(sayı);
    }
    mtn2 = ToChar(ılk) + mtn2;
    return mtn2;
}