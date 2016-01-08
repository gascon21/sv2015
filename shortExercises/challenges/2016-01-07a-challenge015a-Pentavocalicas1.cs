//Indra Lopez Galvez

using System;

public class pentalizavocacion {
    
    public static bool IsPenta(string word) {
        bool answer = false;
        string realWord = word.ToUpper();
        if(realWord.Contains("A") && realWord.Contains("E") 
                && realWord.Contains("I") && realWord.Contains("O")
                && realWord.Contains("U")){
            answer = true;
        }
        return answer;
    }
    
    public static void Main () {
        long reps = Convert.ToInt64(Console.ReadLine());
        for(long i= 1; i <= reps; i++){
            if(IsPenta( Console.ReadLine() )){
                Console.WriteLine("SI");
            }
            else {
                Console.WriteLine("NO");
            }
        }
    }
}

