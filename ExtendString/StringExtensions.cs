using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace ExtendString
{
    public static class StringExtensions
    {

        private static Random RND; //var de class

        static StringExtensions() //construtores de class
        {
            RND = new Random(); //    //        //

        }

        public static string ToRandomCase(this string s) // metodo da classe
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                sb.Append(RND.NextDouble<0.5?char.ToLower(c):char.ToUpper(c));                    
            } 
            return sb.ToString();


        }
        
    }
}