using System;

class ReversingString {
    public static void Run() {
        string str = "I am Anirban";
        reverseString(str);
    }
    
    static void reverseString(string str){
        string result = string.Empty;
        for(int i = str.Length-1; i>= 0; i--){
            result += str[i];
        }
        
        Console.WriteLine(result);
    }
}