using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositManager : MonoBehaviour
{    
    [SerializeField] Button _10000button;
    [SerializeField] Button _30000button;
    [SerializeField] Button _50000button;
    [SerializeField] Button _Depositbutton;
    

    public GameObject NoCash;
    public GameObject CorrectPlz;

    public Text currentBalanceText;
    public Text currentCashText;
    public InputField depositInputField;

    
    void Start()
    {
        

        UpdateBalanceText();
        // ��ư�� ������ ����� ���� �Ұ���
        _10000button.onClick.AddListener(On10000ButtonClick);
        _30000button.onClick.AddListener(On30000ButtonClick);
        _50000button.onClick.AddListener(On50000ButtonClick);
        _Depositbutton.onClick.AddListener(OnDepositButtonClick);
        
    }

    
    public void Deposit(int amount)
    {
        if (CashBalanceManager.Instance.Cash >= amount )
        {

            CashBalanceManager.Instance.Cash -= amount;
            CashBalanceManager.Instance.Balance += amount;
            UpdateBalanceText();
        }
        else
        {
            NoCash.SetActive(true);
        }
    }

    public void On10000ButtonClick()
    {
        Deposit(10000);
    }

    public void On30000ButtonClick()
    {
        Deposit(30000);
    }

    public void On50000ButtonClick()
    {
        Deposit(50000);
    }

    public void OnDepositButtonClick()
    {
        
        int depositAmount;
        if (int.TryParse(depositInputField.text, out depositAmount))
        {
            
            Deposit(depositAmount);
        }
        else
        {
            CorrectPlz.SetActive(true);
        }
    }

    public void UpdateBalanceText()
    {
        currentBalanceText.text = "�ܾ�       " + CashBalanceManager.Instance.Balance.ToString("N0");
        currentCashText.text = "����       " + CashBalanceManager.Instance.Cash.ToString("N0");
    }


}
