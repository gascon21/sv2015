/// <summary>
///  Home accounting: Class Translator (get texts translated to other languages)
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.12  12-Feb-2016  Nacho: Almost empty skeleton, returns the same sentence
   0.13  12-Feb-2016  Monica Esteve, Carla Liarte y Miguel Moya: 
                      Basic texts are translated to Spanish and English
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
                            return "Introduzca la cantidad: ";
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
                            return "Enter the amount:";
                        case "askdesctr":
                            return "Enter the description:";
                        case "askday":
                            return "Enter the day:";
                        case "askmonth":
                        /*
                            return "Introduzca el mes";
                        case "askyear":
                            return "Introduzca el año";
                        case "askaccount":
                            return "Introduzca la cuenta";
                        case "askcategory":
                            return "Introduzca la categoría";
                        case "invalidoption":
                            return "Opción no valida";
                        case "unknow":
                            return "Opción desconocida";
                        */
                        default:
                            return sentence;
                    }
                default:
                    return sentence;
            }
        }
    }
}
