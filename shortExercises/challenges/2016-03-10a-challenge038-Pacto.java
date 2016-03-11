// Team Esblasa

import java.util.Scanner;

public class AceptaElReto {

    public static void main(String[] args) {
        
        Scanner r = new Scanner(System.in);
        
        int casos = r.nextInt();
        int votos;
        int countAproved = 0;
        int countAllYes = 0;
        int counter = 0;
        
        for (int i = 0; i < casos; i++) {
            
            for (int j = 0; j < 5; j++) {
                votos = r.nextInt();
                if(votos == 1)
                    counter++;
            }
            
            if(counter >2){
                countAproved++;
            }
                
            
            if(counter == 5)
                countAllYes++;
        
            counter = 0;
        }
        System.out.println(countAproved);
        System.out.println(countAllYes);
           
    }
    
}