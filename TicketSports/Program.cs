using System;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using TicketSports;

namespace MyApp
{
    public class Program
    {
        public static void Main()
        {
            var listaNumeros = new int[5] {1, 2, 3, 4, 5 };
            var palavra = "amora";
            var numerosBalanceados = new int[3] { 1, 2, 1};

            var instance = new Program();
            instance.reverseArray(listaNumeros);
            instance.lastLetters(palavra);
            instance.balancedArray(numerosBalanceados);
            instance.getNumberOfMovies("maze");
        }

        //Question 1
        public int[] reverseArray(int[] input)
        {
            var index = input.Length - 1;

            var result = new int[] { };

            for (int i = index; i >= 0; i--)
            {
                result.Append(input[i]);
                Console.WriteLine("Resultado: " + input[i]);
            }

            return result;
        }

        //Question 2
        public string lastLetters(string word)
        {
            var last = word.Length;

            var result = word.Substring(last - 1) + " " + word.Substring(last - 2 , 1);

            Console.WriteLine("Palavra: " + result);

            return result;
        }

        //Question 3
        public int balancedArray(int[] array)
        {
            int sumFirst = 0;

            int sumLast = array[array.Length - 1];

            for (int i =0; i < array.Length; i++)
            {
                if (sumFirst < sumLast)
                    sumFirst += array[i];
                else
                {
                    Console.WriteLine("Index Balanceado: " + i);
                    return i;
                }
            }

            return -1;
        }


        //Question 4
        public async Task<int> getNumberOfMovies(string title)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://jsonmock.hackerrank.com/api/moviesdata/search/?Title={title}");

            var response = client.Send(request);

            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<FindTitles>();

            Console.WriteLine("Titulos localizados: " + result.Total);

            return result.Total;
        }

        //Question 5
        // arr[arr.length] = value

        //Question 6
        // Assign a reference to the foo function to the variable myVar

        //Question 7
        // 'place-content: center' aligns the element to be vertically centered.

        //Question 9
        //SELECT Customer.Id, Customer.Fist_Name, Customer.Last_Name
        //FROM Customer
        //WHERE LEN(Concat(Fist_Name, Last_Name)) < 12
        //ORDER BY LEN(Concat(Fist_Name, Last_Name)), Fist_Name
    }
}