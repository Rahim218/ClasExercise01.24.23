using System;

namespace ClasExercise01._24._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsName("Sa1lam"));
            //string[] Fulname = { " Rehim Veliyev", "Nuru Huseynov" };
            //var result = IsOnlyName(Fulname);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}
            //Console.WriteLine(NewString("sAlam"));
            //string name  = Console.ReadLine();
            //do
            //{
            //    Console.WriteLine("Adinizi daxil edin");
            //    name = Console.ReadLine();
            //} while (IsName(name) == false);
            //do
            //{
            //    Console.WriteLine("Emailinizi daxil edin");
            //    name = Console.ReadLine();
            //} while (name.Contains('@')==false);

            //Console.WriteLine(Domein("rahimav@code.edu.az"));

            //Console.WriteLine(IsDigit("Salam"));
            //Console.WriteLine(IsFullName("Rahim valiyev  sadadad"));
            //int[] number = { 2, 3, 5, 6, 9, 6 };
            //var result =UniqeArr(number);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}

            //string[] gmail = { "rahimav@code.edu.az", "rahimvaliyev@gmail.com", "fir@code.edu.az", "drop@mail.ru" };
            //var result = GmailArr(gmail);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}
            //Console.WriteLine(CountSentence("asdasd.asdsad.sdasd.asdsad.asdasdas...sd"));


        }
        // Verilmis yazinin ad formasinda olub olmamasini yoxlayan metod
        static bool IsName(string name)
        {
            if (!char.IsUpper(name[0]))
            {
                return false;
            }
            for (int i = 1; i < name.Length; i++)
            {
                if (!char.IsLower(name[i]))
                {
                    return false;
                }

            }
            return true;


        }
       
        // Verilmis ad soyad listinde yalniz ad hisseni veren metod
        static string[] IsOnlyName(string[] name)
        {
            string[] names = new string[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = name[i].Trim();
                names[i] = name[i].Substring(0, name[i].IndexOf(' '));

            }
            return names;
        }
        
        //Verilmis yazi boyuk herfle basliyib daha sonra kicik herfle davam eden metod
        static string NewString(string word)
        {
         
            return char.ToUpper(word[0])+word.Substring(1).ToLower();
        }

        // Verilmis gmailin doemin hisseini geri veren metod
        static string Domein(string gmail)
        {

            return gmail.Substring(gmail.IndexOf('@') + 1);
        }
       
        // verilmis yazida eyni olan index deyerlerden yalnizca birini yazan metod
        static string[] MakeUniqe(string[] arr)
        {
            string[] newArr = new string[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(newArr, arr[i]) == -1)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = arr[i];
                }

            }
            return newArr;
        }

        // Verilmiş yazıda rəqəm olub olmadığını tapan metod
        static bool IsDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            return false;
        }

        //Verilmiş yazının fullname olub olmadığını tapan metod
        static bool IsFullName(string str)
        {
            var words = str.Split(' ');
            var result = new string[0];
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = words[i];
                }

            }

            if (result.Length == 2)
            {

                if (IsName(result[0]) && IsName(result[1]))
                {
                    return true;
                }
            }

            return false;

        }

        //Verilmiş ədədlər siyahısından yeni bir array düzəldib qaytaran metod.
        static int[] UniqeArr(int[] arr)
        {
            int[] newArr = new int[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(newArr, arr[i]) == -1)
                {

                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = arr[i];
                }
            }
            return newArr;
        }

        //Verilmiş email-lər siyahısından domainlər siyahısı düzəldən metod
        static string[] GmailArr(string[] arr)
        {
            string[] newArr = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                var result = arr[i].Substring(arr[i].IndexOf('@') + 1);
                newArr[i] = result;
            }
            return MakeUniqe(newArr);

        }

        // Verilmis yazinin icinde cumlelerin sayini tapan metod
        static int CountSentence(string str)
        {
            
            var words = str.Split('.');
            var result = new string[0];
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = words[i];
                }

            }

            return result.Length;
        }






    }
}
