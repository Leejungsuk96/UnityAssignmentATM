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

    private void Awake()
    {
        accountName.text = customerInfo.CustomerName;
        accountBalance.text ="Balance: " + customerInfo.CustomerAccountBalance.ToString();
        walletBalance.text = customerInfo.CustomerWalletBalance.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
