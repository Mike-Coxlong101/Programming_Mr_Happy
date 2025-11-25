/*
18.11.2025

Übungsblatt 6 Felder und Matrien

*/



#include <stdio.h>

 void main(){

   int k,m,a;
   double x[40], y[20], w;

   //Initailisierungs Arrays
   for(a=0; a<40; a++){

      x[a] = a; 
      y[a/2] = a; //mehrfachbeschreibung der geraden stellen 0 0 1 1 2 2 3 3 ... 19 19 20
   }

   for(k = 19; k >=0; k--){

      for(w=0.0,m=0;m < 40; m++) // Führt das 40 mal den Code unten aus??
         w = w + x[m] * x[m] * (m % (k+1)); //sinnlos da keine Werte für Variablen
      y[k] = w + y[k];

   }


      a = 0;
    
      while(a < 40){

        x[a] = a;
        y[a/2] = a;
        a++;
      }

      k = 19;

      while(k >= 0){

         m = 0;
         w = 0.0;
         while(m < 40) w = w + x[m] *x[m] *(m % (k + 1)), m++;
         y[k] = w + y[k];
         k--;

      }


      //b

      int i,j,k; float z[121],zs[11];

      i=0;
      while (i<=10)
         {
             j=0;
             while (j<=10)
             {
                 if (i==j)
                   z[i*11+j]=1.0;
                 else
                   z[i*11+j]=i+j;
                 j=j+1;
               }
               k=0; zs[i]=0.0;
               while (k<=10)
                 {
                     zs[i]=zs[i]+z[i*11+k];
                     k=k+1;
                  }
                  i=i+1;
          }
     
       for(i = 0; i <= 10; i++)
        {
          for(j = 0; j <= 10; j++)
           {
             if(i==j)z[i*11+j]=1.0;
             else z[i*11+j] = i + j;
            }

           zs[i] = 0.0;
           for(k = 0; k <= 10; k++)
            {
              zs[i] = zs[i]+z[i*11+k];
              k = k+1;
            }
         }

 }

