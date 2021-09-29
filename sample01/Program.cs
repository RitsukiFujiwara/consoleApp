using System;

namespace sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hangman =
            {
                "--------------------------",
                "|                      |",
                "|                     ( )",
                "|                      |",
                "|                      |",
                "|                    --|--",
                "|                      ^",
                "|                     | |",
                "|                     | |",
                "|                     ",
                 "--------------------------",
            };
            //出題者の入力ふぇーず
            Console.WriteLine("英単語を入力してください。");
            string word = Console.ReadLine();
            //画面クリア
            Console.Clear();
            //下線を表示
            for(int i = 0; i< word.Length; i++)
            {
                Console.Write("_ ");
            }
            //出題者の入力単語を'_'に置き換え
            char[] answer = new char[word.Length];
            for(int i =0; i< answer.Length; i++)
            {
                answer[i] = '_';
            }
            //間違え用カウンター
            int count = 0;
            bool loopCheck = true;
            while (loopCheck)
            {
                //解答者の入力ふぇーず
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("アルファベット１文字を入力してください。");
                string alphabet = Console.ReadLine();

                if(alphabet.Length != 1)
                {
                    Console.Clear();
                    continue;
                }
                //画面クリア
                Console.Clear();

                bool check = false;
                for(int i = 0; i< word.Length; i++)
                {
                    //正解の時の処理
                    if(word[i] == char.Parse(alphabet))
                    {
                        answer[i] = char.Parse(alphabet);
                        check = true;
                    }
                }

                if (!check)
                {
                    //不正解の場合、描画処理
                    count++;
                }
                string tmp = new string(answer);
                foreach(char value in tmp)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(hangman[i]);
                }
                //勝ち判定
                if (!tmp.Contains("_"))
                {
                    Console.WriteLine("勝ちです。");
                    loopCheck = false;
                }
                //負け判定
                else if (count == hangman.Length)
                {
                    Console.WriteLine("負けです。");
                    loopCheck = false;
                }
            }
        }
    }
}
