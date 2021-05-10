using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Vector3 position;
    //камера ставится за корабль
    private void CameraPos() {
        
        transform.position = GameObject.FindGameObjectWithTag("Player").transform.position + position;
    }   
    void Update()
    {
        //камера не перемещается если ты сдох нахуй)
        try
        {
            if (Ship.ship.IsAlive)
            {
                CameraPos();
            }
        }
        catch (System.Exception)
        {
        }
    }
}
