using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    // ȸ������ InputField
    public InputField IDInput;
    public InputField NameInput;
    public InputField PasswordInput;
    public InputField PsConfirmInput;        
    public Text messageTxt;
    //�α��� InputField
    public InputField LoginIDInput;
    public InputField LoginPSInput;
    public Text loginmessageTxt;

    public GameObject loginManager;
    public GameObject atmManager;
    public GameObject SignUpPanel;

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

    public void SignUp()
    {    //��������
        string UserID = IDInput.text.Trim();
        string UserName = NameInput.text.Trim();
        string UserPassword = PasswordInput.text.Trim();
        string confirmPassword = PsConfirmInput.text.Trim(); 
        
        //�������
        if (string.IsNullOrEmpty(UserID) || string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(UserPassword) || string.IsNullOrEmpty(confirmPassword))
        {
            messageTxt.text = "�Է� ĭ�� ���� ä���ּ���.";
        }
        // ��й�ȣ Ȯ��
        else if (UserPassword != confirmPassword)
        {
            messageTxt.text = "�Է��Ͻ� ��й�ȣ�� ��ġ���� �ʽ��ϴ�.";
        }
        //�ּ� ���ڼ� �ִ� ���ڼ� Ȯ��
        else if (UserID.Length < 3  ||  UserID.Length > 10 || UserName.Length < 1 || UserName.Length >5 || UserPassword.Length < 5 || UserPassword.Length > 15)
        {
            messageTxt.text = "ID= ����,���� 3~10 / Name= 2~5/ PS= ���� ���� 5~15 ���ڼ��� Ȯ�����ּ���";
        }
        //��ϵ� ���̵� Ȯ��
        else if (PlayerPrefs.HasKey(UserID))
        {
            messageTxt.text = "�̹� ��� ���� ID�Դϴ�.";
        }
        //���
        else
        {
            PlayerPrefs.SetString(UserID, UserName + ":" + UserPassword);
            PlayerPrefs.Save();
            messageTxt.text = "ȸ�������� �Ϸ�Ǿ����ϴ�.";
        }                    
    }
   
    public void Login()
    {
        string UserID = LoginIDInput.text.Trim();
        string UserPassword = LoginPSInput.text.Trim();

        if (string.IsNullOrEmpty(UserID) || string.IsNullOrEmpty(UserPassword))
        {
            loginmessageTxt.text = "ID�� ��й�ȣ�� �Է����ּ���";
        }

        else if (PlayerPrefs.HasKey(UserID))
        {
            string[] userInfo = PlayerPrefs.GetString(UserID).Split(':');
            string SavePassword = userInfo[1];

            if (SavePassword == userInfo[1])
            {
                loginmessageTxt.text = "�α��� ����!";
                Invoke("OnClickLogin", 2f);
            }

            else
            {
                loginmessageTxt.text = "��й�ȣ�� ��ġ ���� �ʽ��ϴ�.";
            }
        }
        else
        {
            loginmessageTxt.text = "��ϵ��� ���� ID�Դϴ�.";
        }        
    }

    public void OnClickLogin()
    {
        loginManager.SetActive(false);
        atmManager.SetActive(true);
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
