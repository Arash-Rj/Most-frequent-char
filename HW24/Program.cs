Console.Write("Please enter a sentence: ");
string A = Console.ReadLine();
A = A.Replace(" ", "");
string[] AA = new string[A.Length];
int B =0;
string C = "";
string D = "";
int max = 0; 
for(int i = 0; i<2; )
{
    C = A[i].ToString();
    B = A.Length - A.Replace(C,"").Length;
    A = A.Replace(C,"");
    if (B > max)
    {
        max = B;
        D = C;
    }
    else if(B==max)
    {
        D += "," + C;
    }
    if(A.Length==0)
    {
        break;
    }
   
    
}
Console.Write($"The most repeated character is {D} and the occurance is {max}");