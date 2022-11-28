//int a=21;
//string result="Vous êtes";
//switch (a)
//{
//	case < 0:
//        result.Insert(4, "n'");
//        result = result + " pas née";
//        break;
//    case < 18:
//        result = result + " mineur";
//        break;
//    case <=38:
//        result = result + " majeur";
//        break;

//    case > 38:
//        result = result + " vieux";
//        break;

//    default:
//		break;
//}
//Console.WriteLine(result);

int input;
Console.WriteLine(GetUserInput());


static int GetUserInput()
{
    Console.WriteLine("Veuillez entrer un nombre");
    return (int.TryParse(Console.ReadLine(), out int result) ? result : GetUserInput());
 
}

