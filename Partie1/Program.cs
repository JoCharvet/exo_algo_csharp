// EXO 1



using System.ComponentModel;

//int nb1, nb2 ,result;
//string[] str1= new string[1];
//Console.WriteLine("Veuillez saisir deux nombres séparé par un espace");
//str1 = Console.ReadLine().Split(" ");
//if(int.TryParse(  str1[0],out nb1) && int.TryParse(str1[1],out nb2))
//{
//    result = (nb1 + nb2 )/ 2;
//    Console.WriteLine("La moyenne de vos deux nombres est : "+result);
//}
//else
//{
//    Console.WriteLine("Vous ne savez pas taper deux nombres séparés par un espace, je ne peux rien pour vous, veuillez quitter ce programme, encore faut-il que vous soyez capable de cliquer sur la petite croix en haut à droite ou de presser une touche....");
//}


// EXO 2

int nb1, nb2;
string[] str1 = new string[1];
Console.WriteLine("Veuillez saisir deux nombres séparé par un espace");
str1 = Console.ReadLine().Split(" ");
if (int.TryParse(str1[0], out nb1) && int.TryParse(str1[1], out nb2))
{
    nb1 = nb1 + nb2;
    nb2 = nb1 - nb2;
    nb1 = nb1 - nb2;

    Console.WriteLine("nb1 = " + nb1);
    Console.WriteLine("nb2 = " + nb2);
}
else
{
    Console.WriteLine("Vous ne savez pas taper deux nombres séparés par un espace, je ne peux rien pour vous, veuillez quitter ce programme, encore faut-il que vous soyez capable de cliquer sur la petite croix en haut à droite ou de presser une touche....");
}



