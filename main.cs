using System;
/*
1- Criar um programa que leia dois números inteiros, 
e que solicite ao usuário qual a operação deseja realizar entre esses números. 
Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
caso seja digitado o caractere “/” será realizada uma divisão, 
caso seja digitado o caractere “+” será realizado uma adição, 
e caso seja digitado o caractere “–” será realizada uma subtração.
*/

class MainClass {

  public static double calc(double num1, double num2, string op){
    double resul=0;
    switch (op){
      case "+":
        resul=num1+num2;
        break;
      case "-":
        resul=num1-num2;
        break;
      case "*":
        resul=num1*num2;
        break;
      case "/":
        resul=num1/num2;
        break;
    }
    return resul;
  }
  public static void Main () {
    double a,b;
    string opera;

    Console.Write("Insira um numero p/ operação: ");
    a=double.Parse(Console.ReadLine());
    Console.Write("Insira o 2o numero p/ operação: ");
    b=double.Parse(Console.ReadLine());
    Console.WriteLine("* >> multiplicação");
    Console.WriteLine("/ >> divisao");
    Console.WriteLine("+ >> soma");
    Console.WriteLine("- >> subtracao");
    Console.Write("Qual operação gostaria de fazer ? >> ");
    opera = Console.ReadLine();
    Console.Write(calc(a,b,opera));
  }
}