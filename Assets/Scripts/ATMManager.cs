using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ATMManager : MonoBehaviour
{
    [SerializeField] private Text walletBalance;
    [SerializeField] private Text accountBalance;
    [SerializeField] private Text accountName;
    public CustomerInformation customerInfo;
    private int UserAccountBalance;
    private int UserWalletBalance;

    private void Awake()
    {
        SettingSaveUserInfo();        
    }
    // Start is called before the first frame update
    void Start()
    {
        UISetting();
    }

    //// Update is called once per frame
    void Update()
    {
        UISetting();
    }

    private void SettingSaveUserInfo()
    {        
        customerInfo.CustomerAccountBalance = PlayerPrefs.GetInt("AccountBalance0");
        customerInfo.CustomerWalletBalance = PlayerPrefs.GetInt("WalletBalance0");
    }

    private void UISetting()
    {
        accountName.text = customerInfo.CustomerName;
        accountBalance.text = "Balance: " + customerInfo.CustomerAccountBalance.ToString();
        walletBalance.text = customerInfo.CustomerWalletBalance.ToString();

        UserAccountBalance = customerInfo.CustomerAccountBalance;
        UserWalletBalance = customerInfo.CustomerWalletBalance;

        PlayerPrefs.SetInt("AccountBalance0", UserAccountBalance);
        PlayerPrefs.SetInt("WalletBalance0", UserWalletBalance);
    }
}
