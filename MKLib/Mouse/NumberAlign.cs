public static partial class MKLib
{

public static int NumberAlign(int NumberIn, int NumberTo)
{
if (NumberTo > NumberIn)
{
int NewNumber = NumberIn+1;
return NewNumber;
}
else if (NumberTo < NumberIn)
{
int NewNumber = NumberIn-1;
return NewNumber;
}
else
{
return NumberTo;
}
}

}