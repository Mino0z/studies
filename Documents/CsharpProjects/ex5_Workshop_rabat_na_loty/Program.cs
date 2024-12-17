using System;
using System.Globalization;
class Program
{

    public static int GetExactAge(DateTime birthDate, DateTime targetDate)
    {
        int age = targetDate.Year - birthDate.Year;

        switch (targetDate.Month.CompareTo(birthDate.Month))
        {
            case -1: 
                age--;
                break;

            case 0: 
                switch (targetDate.Day.CompareTo(birthDate.Day))
                {
                    case -1: 
                        age--;
                        break;

                    default:
                        break; 
                }
                break;

            default:
                break; 
        }

        return age;
    }   
    public static DateTime PromptBornDate(string format, CultureInfo provider, DateTime bornDate)
    {
        Console.Write("Podaj swoją datę urodzenia w formacie RRRR-MM-DD:");
        while (true)
        {
            try
            {
                bornDate = DateTime.ParseExact(Console.ReadLine() ?? string.Empty, format, provider);
                
                switch(bornDate > DateTime.Now){
                    case true:
                        Console.WriteLine("Podana data urodzenia jest z przyszłości. Spróbuj jeszcze raz.");
                        Console.Write("Podaj swoją datę urodzenia w formacie RRRR-MM-DD:");
                        continue;
                    case false: 
                        break;
                }
                break;
            } 
            catch (Exception)
            {
                Console.WriteLine("Podana data jest nieprawidłowa. Spróbuj jeszcze raz.");
                Console.Write("Podaj swoją datę urodzenia w formacie RRRR-MM-DD:");
            }
        }
        return bornDate;
    }
    public static DateTime PromptFlightDate(string format, CultureInfo provider, DateTime flightDate)
    {
        Console.Write("Podaj datę lotu w formacie RRRR-MM-DD:");
        while (true){
            try{
                flightDate = DateTime.ParseExact(Console.ReadLine() ?? string.Empty, format, provider);

                switch(flightDate < DateTime.Now){
                    case true:
                        Console.WriteLine("Podana data lotu jest z przeszłości. Spróbuj jeszcze raz.");
                        Console.Write("Podaj datę lotu w formacie RRRR-MM-DD:");
                        continue;
                    case false: 
                        break;
                }
                break;
            }   
            catch (Exception){
                Console.WriteLine("Podana data jest nieprawidłowa. Spróbuj jeszcze raz.");
                Console.Write("Podaj datę lotu w formacie RRRR-MM-DD:");
            }
        }
        return flightDate;
    }
    public static string PromptCountryFlight(string countryFlight)
    {
        while(true){
            Console.Write("Czy lot jest krajowy (T/N)?");
            countryFlight = (Console.ReadLine() ?? string.Empty).Trim().ToUpper();
                switch(countryFlight){
                    case "T":
                        break;

                    case "N":
                        break;
                    default:
                        Console.WriteLine("Podano nieprawidłową wartość. Spróbuj jeszcze raz.");
                
                        continue;
                    }   
                    break;
        }
    return countryFlight;
    }
    public static string PromptRegularCustomer(string regularCustomer)
    {
        while (true){
            Console.Write("Czy jesteś stałym klientem (T/N)?");
            regularCustomer = (Console.ReadLine() ?? string.Empty).Trim().ToUpper();
            switch(regularCustomer){
                case "T":
                    break;
                case "N":
                    break;
                default:
                    Console.WriteLine("Podano nieprawidłową wartość. Spróbuj jeszcze raz.");
                    continue;
            }
            break;
        }
    return regularCustomer;
    }   
    public static string ConvertDayOfWeek(DateTime flightDate){
        string dayOfFlight = flightDate.DayOfWeek.ToString();
        string dayOfFlightName = dayOfFlight.ToString();
            switch (dayOfFlight)
            {
                case "Monday":
                    dayOfFlightName = "poniedziałek";
                    break;
                case "Tuesday":
                    dayOfFlightName = "wtorek";
                    break;
                case "Wednesday":
                    dayOfFlightName = "środa";
                    break;
                case "Thursday":
                    dayOfFlightName = "czwartek";
                    break;
                case "Friday":
                    dayOfFlightName = "piątek";
                    break;
                case "Saturday":
                    dayOfFlightName = "sobota";
                    break;
                case "Sunday":
                    dayOfFlightName = "niedziela";
                    break;
            }
        return dayOfFlightName; 
    }
    public static string ConvertMonth(DateTime flightDate)
    {
        string flightMonth = flightDate.Month.ToString("00");
        switch(flightMonth){
            case "01":
                flightMonth = "styczeń";
                break;
            case "02": 
                flightMonth = "luty";
                break;
            case "03":
                flightMonth = "marzec";
                break;
            case "04":
                flightMonth = "kwiecień";
                break;
            case "05":
                flightMonth = "maj";
                break;
            case "06":
                flightMonth = "czerwiec";
                break;
            case "07":
                flightMonth = "lipiec";
                break;
            case "08":
                flightMonth = "sierpień";
                break;
            case "09":
                flightMonth = "wrzesień";
                break;
            case "10":  
                flightMonth = "październik";
                break;
            case "11":
                flightMonth = "listopad";
                break;
            case "12":
                flightMonth = "grudzień";
                break;

        }
        return flightMonth;
    }
    public static bool IsSeasonFlight(DateTime flightDate){
        bool seasonFlight = false;
        switch (true)
        {
            case var _ when (flightDate.Month == 7 && flightDate.Day >= 1) || (flightDate.Month == 8 && flightDate.Day <= 31):
                seasonFlight = true; 
                break;
            case var _ when (flightDate.Month == 12 && flightDate.Day >= 20) || (flightDate.Month == 1 && flightDate.Day <= 10):
                seasonFlight = true; 
                break;
            case var _ when (flightDate.Month == 3 && flightDate.Day >= 20) || (flightDate.Month == 4 && flightDate.Day <= 10):
                seasonFlight = true; 
                break;
            default:
                seasonFlight = false;
                break;
        }
        return seasonFlight;
    }
    public static string SeasonFlightMessage(bool seasonFlight){
        string message = "";
        switch(seasonFlight){
            case true:
                message = "Lot w sezonie";
                break;
            case false:
                message = "Lot poza sezonem";
                break;
        }
        return message;
    }
    public static (bool, string) SetCountryFlightStatus(string countryFlight){
        bool countryFlightBool = false;
        string countryFlightMessage = "";
        switch (countryFlight){
            case "T":
                countryFlightBool = true;
                countryFlightMessage = "Lot krajowy";
                break;
            case "N":
                countryFlightBool = false;
                countryFlightMessage = "Lot Miedzynarodowy";
                break;
        }
        return (countryFlightBool, countryFlightMessage);
    }
    public static (bool, string, int) SetRegularCustomerStatus(string regularCustomer, DateTime bornDate,  int discount){
        bool regularCustomerBool = false;
        string regularCustomerMessage = "";
        switch (true){
            case var _ when DateTime.Now.AddYears(-18) >= bornDate && regularCustomer == "T":
                regularCustomerBool = true;
                regularCustomerMessage = "Tak";
                discount += 15;
                break;

            default:
                regularCustomerBool = false;
                regularCustomerMessage = "Nie";
                discount += 0;
                break;
        }
        
        return (regularCustomerBool, regularCustomerMessage, discount);
    }
    public static int CalculateDiscountByAgeAndCountryFlight(DateTime bornDate, DateTime flightDate, bool countryFlightBool, int discount){
        int age = GetExactAge(bornDate, flightDate);
        
        switch(age){
            case var _ when age < 2 && countryFlightBool == true:
                discount += 80;
                break;
            case var _  when age < 2 && countryFlightBool == false:
                discount += 70;
                break;
            case var _ when age >= 2 && age < 16 && countryFlightBool == true:
                discount += 10;
                break;
            case var _ when age >= 2 && age < 16 && countryFlightBool == false:
                discount += 10;
                break;
            default:
                break;
        }   
        return discount;
    }   
    public static int CalculateMonthsToFlightDiscount(DateTime flightDate, int discount){
        DateTime today = DateTime.Now;
        int toFlight = (flightDate.Year - today.Year) * 12 + (flightDate.Month - today.Month);
        switch(toFlight){
            case var _ when toFlight >=  5:
                discount += 10;
                break;
            default:
                break;
        }
        return discount;
    }
    public static int CalculateSeasonFlightStatusDiscount(bool seasonFlight, bool countryFlightBool, int discount){
        switch(seasonFlight){
            case var _ when seasonFlight == false && countryFlightBool == false:
                discount += 15;
                break;
            default:
                break;
        }
        return discount;
    }
    public static int ApplyMaxDiscountLimit(int age, int discount){
        switch(discount){
            case var _ when age <= 2 && discount > 80:
                discount = 80;
                
                break;
            case var _ when age > 2 && discount > 30:
                discount = 30;
                break;
            default:
                break;
        }
        return discount;
    }  
    static void Main(string[] args)
    {
        DateTime bornDate = DateTime.Now;
        DateTime flightDate = DateTime.Now;
        string countryFlight = "";
        string regularCustomer = "";
        string format = "yyyy-MM-dd";
        CultureInfo provider = CultureInfo.InvariantCulture;
        
        
        bornDate = PromptBornDate(format, provider, bornDate);
        flightDate = PromptFlightDate(format, provider, flightDate);
        countryFlight = PromptCountryFlight(countryFlight);
        regularCustomer = PromptRegularCustomer(regularCustomer); 
        string dayName = ConvertDayOfWeek(flightDate);
        string monthName = ConvertMonth(flightDate);
        
        int discount = 0;

        string seasonFlightMessage = SeasonFlightMessage(IsSeasonFlight(flightDate));
        string countryFlightMessage = SetCountryFlightStatus(countryFlight).Item2;
        string regularCustomerMessage = SetRegularCustomerStatus(regularCustomer, bornDate,  discount).Item2;
        
        discount = SetRegularCustomerStatus(regularCustomer, bornDate, discount).Item3;
        discount = CalculateDiscountByAgeAndCountryFlight(bornDate, flightDate, SetCountryFlightStatus(countryFlight).Item1,  discount);
        discount = CalculateMonthsToFlightDiscount(flightDate,  discount);
        discount = CalculateSeasonFlightStatusDiscount(IsSeasonFlight(flightDate), SetCountryFlightStatus(countryFlight).Item1 , discount);
    
        discount = ApplyMaxDiscountLimit(GetExactAge(bornDate, flightDate), discount);
        
        
        Console.WriteLine();
        Console.WriteLine("=== Do obliczeń przyjęto:");
        Console.WriteLine($"* Data urodzenia: {bornDate.ToString("dd.MM.yyyy")}");
        Console.WriteLine($"* Data lotu: { dayName }, { flightDate.ToString("dd")} {monthName} {flightDate.ToString("yyyy")}. {seasonFlightMessage}");
        Console.WriteLine($"* {countryFlightMessage}");
        Console.WriteLine($"* Stały klient: {regularCustomerMessage}");
        Console.WriteLine();
        Console.WriteLine($"Przysługuje Ci rabat w wysokości: {discount}%");
        Console.WriteLine($"Data wygenerowania raportu: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");

    }
}