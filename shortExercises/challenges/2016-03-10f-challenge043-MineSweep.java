import java.util.Scanner;
public class RetoF {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        char[][] matriz;
        
        int x = sc.nextInt();
        int y = sc.nextInt();
        sc.nextLine();

        matriz = new char[x][y];
        int count = 0;
        String linea;
        
        for (int r = 0; r < x; r++){
            linea = sc.nextLine();
            for (int c = 0; c < y; c++)
		matriz[r][c] = linea.charAt(c);
        }
            
        for (int r = 0; r < x; r++){
            for (int c = 0; c < y; c++){
                count = 0;
                if(matriz[r][c] == '.'){
                    if(r-1 >= 0 && c-1 >= 0 && (matriz[r-1][c-1] == '*')){//1
                        count ++;
                    }
                    if((r-1 >= 0) && (matriz[r-1][c] == '*')){//2
                        count ++;
                    }
                    if((r-1 >= 0) && (c+1 < y) && (matriz[r-1][c+1] == '*')){//3
                        count ++;
                    }
                    if((c-1 >= 0) && (matriz[r][c-1] == '*')){//4
                        count ++;
                    }
                    if((c+1 < y) && (matriz[r][c+1] == '*')){//5
                        count ++;
                    }
                    if((r+1 < x) && (c-1 >= 0) && (matriz[r+1][c-1] == '*')){//6
                        count ++;
                    }
                    if((r+1 < x) && (matriz[r+1][c] == '*')){//7
                        count ++;
                    }
                    if((r+1 < x) && (c+1 < y) && (matriz[r+1][c+1] == '*')){//8
                        count ++;
                    }
                    matriz[r][c] = (char) ('0' + (char)count);
                }
            }
        }
        for (int r = 0; r < x; r++){
            for (int c = 0; c < y; c++)
		System.out.print(matriz[r][c]);
            System.out.println();
        }
    }
    
}
