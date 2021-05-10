using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UI 
{
    // статические поля для выбора корабля
    public class Menu {
        public static GameObject userShip;
        public static string currentShip = "Выберите корабль";
    }
    // это нахуй не надо мб удалю
    public class GameInfo
    {
        public static float userHealth;
        public static float reloadTimer;
    }
}
