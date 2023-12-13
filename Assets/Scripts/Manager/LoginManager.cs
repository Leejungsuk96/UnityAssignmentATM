using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    // 회원가입 InputField
    public InputField IDInput;
    public InputField NameInput;
    public InputField PasswordInput;
    public InputField PsConfirmInput;        
    public Text messageTxt;
    //로그인 InputField
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
    {    //공백제거
        string UserID = IDInput.text.Trim();
        string UserName = NameInput.text.Trim();
        string UserPassword = PasswordInput.text.Trim();
        string confirmPassword = PsConfirmInput.text.Trim(); 
        
        //공백방지
        if (string.IsNullOrEmpty(UserID) || string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(UserPassword) || string.IsNullOrEmpty(confirmPassword))
        {
            messageTxt.text = "입력 칸을 전부 채워주세요.";
        }
        // 비밀번호 확인
        else if (UserPassword != confirmPassword)
        {
            messageTxt.text = "입력하신 비밀번호가 일치하지 않습니다.";
        }
        //최소 글자수 최대 글자수 확인
        else if (UserID.Length < 3  ||  UserID.Length > 10 || UserName.Length < 1 || UserName.Length >5 || UserPassword.Length < 5 || UserPassword.Length > 15)
        {
            messageTxt.text = "ID= 영어,숫자 3~10 / Name= 2~5/ PS= 영어 숫자 5~15 글자수를 확인해주세요";
        }
        //등록된 아이디 확인
        else if (PlayerPrefs.HasKey(UserID))
        {
            messageTxt.text = "이미 사용 중인 ID입니다.";
        }
        //등록
        else
        {
            PlayerPrefs.SetString(UserID, UserName + ":" + UserPassword);
            PlayerPrefs.Save();
            messageTxt.text = "회원가입이 완료되었습니다.";
        }                    
    }
   
    public void Login()
    {
        string UserID = LoginIDInput.text.Trim();
        string UserPassword = LoginPSInput.text.Trim();

        if (string.IsNullOrEmpty(UserID) || string.IsNullOrEmpty(UserPassword))
        {
            loginmessageTxt.text = "ID와 비밀번호를 입력해주세요";
        }

        else if (PlayerPrefs.HasKey(UserID))
        {
            string[] userInfo = PlayerPrefs.GetString(UserID).Split(':');
            string SavePassword = userInfo[1];

            if (SavePassword == userInfo[1])
            {
                loginmessageTxt.text = "로그인 성공!";
                Invoke("OnClickLogin", 2f);
            }

            else
            {
                loginmessageTxt.text = "비밀번호가 일치 하지 않습니다.";
            }
        }
        else
        {
            loginmessageTxt.text = "등록되지 않은 ID입니다.";
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
