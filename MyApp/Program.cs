// See https://aka.ms/new-console-template for more information

public class Program {

    static public void Main(String[] args) {}

    public bool IsLeapYear(int year) {

        if(year < 1582) {
            throw new InvalidYearException("Year must be 1582 or later");
        }

        bool isLeapYear = false;

        if(year%4 == 0) {
            isLeapYear = true;
        }
        if(year%100 == 0) {
            isLeapYear = false;
        }
        if(year%400 == 0) {
            isLeapYear = true;
        }

        return isLeapYear;
    }

    public string IsLeapYearInput(string yearString) {

        try {
            int year = int.Parse(yearString);

            if(IsLeapYear(year) == true) {
                return "yay";
            }
            else {
                return "nay";
            }
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw new InvalidYearException("Input is not a valid year!");
        }
        
    }

    public void IsLeapYearPrompt() {
        string result = IsLeapYearInput(Console.ReadLine() + "");
        Console.WriteLine(result);
    }
}
