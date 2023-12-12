using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="CustomerData", menuName = "CustomerInfo")]
public class CustomerInformation:ScriptableObject
{
    public string CustomerName;
    public int CustomerAccountBalance;
    public int CustomerWalletBalance;
    
}
