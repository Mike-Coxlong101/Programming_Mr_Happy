/*
24.11.2025

Übung zu Arrays Aufgabe 2

Eingabe in Form xx.xx.xxxx
return von scanf prüfen ob eingabe zulässig
prüfen auf Schaltjahr




*/






#include <stdio.h>


int main(){
              //  jan feb mar ap may jun jul au sep okt nov dez
    int days_month[] = {31,28,31,30,31,30,31,31,30,31,30,31};   
    char month[][10] = {
                         {"Januar"},
                         {"Februar"},
                         {"März"},
                         {"April"},
                         {"Mai"},
                         {"Juni"},
                         {"Juli"},
                         {"August"},
                         {"September"},
                         {"Oktober"},
                         {"November"},
                         {"Dezember"}
                       };//macht kein Sinn


    char weeks[][11] = {
                         {"Montag"},
                         {"Dienstag"},
                         {"Mittwoch"},
                         {"Donnerstag"},
                         {"Freitag"},
                         {"Samastag"},
                         {"Sonntag"}
                        }; // genauso sinnlos wieso zwei dimensionen?


     int Tag;
     int Monat;
     int Jahr;   //"xx:xx:xxxx"
     char date_input1[11] ={ 'x', 'x', ':','x', 'x', ':','x', 'x', 'x', 'x','\0'} ;
     char date_input[5][10]={
                             "xx",
                             ":",
                             "xx",
                             ":",
                             "xxxx"
                          };
     int control;                 

    printf("Datum in numerischer Form xx:xx:xxxx eingeben:\n");
    /*Eingegebener string muss kontrolliert werden und dann
    entsprechend abgelegt werden. und ein int Wert muss es geben
    für Schaltjahrbestimmung*/
    /*
    for(int i = 0; i < 11; i++){

       control = scanf("%1c:", &date_input1[i]);

    }*/
   // control = scanf("%1c:", &date_input[1]);
     short c = 0;
     do{ 
         c = 0;
         control = scanf("%i:%i:%i", &Tag, &Monat, &Jahr);
         if((Tag > 31)||(Monat > 12)|| (control != 3)) c = 1;
         if(c){
                 printf("Falsche eingabe\n"); 
                 static int ch;
                 while((ch = getchar()) !='\n' && ch != EOF); //Leeren des Buffers get char() weißt ch ein char ausm buffer zu EOF ist wegen END OF  FILE
              }
        }while(c == 1);
}  