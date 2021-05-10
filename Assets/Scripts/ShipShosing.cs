using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipShosing : MonoBehaviour
{
    [SerializeField] private GameObject _menuShip;
    [SerializeField] private string _currentShip;
    //выпор корабля ну и надпись какой корабль взят
    public void Сhoice()
    {
        UI.Menu.userShip = _menuShip;        
        UI.Menu.currentShip = $"Ваш корабль: {_currentShip}";       

    }
}
