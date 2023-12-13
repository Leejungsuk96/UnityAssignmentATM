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
    public Text DirectWithdrawAmountTxt;
    private int DirectWithdrawAmount = 0;
    public Text DirectDepositAmountTxt;
    private int DirectDepositAmount = 0;
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

        DirectWithdrawAmount = int.Parse(DirectWithdrawAmountTxt.text);
        if(customerInfo.CustomerAccountBalance >= DirectWithdrawAmount)
        {
            customerInfo.CustomerAccountBalance -= DirectWithdrawAmount;
            customerInfo.CustomerWalletBalance += DirectWithdrawAmount;
        }
        else
        {
            WarningPanel.SetActive(true);
        }
    }

    public void ClickTenDeposit()
    {
        if (customerInfo.CustomerWalletBalance >= 10000)
        {
            customerInfo.CustomerAccountBalance += 10000;
            customerInfo.CustomerWalletBalance -= 10000;
        }

        else
        {
            WarningPanel.SetActive(true);
        }
    }
    public void ClickThirtyDeposit()
    {
        if (customerInfo.CustomerWalletBalance >= 30000)
        {
            customerInfo.CustomerAccountBalance += 30000;
            customerInfo.CustomerWalletBalance -= 30000;
        }

        else
        {
            WarningPanel.SetActive(true);
        }
    }
    public void ClickFiftyDeposit()
    {
        if (customerInfo.CustomerWalletBalance >= 50000)
        {
            customerInfo.CustomerAccountBalance += 50000;
            customerInfo.CustomerWalletBalance -= 50000;
        }

        else
        {
            WarningPanel.SetActive(true);
        }
    }

    public void ClickDirectDeposit()
    {

        DirectDepositAmount = int.Parse(DirectDepositAmountTxt.text);
        if (customerInfo.CustomerWalletBalance >= DirectDepositAmount)
        {
            customerInfo.CustomerAccountBalance += DirectDepositAmount;
            customerInfo.CustomerWalletBalance -= DirectDepositAmount;
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
