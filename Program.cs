﻿class Example{

    public  static void showArray<T>(T[] arr) {// T is placeholder ,which can hold all types of datatype...

        for   (int i=0;i<arr.Length;i++){
            Console.WriteLine(arr[i]);
        }

    }
}

//generics   replace these placeholders with some type at compile time...


class Program{

    static void Main(string[] args){

        int[] Numbers =new int[4];
        Numbers[0]=11;
         Numbers[1]=31;
        Numbers[2]=21;
   
      

        string[] Names=new string[4];
        Names[0]="sagar";
        Names[1]="sagarika";
        Names[2]="sagarmatha";
        Names[3]="samundra";

        Example.showArray(Numbers);
         Example.showArray(Names);


    }
}