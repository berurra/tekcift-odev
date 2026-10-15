namespace TekCiftOOP
{
    internal class Sayi
    {
        private int sayi;

        public void SetSayi(int yeniSayi)
        {
            sayi = yeniSayi;
        }

        public int GetSayi()
        {
            return sayi;
        }

        public bool CiftMi()
        {
            return sayi % 2 == 0;
        }
    }
}
