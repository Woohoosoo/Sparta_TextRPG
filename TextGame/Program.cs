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
        private enum MenuState
        {
            MainMenu,
            PlayerStats,
            Inventory,
            Shop
        }

        // 현재 메뉴 상태
        private static MenuState currentMenu = MenuState.MainMenu;

        // 처음 나오는 화면
        private static void Main(string[] args)
        {
            while (true)
            {
                switch (currentMenu)
                {
                    case MenuState.MainMenu:
                        ShowMainMenu();
                        break;
                    case MenuState.PlayerStats:
                        PlayerStats();
                        break;
                    case MenuState.Inventory:
                        ShowInventory();
                        break;
                    case MenuState.Shop:
                        ShowShop();
                        break;
                }
                Console.Clear(); 
            }
        }

        // 메인 메뉴 화면
        private static void ShowMainMenu()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine("1: 상태 보기 ");
            Console.WriteLine("2: 인벤토리 ");
            Console.WriteLine("3: 상점 ");
            Console.Write("원하시는 행동을 입력해주세요: ");
            string MainMene = Console.ReadLine();

            switch (MainMene)
            {
                case "1":
                    currentMenu = MenuState.PlayerStats;
                    break;
                case "2":
                    currentMenu = MenuState.Inventory;
                    break;
                case "3":
                    currentMenu = MenuState.Shop;
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
            Console.Clear();
        }

        // 플레이어의 기본 설정
        private static void PlayerStats()
        {
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine("Lv. 01");
            Console.WriteLine("이름: 르탄");
            Console.WriteLine("직업: 전사");
            Console.WriteLine("공격력: 10");
            Console.WriteLine("방어력: 5");
            Console.WriteLine("체력: 100");
            Console.WriteLine("Gold: 1500 G");
            Console.WriteLine("0.나가기");
            Console.WriteLine("원하시는 행동을 입력해주세요");

            string StatsMenu = Console.ReadLine();

            switch (StatsMenu)
            {
                case "0":
                    currentMenu = MenuState.MainMenu;
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
            Console.Clear();
        }

        // 인벤토리 화면
        private static void ShowInventory()
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("[아이템 목록]");

            Console.WriteLine("1: 장착 관리 ");
            Console.WriteLine("0: 나가기 ");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해주세요: ");
            string inventoryList = Console.ReadLine();

            switch (inventoryList)
            {
                case "0":
                    currentMenu = MenuState.MainMenu;
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
            Console.Clear();
        }

        // 상점 화면
        private static void ShowShop()
        {
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");

            Console.WriteLine("1. 수련자 갑옷 | 방어력 +5 | 방어력 +100 G");
            Console.WriteLine("2. 무쇠갑옷 | 방어력 +9 | 방어력 +200 G");
            Console.WriteLine("3. 스파르타의 갑옷 | 방어력 +15 | 방어력 +300 G");
            Console.WriteLine("4. 낡은 검 | 공격력 +2 | 공격력 +50 G");
            Console.WriteLine("5. 청동 도끼 | 공격력 +5 | 공격력 +150 G");
            Console.WriteLine("6. 스파르타의 창 | 공격력 +7 | 공격력 +250 G");

            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            string shopMenu = Console.ReadLine();

            switch (shopMenu)
            {
                case "0":
                    currentMenu = MenuState.MainMenu;
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
            Console.Clear();
        }
        /*
         공사중

        public class Shop
        {
            public static void ShowShop()
            {
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");

                Console.WriteLine($"1. {ItemDescriptions.A} | {StatsType.Defense} + {ItemStats.A} | {ItemEffects.DefenseEffect} {StatsType.GoldCost} + {ItemPrices.A} G");
                Console.WriteLine($"2. {ItemDescriptions.B} | {StatsType.Defense} + {ItemStats.B} | {ItemEffects.DefenseEffect} {StatsType.GoldCost} + {ItemPrices.B} G");
                Console.WriteLine($"3. {ItemDescriptions.C} | {StatsType.Defense} + {ItemStats.C} | {ItemEffects.DefenseEffect} {StatsType.GoldCost} + {ItemPrices.C} G");
                Console.WriteLine($"4. {ItemDescriptions.D} | {StatsType.Attack} + {ItemStats.D} | {ItemEffects.AttackEffect} {StatsType.GoldCost} + {ItemPrices.D} G");
                Console.WriteLine($"5. {ItemDescriptions.E} | {StatsType.Attack} + {ItemStats.E} | {ItemEffects.AttackEffect} {StatsType.GoldCost} + {ItemPrices.E} G");
                Console.WriteLine($"6. {ItemDescriptions.F} | {StatsType.Attack} + {ItemStats.F} | {ItemEffects.AttackEffect} {StatsType.GoldCost} + {ItemPrices.F} G");

                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                string shopMenu = Console.ReadLine();

                switch (shopMenu)
                {
                    case "1":
                        //   Buy();
                        break;
                    case "0":
                        //   Back();
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            }

            public enum StatsType
            {
                Defense,
                Attack,
                GoldCost
            }

            public static class ItemDescriptions
            {
                public static string A = "수련자 갑옷";
                public static string B = "무쇠갑옷";
                public static string C = "스파르타의 갑옷";
                public static string D = "낡은 검";
                public static string E = "청동 도끼";
                public static string F = "스파르타의 창";
            }

            public static class ItemStats
            {
                public static string A = "5";
                public static string B = "9";
                public static string C = "15";
                public static string D = "2";
                public static string E = "5";
                public static string F = "7";
            }

            public static class ItemEffects
            {
                public static string DefenseEffect = "방어력";
                public static string AttackEffect = "공격력";
            }

            public static class ItemPrices
            {
                public static string A = "100";
                public static string B = "200";
                public static string C = "300";
                public static string D = "50";
                public static string E = "150";
                public static string F = "250";



            }

        }
        */
    }
}