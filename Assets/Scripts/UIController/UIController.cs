using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject ActionButton;
    public GameObject WithdrawMode;
    public GameObject DepositMode;
    public CustomerInformation customerInfo;
    public GameObject WarningPanel;
    public Text DirectAmountTxt;
    private int DirectAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickWithdraw()
    {
        ActionButton.SetActive(false);
        WithdrawMode.SetActive(true); 
    }

    public void ClickDeposit()
    {
        ActionButton.SetActive(false);
        DepositMode.SetActive(true);
    }

    public void ClickBack()
    {
        WithdrawMode.SetActive(false);
        DepositMode.SetActive(false);
        ActionButton.SetActive(true);
    }
    
    public void ClickTenWithdraw()
    {
        if (customerInfo.CustomerAccountBalance >= 10000)
        {
           customerInfo.CustomerAccountBalance -= 10000;
           customerInfo.CustomerWalletBalance += 10000;
        }

        else
        {
            WarningPanel.SetActive(true);
        }
        
    }

    public void ClickThirtyWithdraw()
    {
        if (customerInfo.CustomerAccountBalance >= 30000)
        {
            customerInfo.CustomerAccountBalance -= 30000;
            customerInfo.CustomerWalletBalance += 30000;
        }

        else
        {
            WarningPanel.SetActive(true);
        }

    }

    public void ClickFiftyWithdraw()
    {
        if (customerInfo.CustomerAccountBalance >= 50000)
        {
            customerInfo.CustomerAccountBalance -= 50000;
            customerInfo.CustomerWalletBalance += 50000;
        }

        else
        {
            WarningPanel.SetActive(true);
        }

    }

    public void ClickDirectWithdraw()
    {
        
        DirectAmount = int.Parse(DirectAmountTxt.text);
        if(customerInfo.CustomerAccountBalance >= DirectAmount)
        {
            customerInfo.CustomerAccountBalance -= DirectAmount;
            customerInfo.CustomerWalletBalance += DirectAmount;
        }
        else
        {
            WarningPanel.SetActive(true);
        }
    }

    public void ClickConfirmation()
    {
        WarningPanel.SetActive(false);
    }
}
