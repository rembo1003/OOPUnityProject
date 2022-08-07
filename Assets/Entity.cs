using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
   private string _entityName;
   public string EntityName
   {
        get{return _entityName;}
        set{_entityName = value;}
    }

    private bool _canClick;
    public bool CanClick
    {
        get{return _canClick;}
        set{_canClick = value;}
    }

    void Awake()
    {
        InitializeComponent();
    }
    public virtual void InitializeComponent(){}
    public void DebugName()
    {
        Debug.Log(_entityName);
    }

    public void OnMouseDown()
    {
        if(_canClick)
        DebugName();
    }
}
