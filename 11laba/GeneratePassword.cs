using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11laba
{
    public class GeneratePassword
    {
        int Lenght;
        string[] Alf = "q w e r t y u i o p a s d f g h j k l z x c v b n m Q W E R T Y U I O P A S D F G H J K L Z X C V B N M / ? , . { } 1 2 3 4 5 6 7 8 9 0 - =".Split();
        public GeneratePassword(int length)
        {
            Lenght = length;
        }
        public string Generate()
        {
            string password = "";
            for (int i = 0; i < Lenght; i++)
            {
                password += Alf[new Random().Next(0, Alf.Length)];
            }
            return password;
        }

    }
}
