// See https://aka.ms/new-console-template for more information

public class Program {

    static public void Main(String[] args) {}

    public bool IsLeapYear(int year) {

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
}
