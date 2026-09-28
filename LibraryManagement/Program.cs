using System;
namespace LibraryManagementSystem;
public class Program{
    public static void Main(String[] args){
        Operations operation = new Operations();
        operation.DefaultData();
        operation.MainMenu();
    }
}