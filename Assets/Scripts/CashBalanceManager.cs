using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashBalanceManager : MonoBehaviour
{
    public static CashBalanceManager Instance { get; private set; }  
    public int Balance;
    public int Cash;

    private void Awake()
    {
        Instance = this;
    }
}