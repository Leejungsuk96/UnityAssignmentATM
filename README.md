# 유니티 숙련주차 ATM 과제
## 개발 환경
 Unity Ver: 2022.3.2f1 <br/><br/>
 IDE: VS Code 2022 <br/><br/>
 
 #ATM 기능 및 기획
![image](https://github.com/Leejungsuk96/UnityAssignmentATM/assets/114940193/e93e4191-dd43-4289-ac52-2b4b1ee24b5a)
<br/><br/><br/><br/>

## 필수 구현 / 추가 구현<br/><br/>
필수구현<br/><br/>
1. ATM 화면 구성✔️<br/><br/>
2. 입금 출금✔️<br/><br/>
3. 출금 기능✔️<br/><br/><br/><br/>

선택 구현<br/><br/>
1. 통화 단위 적용✔️<br/><br/>
2. 금액 입력시 숫자만 입력✔️<br/><br/>
3. 로그인 기능✔️<br/><br/>
4. 회원가입✔️<br/><br/>
5. 송금 기능<br/><br/>

## 주요기능
1. 스크립터블 오브젝트를 사용해서 은행 고객 정보 관리<br/><br/>
2. 입출금 기능 + 원하는 금액 입력 InputField로 구현<br/><br/>
3. 회원 가입 + 정보 로컬저장<br/><br/>
4. 로그인 기능


<br/><br/><br/><br/>

## Soulotion
1. 스크립터블 오브젝트 생성 및 활용
```
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
```
<br/><br/>
고객정보 스크립트 스크립터블 오브젝트로 생성<br/><br/>

![image](https://github.com/Leejungsuk96/UnityAssignmentATM/assets/114940193/5d445d66-0d2b-44ad-992d-19ad5e5f354c)<br/><br/>

해당 고객 정보 입력
<br/><br/><br/><br/>

2. 입출금 기능- 각 버튼에 알맞는 버튼 기능부여<br/><br/>
UIController.cs에서 한번에 관리<br/><br/>
InputField<br/><br/>
![image](https://github.com/Leejungsuk96/UnityAssignmentATM/assets/114940193/726bc37e-43b9-4a90-b62f-3d5b85eba95a)<br/><br/>
Content Type: Integer Number(금액이니깐 정수)로 설정

<br/><br/><br/><br/>

3. 회원 가입<br/><br/>
```
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
```
<br/><br/>
4. 로그인 <br/><br/>
```
public void Login()
{
    //공백 제거
    string UserID = LoginIDInput.text.Trim();
    string UserPassword = LoginPSInput.text.Trim();

    //공백 방지
    if (string.IsNullOrEmpty(UserID) || string.IsNullOrEmpty(UserPassword))
    {
        loginmessageTxt.text = "ID와 비밀번호를 입력해주세요";
    }
    // 아이디 존재 확인
    else if (PlayerPrefs.HasKey(UserID))
    {
        string[] userInfo = PlayerPrefs.GetString(UserID).Split(':');
        string SavePassword = userInfo[1];
        //로그인 성공
        if (SavePassword == userInfo[1])
        {
            loginmessageTxt.text = "로그인 성공!";
            Invoke("OnClickLogin", 2f);
        }
        // 비밀번호 불일치
        else
        {
            loginmessageTxt.text = "비밀번호가 일치 하지 않습니다.";
        }
    }
    //아이디 틀림
    else
    {
        loginmessageTxt.text = "등록되지 않은 ID입니다.";
    }        
}
```

## 어려운 점
회원 가입 시 회원에 따라 스크립터블 오브젝트를 자동으로 만들어서 송금 기능을 추가하고 싶었는데 방법을 모르고 시간이 부족해서 시도하지 못했다.
접근 제한자에 대한 정확한 이해가 없어서 필요에 따라 적절한 접근제한자를 설정해 주지 못한 것 같다.
스크립터블 오브젝트 활용과 이해가 부족한 것 같다.
Action과 Event에 대한 활용과 이해가 없어서 코드가 불필요하게 늘어나고 유지 보수가 힘들다는 걸 구현하면서도 느꼈다.




