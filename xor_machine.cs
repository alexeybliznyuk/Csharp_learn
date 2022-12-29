Console.WriteLine("Hi, its simple XOR programm");
//Console.WriteLine("Type what u want to do(1 - crypt, 2 - encrypto)");




Console.WriteLine("Type ur crypto");
int crypto = Convert.ToInt32(Console.ReadLine());




Console.WriteLine("Type ur crypto key");
int key = Convert.ToInt32(Console.ReadLine());


int? result = crypto ^ key;
Console.WriteLine(result);

//string move = Console.ReadLine();
//if (move == "1") ;
