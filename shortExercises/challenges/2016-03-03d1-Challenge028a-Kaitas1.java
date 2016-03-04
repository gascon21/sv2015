// Chen Chao, Sacha, Miguel Moya

/*
Salida

Escribir la palabra que contenga con un mayor número de letras 
consecutivas del alfabeto (hasta la letra K incluida), sin repeticiones 
y con independencia de si las letras están en mayúsculas o minúsculas. 
En caso de empate, se imprimirá la primera palabra leída.

Ejemplo de entrada

7
BADOC
ABECES
Modificable
LoLdificable
ABECEDARIO
CAsa
Barbero

Ejemplo de salida

Modificable
*/

package reto28;

import java.util.Scanner;

public class Reto28 {

    public static void main(String[] args) {
        String letras = "ABCDEFGHIJK";
        Scanner r = new Scanner(System.in);
        int n = r.nextInt();
        String[] text = new String[n];
        int[][] textPos = new int[n][2];
        
        for (int i = 0; i < n; i++) {
            text[i] = r.next();
        }
        for (int i = 0; i < n; i++) {
            StringBuilder text2 = new StringBuilder(text[i]);
            textPos[i][0] = i; // Orden lectura
            for (int j = 0; j < text2.length() - 1; j++) {
                for (int k = j + 1; k < text2.length(); k++) {
                    if (text2.charAt(j) > text2.charAt(k)) {
                        char l = text2.charAt(j);
                        text2.setCharAt(j, text2.charAt(k));
                        text2.setCharAt(k, l);
                    }
                }
            }
            boolean repeated = false;
            int count = 0;
            
            for (int j = 0; j < letras.length() && !repeated; j++) {
                for (int k = 0; k < text2.length() - 1; k++) {
                    if (letras.charAt(j) == text2.toString().toUpperCase().charAt(k) && 
                            text2.toString().toUpperCase().charAt(k) == 
                            text2.toString().toUpperCase().charAt(k+1)) {
                        repeated = true;
                    }
                    else if (letras.charAt(j) == text2.toString().toUpperCase().charAt(k)) {
                        count++;
                    }
                        
                }
            }
            textPos[i][1] = count; // Cantidad
        }
        for (int i = 0; i < n - 1; i++) {
            for (int j = i + 1; j < n; j++) {
                if (textPos[i][1] < textPos[j][1]) {
                    int l = textPos[i][1];
                    textPos[i][1] = textPos[j][1];
                    textPos[j][1] = l;
                    int k = textPos[i][0];
                    textPos[i][0] = textPos[j][0];
                    textPos[j][0] = k;
                    String t = text[i];
                    text[i] = text[j];
                    text[j] = t;
                }
                if (textPos[i][1] == textPos[j][1] && textPos[i][0] > textPos[j][0]) {
                    int l = textPos[i][1];
                    textPos[i][1] = textPos[j][1];
                    textPos[j][1] = l;
                    int k = textPos[i][0];
                    textPos[i][0] = textPos[j][0];
                    textPos[j][0] = k;
                    String t = text[i];
                    text[i] = text[j];
                    text[j] = t;
                }
            }
        }
        System.out.println(text[0]);
    }
    
}
