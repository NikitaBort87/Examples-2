// Вид 1 группа методов ничего не принимает и не возвращает
void Method1()
{
    System.Console.WriteLine( "автор");
}
Method1(); //Вызываются подобного рода методы 

// Вид 2 группа принимают но не возвращают
void Method2(string msg)
{
    System.Console.WriteLine(msg);
 }
 Method2(msg: "Текст сообщения ");

void Method21(string msg, int count) // если хотим увидеть определенное количество раз
{
    int i = 0;
    while (i < count)
    {
        i ++;
    }
}
Method21(msg:"Текст", count:4);

// вид 3 что то возвращают но ничего не принимают


int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);



//Вид 4 принимают и возвращают
string Method4(int count, string text)
{
    
    string result = string.Empty;
    for( int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result; 
    
    
    // while (i < count)
    // {
    //     result = result + text;
    //     i++;
    // }
    // return result;
}
string res = Method4(10, "z");
// Console.WriteLine(res);

for( int i = 2; i <= 10 ; i++)
{
    for(int j = 0; j <=10; j++)
    {
        Console.WriteLine($"{i} * {j} ={i*j} ");
    }
    Console.WriteLine();
}

