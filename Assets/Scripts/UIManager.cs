using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject depositUI;
    public GameObject WithdrawUI;
    public GameObject Button;
    public GameObject DepositExitButton;
    public GameObject WithdrawExitButton;
    public void OnDepositButtonClick()
    {
        depositUI.SetActive(true);
        Button.SetActive(false);
    }

    public void OnWithdrawButtonClick()
    {
        WithdrawUI.SetActive(true);
        Button.SetActive(false);
    }

    public void OnDepositExitButtonClick()
    {
        Button.SetActive(true);
        depositUI.SetActive(false);
    }

    public void OnWithdrawExitButtonClick()
    {
        Button.SetActive(true);
        WithdrawUI.SetActive(false);
    }
}
