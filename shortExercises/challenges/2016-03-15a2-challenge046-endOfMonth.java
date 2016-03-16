// David Gascón López

import java.util.Scanner;

public class FinDeMes {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int repes = sc.nextInt();
        sc.nextLine();
        
        for(int i = 0 ; i < repes ; i ++){
            int n1 = sc.nextInt();
            int n2 = sc.nextInt();
            sc.nextLine();
            
            int sum = n1 + n2;
            
            if(sum >= 0)
                System.out.println("SI");
            else
                System.out.println("NO");
        }
    }
}
