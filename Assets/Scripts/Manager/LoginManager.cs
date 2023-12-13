using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField IDInput;
    public InputField NameInput;
    public InputField PasswordInput;
    public InputField PsConfirmInput;
    public Text messageTxt;
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
}
