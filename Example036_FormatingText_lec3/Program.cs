﻿// Дан текст. В тексте все пробелы нужно заменгить черточками.
// Маленькие буквы "к" нужно заменить большими "К", а большие "С"
// заменить маленькими "с".

string text ="-Я думаю,- сказал князь, улыбаясь, - что,"
            +"ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля."           
            +"Вы так красноречивы. Вы дадите мне чаю?";
            string Replace(string text, char oldValue, char newValue)
            {
            string result = String.Empty;
            int length = text.Length;
            for (int i = 0; i < length; i++)
            {
              if(text[i] == oldValue) result = result + $"{newValue}";
              else result = result + $"{text}";
            }
            return result;
            }
            string newText = Replace(text,' ','|' ); 
            Console.WriteLine(newText);

          