using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : Entity
{
    [SerializeField] string _boxName;
    [SerializeField] bool _canClick;
    void Start()
    {
        EntityName = _boxName;
        CanClick = true;
    }

    public override void InitializeComponent()
    {
        gameObject.AddComponent<Rigidbody>();
    }
}
