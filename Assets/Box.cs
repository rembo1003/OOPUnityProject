using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Box : Entity
{
    [SerializeField] string _boxName;
    [SerializeField] bool clickAble;
    void Start()
    {
        EntityName = _boxName;
        CanClick = clickAble;
    }

    //POLYMORPHISM
    public override void InitializeComponent()
    {
        gameObject.AddComponent<Rigidbody>();
    }
}
