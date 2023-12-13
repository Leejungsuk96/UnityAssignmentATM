# 유니티 숙련주차 ATM 과제
## 개발 환경
 Unity Ver: 2022.3.2f1 <br/><br/>
 IDE: VS Code 2022 <br/><br/>
 
 #ATM 기능 및 기획
![image](https://github.com/Leejungsuk96/UnityAssignmentATM/assets/114940193/e93e4191-dd43-4289-ac52-2b4b1ee24b5a)
<br/><br/><br/><br/>

## 주요기능
1. 스크립터블 오브젝트를 사용해서 은행 고객 정보 관리<br/><br/>
2. 입출금 기능 + 원하는 금액 입력 InputField로 구현


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




