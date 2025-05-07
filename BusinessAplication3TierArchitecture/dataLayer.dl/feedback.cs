using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAplication3TierArchitecture.dataLayer.dl
{
    internal class feedback
    {
        static string[,] comments = new string[100, 2];
        public void ReadFeedback()
        {
            Console.Clear();

            int rows = comments.GetLength(0);
            int columns = comments.GetLength(1);

            for (int i = 0; i < rows; ++i)
            {
                if (comments[i, 0] != null && comments[i, 1] != null)
                {
                    Console.WriteLine($"Comment: {comments[i, 0]} Email: {comments[i, 1]}");
                }
            }
            Console.ReadKey();
        }
        public string SendFeedback(ref int commentCount, string email)
        {
            Console.Clear();

            string comment;
            Console.WriteLine("Feed back");
            Console.WriteLine("~&/Send your experience and about journey via orange line /&~");
            comment = Console.ReadLine();
            comments[commentCount - 1, 0] = comment;
            comments[commentCount - 1, 1] = email;
            commentCount++;
            return "feedback sended succfully";
        }
    }
}
