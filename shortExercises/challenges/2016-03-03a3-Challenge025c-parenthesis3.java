// Chen Chao, Sacha, Miguel Moya

package reto25;

import java.util.Scanner;
import java.util.Stack;

public class Reto25 {

    public static void main(String[] args) {
        int casos;
        Scanner r = new Scanner(System.in);
        String text;
        
        casos = r.nextInt();
        for (int i = 0; i < casos; i++) {
            int cantidad = 0;
            text = r.next();
            Stack p = new Stack();
            
            for (int j = 0; j < text.length(); j++) {
                if (text.charAt(j) == '(')
                    p.push('(');
                else {
                    if (p.size() > 0 && text.charAt(j) == ')') {
                        p.pop();
                        cantidad += 2;
                    }
                }
            }
            System.out.println(cantidad);
        }
    }
    
}
