class Banner
{
    public string UpLnChar      { get; set; }
    public string DnLnChar      { get; set; }
    public string Message       { get; set; }
    public int    LnLength      { get; set; }

    public Banner(string upChar, string dnChar, string message, int lnLength)
    {
        UpLnChar  = upChar;
        DnLnChar  = dnChar;
        Message   = message;
        LnLength  = lnLength;
    }

    public void WriteLog()
    {

        int messLenght = Message.Length;
        string stars = "****";
        int spaces = (LnLength - messLenght - (stars.Length * 2)) / 2;


        string innerSpaces = "";

        for ( int i = 1; i <= spaces; i++ )
        {
            innerSpaces = innerSpaces + " ";
        }

        string leftSpaces = stars + innerSpaces;
        string rightSpaces = innerSpaces + stars;
        string messBanner = leftSpaces + Message + rightSpaces;


        Utilities.WriteLine(UpLnChar, messBanner.Length);
        Utilities.WriteLogBook(messBanner);
        Utilities.WriteLine(DnLnChar, messBanner.Length);

    }
}