// Chen Chao y Pablo Padilla Martínez
// 18-01-2016

using System;

public class Challenge019
{
    struct Paciente
    {
        public uint peso;
        public uint altura;
    }
    
    public static void Main()
    {
        ushort numPacientes = Convert.ToUInt16(Console.ReadLine());
        Paciente[] paciente = new Paciente[numPacientes];
        
        for (ushort i = 0; i < numPacientes; i++)
        {
            string texto = Console.ReadLine();
            string[] texto2 = texto.Split(' ');
            paciente[i].peso = Convert.ToUInt32(texto2[0]);
            paciente[i].altura = Convert.ToUInt32(texto2[1]);
        }
        
        for (ushort i = 0; i < numPacientes - 1; i++)
            for (ushort j = (ushort)(i + 1); j < numPacientes; j++)
                if ((paciente[i].peso < paciente[j].peso) || 
                        (paciente[i].peso == paciente[j].peso && 
                        paciente[i].altura > paciente[j].altura))
                {
                    uint tempPeso = paciente[i].peso;
                    paciente[i].peso = paciente[j].peso;
                    paciente[j].peso = tempPeso;
                    uint tempAltura = paciente[i].altura;
                    paciente[i].altura = paciente[j].altura;
                    paciente[j].altura = tempAltura;
                }
            
        for (ushort i = 0; i < numPacientes; i++)
            Console.WriteLine(paciente[i].peso + " " + paciente[i].altura);
    }
}
