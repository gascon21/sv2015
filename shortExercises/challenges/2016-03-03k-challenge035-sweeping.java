// Chen Chao, Sacha, Miguel Moya

/*
Ejemplo de entrada
4
3 2
---
---
4 2
---*
---*
3 2
*--
--*
4 3
*---
-*--
----

Ejemplo de salida
INVALIDA
INVALIDA
VALIDA
INVALIDA
*/

import java.util.Scanner;

public class Reto35 {

    public static void main(String[] args) {
        Scanner r = new Scanner(System.in);
        int casos, row, col;
        
        casos = r.nextInt();
        for (int i = 0; i < casos; i++) {
            col = r.nextInt();
            row = r.nextInt();
            String[] text = new String[row];
            boolean found = false;
            boolean invalid = false;
            
            for (int j = 0; j < row; j++) {
                text[j] = r.next();
            }
            for (int j = 0; j < row; j++) {
                for (int k = 0; k < col; k++) {
                    if (text[j].contains("*")) {
                        found = true;
                    }
                    if (text[j].charAt(k) == '*' && j == 0 && k == 0) {
                        if (text[j].charAt(k+1) == '*' || text[j + 1].charAt(k) == '*' 
                                || text[j+1].charAt(k+1) == '*')
                            invalid = true;
                    }
                    if (text[j].charAt(k) == '*' && j == 0 && k == col-1) {
                        if (text[j].charAt(k-1) == '*' || text[j + 1].charAt(k) == '*' 
                                || text[j+1].charAt(k-1) == '*')
                            invalid = true;
                    }
                    if (text[j].charAt(k) == '*' && j == row-1 && k == col-1) {
                        if (text[j].charAt(k-1) == '*' || text[j - 1].charAt(k) == '*' 
                                || text[j-1].charAt(k-1) == '*')
                            invalid = true;
                    }
                    if (text[j].charAt(k) == '*' && j == row-1 && k == 0) {
                        if (text[j].charAt(k+1) == '*' || text[j - 1].charAt(k) == '*' 
                                || text[j-1].charAt(k+1) == '*')
                            invalid = true;
                    }
                    if (text[j].charAt(k) == '*' && j > 0 && j < row-1 && k == 0) {
                        if (text[j].charAt(k+1) == '*' || text[j - 1].charAt(k) == '*' 
                                || text[j-1].charAt(k+1) == '*' || text[j+1].charAt(k) == '*'
                                || text[j+1].charAt(k+1) == '*')
                            invalid = true;
                    }
                    if (text[j].charAt(k) == '*' && j > 0 && j < row-1 && k == col-1) {
                        if (text[j].charAt(k-1) == '*' || text[j - 1].charAt(k) == '*' 
                                || text[j-1].charAt(k-1) == '*' || text[j+1].charAt(k) == '*'
                                || text[j+1].charAt(k-1) == '*')
                            invalid = true;
                    }
                    if (text[j].charAt(k) == '*' && j == 0 && k > 0 && k < col - 1) {
                        if (text[j].charAt(k-1) == '*' || text[j].charAt(k+1) == '*' 
                                || text[j+1].charAt(k-1) == '*' || text[j+1].charAt(k) == '*'
                                || text[j+1].charAt(k+1) == '*')
                            invalid = true;
                    }
                    if (text[j].charAt(k) == '*' && j == row-1 && k > 0 && k < col - 1) {
                        if (text[j].charAt(k-1) == '*' || text[j].charAt(k+1) == '*' 
                                || text[j-1].charAt(k-1) == '*' || text[j-1].charAt(k) == '*'
                                || text[j-1].charAt(k+1) == '*')
                            invalid = true;
                    }
                    if (text[j].charAt(k) == '*' && j > 0 && j < row-1 && k > 0 && k < col - 1) {
                        if (text[j].charAt(k-1) == '*' || text[j].charAt(k+1) == '*' 
                                || text[j-1].charAt(k-1) == '*' || text[j-1].charAt(k) == '*'
                                || text[j-1].charAt(k+1) == '*' || text[j+1].charAt(k) == '*'
                                || text[j+1].charAt(k-1) == '*' || text[j+1].charAt(k+1) == '*')
                            invalid = true;
                    }
                }
            }
            if (!found)
                System.out.println("INVALIDA");
            else if (invalid)
                System.out.println("INVALIDA");
            else
                System.out.println("VALIDA");
        }
    }
    
}
