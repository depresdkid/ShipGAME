using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] protected float _health;
    public string Health {
        get {
            return _health.ToString();
        }        
    }
    //жив ли
    public bool IsAlive {
        get {
            if (_health <= 0)
            {
                return false;
            }
            else
                return true;
        }
    }
    [SerializeField] protected float _armor;
    [SerializeField] private float _repulsionPower;
    public Rigidbody thisRigidbody;
    //Синглтон
    public static Ship ship;
    public void Awake()
    {
        ship = this;
    }
    //получение урона
    protected void GetDamage(float damage) {
        _health -= damage - _armor / 4;
    }
    //движение
    protected void Moving() {
        
    }
    //физика воды или механника плавания
    protected void Swim() {
        if (transform.position.y < 0)
        {
            float DrownValue = Mathf.Abs(transform.position.y);
            if (IsAlive)
            {
                thisRigidbody.AddForce(Vector3.up * DrownValue * 10 * _repulsionPower,ForceMode.Acceleration);
                thisRigidbody.drag = DrownValue * 10;
                thisRigidbody.angularDrag = DrownValue * 7;
                
            }
            else {

                if (thisRigidbody.drag < 5)
                {
                    thisRigidbody.drag = DrownValue * 10;
                    thisRigidbody.angularDrag = DrownValue * 7;
                }
            }           
        }
    }
    //фиксед апдейт)
    private void FixedUpdate()
    {
        Swim();
        
    }
}
