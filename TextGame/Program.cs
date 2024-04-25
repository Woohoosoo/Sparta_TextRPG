using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Xml.Linq;

namespace TextGame

{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine("1: 상태 보기 ");
            Console.WriteLine("2: 인벤토리 ");
            Console.WriteLine("3: 상점 ");
            Console.Write("원하시는 행동을 입력해주세요: ");
            Console.WriteLine();
            string MainMene = Console.ReadLine();

            switch (MainMene)
            {
                case "1":
                    player.PlayerStats();
                    break;
                case "2":
                    inventory.ShowInventory();
                    break;
                case "3":
                    Shop.ShowShop();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }

    class player
    { 
    public enum Job { 전사, 마법사, 궁수 }
    static int Level = 01;
    static int Attck = 10;
    static int Defance = 5;
    static int HP = 100;
    static int Money = 1500;
    //bool equipment;

    
        public static void PlayerStats()
    {
        Console.WriteLine("Lv. " + level);
        Console.Write("이름: 르탄이 ");
        //Console.Write("이름: " + name);
        //string name = Console.ReadLine();
        Console.WriteLine("직업 " + (Job)0);
        Console.WriteLine("공격력 " + attack);
        Console.WriteLine("방어력 " + defence);
        Console.WriteLine("체력 " + hp);
        Console.WriteLine("Gold " + nowMoney + " G");

        if (equipment)
        {

        }

    }
}


    class inventory
    {
        public static void ShowInventory()
        {
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("1: 장착 관리 ");
            Console.WriteLine("0: 나가기 ");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해주세요: ");
            Console.WriteLine();
            string inventoryList = Console.ReadLine();

            switch (inventoryList)
            {
                case "1":
                    inventory.ItemList();
                    break;
                case "0":
                    Back();
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
        class Item
        {

            public static void ItemList()
            {
                Console.WriteLine("아이템 목록:");
                Console.WriteLine("1. " + ItemNames.A + " | " + ItemEffects.A + " | " + ItemDescriptions.A);
                Console.WriteLine("2. " + ItemNames.B + " | " + ItemEffects.B + " | " + ItemDescriptions.B);
                Console.WriteLine("3. " + ItemNames.C + " | " + ItemEffects.C + " | " + ItemDescriptions.C);
            }
            //bool 장착여부
            //int 오르는 수치

        }

        struct ItemNames
        {
            public static string A = "무쇠갑옷";
            public static string B = "스파르타의 창";
            public static string C = "낡은 검";
        }

        struct ItemEffects
        {
            public static string A = "방어력 +5";
            public static string B = "공격력 +7";
            public static string C = "공격력 +2";
        }

        struct ItemDescriptions
        {
            public static string A = "무쇠로 만들어져 튼튼한 갑옷입니다.";
            public static string B = "스파르타의 전사들이 사용했다는 전설의 창입니다.";
            public static string C = "쉽게 볼 수 있는 낡은 검입니다.";
        }
    }
    class Shop
    {
        public static void ShowShop()
        {
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]" + nowMoney + " G");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine(" 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |" + price + " G");
            Console.WriteLine(" 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료");
            Console.WriteLine(" 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|" + price + " G");
            Console.WriteLine(" 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |" + price + " G");
            Console.WriteLine(" 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |" + price + " G");
            Console.WriteLine(" 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료");
            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            string shopMenu = Console.ReadLine();

            switch (shopMenu)
            {
                case "1":
                    Buy;
                    break;
                case "0":
                    Back;
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
}
 
