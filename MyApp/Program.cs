// See https://aka.ms/new-console-template for more information

public class Program {

    static public void Main(String[] args) {}

    public bool IsLeapYear(int year) {

        if(year < 1582) {
            throw new InvalidYearException("Year must be 1582 or later");
        }

        if(year%4 != 0) {
            return false;
        }

        if(year%100 == 0) {
            if(year%400 == 0) {
                return true;
            }
            else {
                return false;
            }
        } 
        else {
            return true;
        }
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
