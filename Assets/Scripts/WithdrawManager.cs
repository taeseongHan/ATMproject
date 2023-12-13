using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawManager : MonoBehaviour
{
    [SerializeField] Button _10000button;
    [SerializeField] Button _30000button;
    [SerializeField] Button _50000button;


    public GameObject NoCash;

    public Text currentBalanceText;
    public Text currentCashText;

    public int currentBalance;
    public int currentCash;
    void Start()
    {
        UpdateBalanceText();
        // 버튼을 누를때 어떤것을 실행 할건지
        _10000button.onClick.AddListener(On10000ButtonClick);
        _30000button.onClick.AddListener(On30000ButtonClick);
        _50000button.onClick.AddListener(On50000ButtonClick);

    }


    public void Withdraw(int amount)
    {
        if (currentBalance >= amount)
        {

            currentCash += amount;
            currentBalance -= amount;
            UpdateBalanceText();
        }
        else
        {
            NoCash.SetActive(true);
        }
    }

    public void On10000ButtonClick()
    {
        Withdraw(10000);
    }

    public void On30000ButtonClick()
    {
        Withdraw(30000);
    }

    public void On50000ButtonClick()
    {
        Withdraw(50000);
    }

    public void UpdateBalanceText()
    {
        currentBalanceText.text = "잔액       " + currentBalance.ToString("N0");
        currentCashText.text = "현금       " + currentCash.ToString("N0");
    }
}
