using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        const string Menu = "Introdueix el dia, mes i any";
        const string Error = "El format no és correcte";
        const string DataValida = "La data és correcta";
        int dia, mes, any;
        bool validat;
        Console.WriteLine(Menu);
        dia = Convert.ToInt32(Console.ReadLine());
        mes = Convert.ToInt32(Console.ReadLine());
        any = Convert.ToInt32(Console.ReadLine());
        validat = valida(dia, mes, any);
        if (!validat) Console.WriteLine(Error);
        else Console.WriteLine(DataValida);

        Console.ReadLine();
        Console.Clear();

        const string MenuActions = "Introdueix una acció: \nA.Saltar \nB.Córrer \nC.Ajupir-se \nD.Amagar-se";
        string Accio, AccioUpp;
        Console.WriteLine(MenuActions);
        do
        {
            Accio = Console.ReadLine() ?? "";
            AccioUpp = Accio.ToUpper();
        } while (AccioUpp != "A" && AccioUpp != "B" && AccioUpp != "C" && AccioUpp != "D");
        Action(AccioUpp);
    }

    public static bool valida(int day, int month, int year)
    {
        int totalDaysMonth = 0;

        if ((day < 1 || day > 31) || (month < 1 || month > 12) || (year < 1900 || year > 2024)) return false;

        switch (month)
        {
            case 1:
                totalDaysMonth = 31;
                break;
            case 2:
                totalDaysMonth = ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))) ? 29 : 28;
                break;
            case 3:
                totalDaysMonth = 31;
                break;
            case 4:
                totalDaysMonth = 30;
                break;
            case 5:
                totalDaysMonth = 31;
                break;
            case 6:
                totalDaysMonth = 30;
                break;
            case 7:
                totalDaysMonth = 31;
                break;
            case 8:
                totalDaysMonth = 31;
                break;
            case 9:
                totalDaysMonth = 30;
                break;
            case 10:
                totalDaysMonth = 31;
                break;
            case 11:
                totalDaysMonth = 30;
                break;
            case 12:
                totalDaysMonth = 31;
                break;
            default:
                return false;
        }

        if (day > totalDaysMonth) return false;
        else return true;
    }

    public static void Action(string Accio) 
    { 
        switch (Accio)
        {
            case "A":
                Console.WriteLine("Has saltat");
                break;
            case "B":
                Console.WriteLine("Has corregut");
                break;
            case "C":
                Console.WriteLine("T'has ajupit");
                break;
            case "D":
                Console.WriteLine("T'has amagat");
                break;
        }
    }
}