using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManage : MonoBehaviour
{
    [SerializeField] private Text _currentShip;
    void Update()
    {
        _currentShip.text = UI.Menu.currentShip;
    }
}
