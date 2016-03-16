// Matriz identidad
// Ruben Blanco

import java.util.Scanner;

public class PruebaRetos {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int size = 0;
        do{
            size = sc.nextInt();
            sc.nextLine();
            int [][] table = new int [size][size];
            boolean isValid = true;
            
            for(int i = 0 ; i < size ; i ++){
                for(int j = 0 ; j < size ; j ++){
                    table[i][j] = sc.nextInt();
                }
                sc.nextLine();
            }
    
            for(int i = 0 ; i < size ; i ++){
                for (int j = 0 ; j < size ; j ++){
                    if((i == j)&&(table[i][i] != 1))
                        isValid = false;
                    else if((i != j)&&(table[i][j] != 0))
                        isValid = false;
                }
            }
                        
            if(size != 0)
            {
                if(isValid)
                    System.out.println("SI");
                if (!isValid)
                    System.out.println("NO");
            }
            
            isValid = true;
                        
        }while(size != 0);
    }
}
