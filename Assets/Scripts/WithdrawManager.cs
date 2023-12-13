using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawManager : MonoBehaviour
{
    [SerializeField] Button _10000button;
    [SerializeField] Button _30000button;
    [SerializeField] Button _50000button;
    [SerializeField] Button _Withdrawbutton;

    public GameObject NoCash;
    public GameObject CorrectPlz;

    public Text currentBalanceText;
    public Text currentCashText;
    public InputField withdrawInputField;

    

    void Start()
    {
        UpdateBalanceText();
        // 버튼을 누를때 어떤것을 실행 할건지
        _10000button.onClick.AddListener(On10000ButtonClick);
        _30000button.onClick.AddListener(On30000ButtonClick);
        _50000button.onClick.AddListener(On50000ButtonClick);
        _Withdrawbutton.onClick.AddListener(OnWithdrawButtonClick);

    }
    

    public void Withdraw(int amount)
    {
        if (CashBalanceManager.Instance.Balance >= amount)
        {

            CashBalanceManager.Instance.Cash += amount;
            CashBalanceManager.Instance.Balance -= amount;
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

    public void OnWithdrawButtonClick()
    {

        int depositAmount;
        if (int.TryParse(withdrawInputField.text, out depositAmount))
        {

            Withdraw(depositAmount);
        }
        else
        {
            CorrectPlz.SetActive(true);
        }
    }

    public void UpdateBalanceText()
    {
        currentBalanceText.text = "잔액       " + CashBalanceManager.Instance.Balance.ToString("N0");
        currentCashText.text = "현금       " + CashBalanceManager.Instance.Cash.ToString("N0");
    }
}
