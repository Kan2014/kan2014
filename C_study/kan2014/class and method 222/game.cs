using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace mobs
{
    
    class Monster
    {
        public string name;
        public int hp;
        public int str;
        public int spd;
        public int dropm;
        public int exp;
    }

    class mob1 : Monster
    {
        public string name = "슬라임";
        public int hp = 10;
        public int str = 2;
        public int spd = 3;
        public int dropm = 3;
        public int exp = 2;

        public mob1()
        {
            this.name = "슬라임";
            this.hp = 10;
            this.str = 2;
            this.spd = 3;
            this.dropm = 3;
            this.exp = 2;
    }
    }
    class mob2 : Monster
    {
        public string name = "구울";
        public int hp = 15;
        public int str = 3;
        public int spd = 2;
        public int dropm = 12;
        public int exp = 2;
        public mob2()
        {
            this.name = "구울";
            this.hp = 15;
            this.str = 3;
            this.spd = 2;
            this.dropm = 12;
            this.exp = 2;
        }
    }
}
namespace stat
{
    internal class stat
    {
        public int hp = 10;
        public int str = 3;
        public int spd = 5;
        public int money = 0;
        public int bullet = 0;
    }
}
namespace eevent
{
    internal class gf
    {
        
    }
}
namespace c_study
{
    internal class game2
    {
        public bool gun;
        public void Fight(mobs.Monster monster)
        {
            stat.stat players = new stat.stat();
            int hp1 = monster.hp;
            int str1 = monster.str;
            int spd1 = monster.spd;
            int dropm1 = monster.dropm;
            int exp1 = monster.exp;
            string name1 = monster.name;
            int end = 0;
            while ( end == 0 )
            {
                if ( players.spd >= monster.spd ) 
                {
                    So();
                    Console.WriteLine("공격=1,가드=2");
                    int ac = int.Parse(Console.ReadLine());
                    if(ac==1)
                    {
                        hp1-=players.str;
                        Console.WriteLine("플레이어 공격!");
                        Console.WriteLine("대미지"+players.str);
                        if (hp1 <= 0)
                        {
                            end = 1;
                        }
                        players.hp-=str1;
                        Console.WriteLine(monster.name+"공격!");
                        Console.WriteLine("대미지" + str1);
                        if (players.hp <= 0)
                        {
                            end = 1;
                        }
                    } else
                    {
                        players.hp++;
                    }
                }
                else
                {
                    Console.WriteLine("공격=1,가드=2");
                    string act = Console.ReadLine();
                    int ac = int.Parse(act);
                    if (ac == 1)
                    {
                        players.hp -= str1;
                        Console.WriteLine(monster.name + "공격!");
                        if (players.hp <= 0)
                        {
                            end = 1;
                        }
                        hp1 -= players.str;
                        Console.WriteLine("플레이어 공격!");
                        if (hp1 <= 0)
                        {
                            end = 1;
                        }
                    }
                    else
                    {
                        players.hp++;
                    }
                }
            }
            if ( players.hp < 0 )
            {
                Console.WriteLine("사망하셨습니다");
                players.hp = 10;
                players.str = 3;
                players.spd = 5;
                Play();
            } else
            {
                Console.WriteLine("승리하였습니다");
            }
        }

        public void So()
        {
            stat.stat players = new stat.stat();
            Console.WriteLine("hp" + players.hp);
            Console.WriteLine("str" + players.str);
            Console.WriteLine("spd" + players.spd);
            Console.WriteLine("$" + players.money);
        }
        public void Play()
        {
            Console.WriteLine("게임");
            Console.WriteLine("게임을 시작하려면 1를 누르시오");
            string a = Console.ReadLine();
            int z = int.Parse(a);
            Console.WriteLine("null");
            if (z == 1)
            {
                int r = new Random().Next(0,3);
                stat.stat playerStat = new stat.stat();
                if (r == 0)
                {
                    Console.WriteLine("길을 가다가 돈을 발견하였 습니다!");
                    playerStat.money++;
                    So();
                }
                else
                {
                    Console.WriteLine("갈림길이 나왔습니다 어디로 가시갰습니까?");
                    Console.WriteLine("1=마을,2=묘지");
                    string tl1 = Console.ReadLine();
                    int t1 = int.Parse(tl1);
                    if (t1 == 2)
                    {
                        int rmob1 = new Random().Next(0, 1);
                        if (rmob1 == 0)
                        {
                            mobs.mob2 mob2 = new mobs.mob2();
                            Fight(mob2);
                        }
                    }   else 
                    {
                        
                    }
                }
            }
            //없대이트

        }

    }
}
