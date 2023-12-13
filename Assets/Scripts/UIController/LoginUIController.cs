using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginUIController : MonoBehaviour
{
    public GameObject LoginManager;
    public GameObject ATMManager;
    public GameObject SignUpPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickLogin()
    {
        LoginManager.SetActive(false);
        ATMManager.SetActive(true);
    }

    public void OnClickSignUP()
    {
        SignUpPanel.SetActive(true);
    }

    public void OnClickCancel()
    {
        SignUpPanel.SetActive(false);
    }
}
