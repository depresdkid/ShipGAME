using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StartGameScript : MonoBehaviour
{
    [SerializeField] private GameObject startShip;
    [SerializeField] private Text _health;
    void Start()
    {
        //спавнит корабль при запуске
        if (UI.Menu.userShip != null)
        {
            Instantiate(UI.Menu.userShip, new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 90f, 0f));
            print("start");
        }
        else {
            Instantiate(startShip, new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 90f, 0f));
            print("Выбран стандартный корабль");
        }        
    }
    
    private void Update()
    {
        // ну короче это надпись со здоровьем в левом верхнем углу
        try
        {
            if (Ship.ship.IsAlive)
            {
                _health.text = $"Прочность: {Ship.ship.Health}";
            }
            else
            {
                _health.text = $"Вы уничтожены";
                _health.color = Color.red ;
            }                
        }
        catch (System.Exception)
        {
        }

    }
}
