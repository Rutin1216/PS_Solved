using System;

namespace P1018
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //보드 사이즈
            string[] size = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(size[1]), y = Convert.ToInt32(size[0]);
            
            //보드 입력받기
            string[] chessboard = new string[y];
            for (int i = 0; i < y; i++)
            {
                chessboard[i] = Console.ReadLine();
            }
            //최종 결과값 저장
            int result = 0;
            
            //두가지 경우의 수 결과값 저장
            int cnt1 = 0, cnt2 = 0;
            
            //보드에서 8,8 체스판을 자르는 경우의 수
            for (int l = 0; l <= y - 8; l++)
            {
                for (int k = 0; k <= x - 8; k++)
                {
                    for (int i = l; i < 8 + l; i++)
                    {
                        for (int j = k; j < 8 + k; j++)
                        {
                            if (i % 2 == 0 && j % 2 == 0)
                            {
                                //체스판 시작점이 흰색일 경우
                                if (chessboard[i][j] != 'W')
                                    cnt1++;
                                //체스판 시작점이 검은색일 경우
                                else if(chessboard[i][j] != 'B')
                                    cnt2++;
                            }else if (i % 2 != 0 && j % 2 != 0)
                            {
                                if (chessboard[i][j] != 'W')
                                    cnt1++;
                                else if(chessboard[i][j] != 'B')
                                    cnt2++;
                            }else if (i % 2 == 0 && j % 2 != 0)
                            {
                                if (chessboard[i][j] != 'B')
                                    cnt1++;
                                else if (chessboard[i][j] != 'W')
                                    cnt2++;
                            }else if (i % 2 != 0 && j % 2 == 0)
                            {
                                if (chessboard[i][j] != 'B')
                                    cnt1++;
                                else if (chessboard[i][j] != 'W')
                                    cnt2++;
                            }
                        }   
                    }
                    //두가지 경우의 수 중 작은 값을 최종값에 저장
                    if(l == 0 && k == 0) 
                        result = cnt1 > cnt2 ? cnt2 : cnt1;
                    else
                    {
                        int a = cnt1 > cnt2 ? cnt2 : cnt1;
                        result = a < result ? a : result;
                    }
                    // 경우의 수 초기화
                    cnt1 = 0;
                    cnt2 = 0;
                }
            }
            // 결과출력
            Console.WriteLine(result);
        }
    }
}