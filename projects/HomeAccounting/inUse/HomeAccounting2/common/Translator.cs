/// <summary>
///  Home accounting: Class Translator (get texts translated to other languages)
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.18  15-Abr-2016  Monica Esteve, Jose Vicente: More help on available languages
   0.16  19-Feb-2016  Vicente Cuenca, Jose Muñoz y David Gascón: 
                      Basic texts are translated to Spanish, English and Catalan
   0.13  12-Feb-2016  Monica Esteve, Carla Liarte y Miguel Moya: 
                      Basic texts are translated to Spanish and English
   0.12  12-Feb-2016  Nacho: Almost empty skeleton, returns the same sentence

 ---------------------------------------------------- */

namespace HomeAccounting2
{
    class Translator
    {
        public static string GetTranslation(string language, string sentence)
        {
            language = language.ToUpper();
            sentence = sentence.ToLower();

            switch (language)
            {
                case "ES":
                    switch (sentence)
                    {
                        case "addtr":
                            return "Añadir gasto o ingreso";
                        case "viewtr":
                            return "Ver las últimas transacciones";
                        case "monthtr":
                            return "Transacciones mensuales";
                        case "accountstr":
                            return "Totales de la cuenta";
                        case "searchtr":
                            return "Buscar";
                        case "exits":
                            return "Salir";
                        case "chosse":
                            return "Elija una opción: ";
                        case "askamount":
                            return "Introduzca la cantidad (C para cancelar): ";
                        case "askdesctr":
                            return "Introduzca la descripción: ";
                        case "askday":
                            return "Introduzca el día: ";
                        case "askmonth":
                            return "Introduzca el mes: ";
                        case "askyear":
                            return "Introduzca el año: ";
                        case "askaccount":
                            return "Introduzca la cuenta: ";
                        case "askcategory":
                            return "Introduzca la categoría: ";
                        case "invalidoption":
                            return "Opción no valida";
                        case "unknow":
                            return "Opción desconocida";
                        case "keypress":
                            return "Presiona una tecla para volver";
                        case "lchange":
                            return "Cambiar idioma";
                        case "langchoose":
                            return "Elige idioma (Español[ES], Ingles[EN], Catalan[CA])";
                        default:
                            return sentence;
                    }

                case "EN":
                    // TO DO!
                    switch (sentence)
                    {
                        case "addtr":
                            return "Add expense or income";
                        case "viewtr":
                            return "View last Transactions";
                        case "monthtr":
                            return "Monthly Transactions";
                        case "accountstr":
                            return "Account totals";
                        case "searchtr":
                            return "Search";
                        case "exits":
                            return "Exit";
                        case "chosse":
                            return "Choose an option:";
                        case "askamount":
                            return "Enter the amount (C to cancel) ";
                        case "askdesctr":
                            return "Enter the description:";
                        case "askday":
                            return "Enter the day:";
                        case "askmonth":
                            return "Enter the month";
                        case "askyear":
                            return "Enter the year";
                        case "askaccount":
                            return "Enter account";
                        case "askcategory":
                            return "Enter category";
                        case "invalidoption":
                            return "Invalid option";
                        case "unknow":
                            return "Unknown option";
                        case "keypress":
                            return "Press a key to return";
                        case "lchange":
                            return "Change language";
                        case "langchoose":
                            return "Choose language (Spanish[ES], English[EN], Catala[CA])";
                        default:
                            return sentence;
                    }

                case "CA":
                    switch (sentence)
                    {
                        case "addtr":
                            return "Afegir una transacció";
                        case "viewtr":
                            return "Vore les últimes transaccions";
                        case "monthtr":
                            return "Transaccions mensuals";
                        case "accountstr":
                            return "Total dels comptes";
                        case "searchtr":
                            return "Buscar";
                        case "exits":
                            return "Sortir";
                        case "chosse":
                            return "Elegir una opció: ";
                        case "askamount":
                            return "Introdueix la quantitat (C per cancel·lar): ";
                        case "askdesctr":
                            return "Introdueix la descripció: ";
                        case "askday":
                            return "Introdueix el dia: ";
                        case "askmonth":
                            return "Introdueix el mes: ";
                        case "askyear":
                            return "Introdueix l'any: ";
                        case "askaccount":
                            return "Introdueix el compte: ";
                        case "askcategory":
                            return "Introdueix la categoria: ";
                        case "invalidoption":
                            return "Opció no valida";
                        case "unknow":
                            return "Opció desconeguda";
                        case "keypress":
                            return "Pressiona una tecla per a tornar";
                        case "lchange":
                            return "Cambiar idioma ";
                        case "langchoose":
                            return "Tria idioma (Español[ES], Anglés[EN], Català[CA])";
                        default:
                            return sentence;
                    }

                default:
                    return sentence;
            }
        }
    }
}