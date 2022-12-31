using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeManager : MonoBehaviour
{
    public static CodeManager Instance {get; private set;}
    
    public void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }else
        {
            Instance = this;
        }
    }
}
