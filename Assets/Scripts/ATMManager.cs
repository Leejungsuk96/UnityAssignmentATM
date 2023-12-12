using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ATMManager : MonoBehaviour
{
    [SerializeField] private int WalletBalance;
    [SerializeField] private int AccountBalance;

    private TMP_Text CustomerWalleBalance;
    private TMP_Text CustomerAccountBalance;
    private Button Deposit;
    private Button Whithdraw;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
