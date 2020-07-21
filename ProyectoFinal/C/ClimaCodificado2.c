#include <stdio.h>
#include <unistd.h>
#include <conio.h>
#include <windows.h>
#include <stdlib.h>
#define BSIZE 80
int countlines(char *filename);

int main() 
{
    char encodeInput[]  = "EncodeInput.csv";
    char encodeOutput[]  = "EncodeOutput.csv";
    char decodeInput[]  = "DecodeInput.csv";
    char decodeOutput[]  = "DecodeOutput.csv";
    
    char buffer[BSIZE];
    int caseSwitch = 0;
    FILE *f;
    char *field;
    
    while(caseSwitch !=5)
    {
	    printf("MENU \n");
	    printf("Elija una opcion \n");
	    printf("1-Codificar clima\n");
	    printf("2-Decodificar clima\n");
	    printf("3-Imprimir clima codificado\n");
	    printf("4-Imprimir clima decodificado\n");
	    printf("5-salir\n");
	    
	    scanf("%d",&caseSwitch);
	    
	    switch(caseSwitch)
	    {
	    	case 1:
	            system("cls");
	            f = fopen(encodeInput,"r");
	            if ( f == NULL)	
				{	
					printf("no hay ningun archivo para codificar en la carpeta del programa\n");
	                getch(); 
	                system("cls");
	                break;
				}
				int numberOfLines = countlines(encodeInput);
				
					while(fgets(buffer,BSIZE,f))
					{
						    int num, index, i;

						field=strtok(buffer,"-");//YYYY
						
							int YYYY;
							int INT_SIZE = 12;
							num = atoi(field);
						    int bin[INT_SIZE];
							index = INT_SIZE - 1;
						    while(index >= 0)
						    {
						    	bin[index] = num & 1;index--;num >>= 1;
						    }
						    char YYYYs[INT_SIZE] ;
							int x=0;
							int indexx = 0;
							for (x=0; x<5; x++)
   							indexx += snprintf(&YYYYs[indexx],128-index, "%d", bin[x]);
							YYYY = atoi(YYYYs);

							printf("\n");
						    
						if(YYYY != 0)
						{
						field=strtok(NULL,"-"); int MM=atoi(field);//MM
						field=strtok(NULL,"T"); int dd=atoi(field);//dd
						
						field=strtok(NULL,":"); int HH24=atoi(field);//HH24
						field=strtok(NULL,":"); int mm=atoi(field);//mm
						field=strtok(NULL,"."); int ss=atoi(field);//ss
						field=strtok(NULL,"-"); int fff=atoi(field);//fff
						field=strtok(NULL,":"); int GMTH=atoi(field);//GMTH
						field=strtok(NULL," "); int GMTM=atoi(field);//GMTM

						printf("%d-%d-%dT%d:%d:%d.%d-%d:%d  \n",
								YYYY,
								MM,
								dd,
								HH24,
								mm,
								ss,
								fff,
								GMTH,
								GMTM);
						}
				}
				printf("El Registro ha sido codificado\n");
	            getch();
	            system("cls");
				fclose(f);
				break;
				
            /*case 2:
                system("cls");
                if (FileExists(decodeInput) == 0 )
                {
                    printf("no hay ningun archivo para decodificar en la carpeta del programa\n");
                    getch();  
                    system("cls");
                    break;
                }
                //Record.Decode(decodeInput, decodeOutput);
                printf("El Registro ha sido decodificado\n");
                getch();  
                //Console.Clear();
                break;
            case 3:
             /*   system("cls");
                if (FileExists(encodeOutput)==0)
                {
                    printf("No existe un registro de codificacion para leer\n");
                    getch(); 
                    system("cls");
                    break;
                }
                //Print(encodeOutput);
                getch();  
                system("cls");
                break;
            case 4:
              /*  system("cls");
                if (FileExists(decodeOutput) == 0)
                {
                    printf("No existe un registro de decodificacion para leer\n");
                    getch(); 
                    system("cls");
                    break;
                }
                //Print(decodeOutput);
                getch(); 
                system("cls");
                break;
            case 5:
                caseSwitch = 5;
                break;*/
		}
	}
}

int countlines(char *filename)
{
	FILE *fp; 
	char c;
	int count = 0;
	
	fp = fopen(filename, "r"); 	
	for (c = getc(fp); c != EOF; c = getc(fp)) 
	{
		if (c == '\n') 
        count = count + 1; 
	}
    fclose(fp);
    return count;
}
