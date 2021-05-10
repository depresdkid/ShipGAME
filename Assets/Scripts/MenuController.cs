using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    //не тупой сам знаешь че это
    public void StartGame() {
        SceneManager.LoadScene("GameWindow");
    }
    public void OpenShip()
    {
        SceneManager.LoadScene("MenuShips");
    }
    public void CloseShip()
    {
        SceneManager.LoadScene("Menu");
    }
    
}
