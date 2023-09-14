int number = 416532122;
string numberInString = number.ToString();

int zero = 0;
int jeden = 0;
int dwa = 0;
int trzy = 0;
int cztery = 0;
int piec = 0;
int szesc = 0;
int siedem = 0;
int osiem = 0;
int dziewiec = 0;

foreach (char c in numberInString)
{
    if (c == '0')
    {
        zero++;
    }
    if (c == '1')
    {
        jeden++;
    }
    if (c == '2')
    {
        dwa++;
    }
    if (c == '3')
    {
        trzy++;
    }
    if (c == '4')
    {
        cztery++;
    }
    if (c == '5')
    {
        piec++;
    }
    if (c == '6')
    {
        szesc++;
    }
    if (c == '7')
    {
        siedem++;
    }
    if (c == '8')
    {
        osiem++;
    }
    if (c == '9')
    {
        dziewiec++;
    }
}
