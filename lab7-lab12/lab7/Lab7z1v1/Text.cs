using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7z1v1
{
    class Text
    {
        public string contens;
        public string text_theme;
        public string letter1;
        public string letter2;
        public string z;

        Text()
        {
            this.contens = "";
            this.text_theme = "";
            this.letter1 = "";
            this.letter2 = "";
            this.z = "";
        }

        public Text(string contens, string text_theme, string letter1, string letter2, string z)
        {
            this.contens = contens;
            this.text_theme = text_theme;
            this.letter1 = letter1;
            this.letter2 = letter2;
            this.z = z;
        }

        public Text(Text text)
        {
            this.contens = text.contens;
            this.text_theme = text.text_theme;
            this.letter1 = text.letter1;
            this.letter2 = text.letter2;
            this.z = text.z;
        }

        public string number_of_characters()
        {
            return $"Кiлькiсть символiв у текстi = {contens.Length}";
        }

        public string number_of_words()
        {
            string[] words = contens.Split();
            return $"Кiлькiсть слiв у текстi = {words.Length}";
        }

        public string letter_replacement()
        {
            string a = contens.Replace(this.letter1, this.letter2);
            return a;
        }

        public string delete_words() 
        {
            string k = contens.Replace(this.z, "");
            return k;
        }

        public string str() 
        {
            return $"Contens: {this.contens}; Text_theme: {this.text_theme}";   
        }
    }
}
