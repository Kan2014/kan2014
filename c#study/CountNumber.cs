using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c_study
{
    internal class CountNumber
    { 

        public void Play()
        {
            Console.WriteLine("게임 시작합니다");
            int rwe = new Random().Next(1,9); //랜덤 숫자
            int rqw = 5; //목숨
            bool re;
            re = false;
            Console.WriteLine("목숨은 5개 임니다.");
            while (re == false)
            {
                string aString  = Console.ReadLine();
                int a = int.Parse(aString);
     
                if (a == rwe)
                {
                    Console.WriteLine("축하합니다, 게임을 클리어 하였습니다");
                    re = true;
                    Play();
                }
                else
                {
                    if (rqw == 0)
                    {
                        Console.Write("패배 하였습니다.");
                        re = false;
                        Play();
                    }
                    rqw--;
                    Console.WriteLine("실패 하였습니다. 남은 목숨은" + rqw); 
                    if (rwe < a)
                    {
                        Console.WriteLine("<");
                    }   
                    else
                    { 
                        Console.WriteLine(">"); 
                    }
                }
            }
        }
        
        }
    }
