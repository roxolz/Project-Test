using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSY : MonoBehaviour
{
    public static MainSY ins;

    public event Action ClickButton;


    void Awake()
    {
        if(ins == null)
        ins = this;
        else
        Destroy(this);
    }

        

    public void OnClickButton(){
            ClickButton.Invoke();
    }
    
}
