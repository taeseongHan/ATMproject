# 구현내용
- ATM 화면 구성
- 현금, 잔액을 싱글톤화 해서 입금, 출금 시스템에서 전부 공유하게 만듬
- 입금 화면 UI 에서 누르는 버튼 금액에 따라서 잔액은 올라가고 현금은 떨어지게 함, 현금이 입금희망 금액보다 적으면 잔액부족UI 띄움 Ok버튼을 누름으로 다시 돌아올 수 있음
- Input Field를 이용해서 입금희망금액 직접입력 가능, 숫자말고 다른 문자를 넣으면 "올바른 금액을 입력하세요" 팝업창 뜸 Ok버튼을 누름으로 다시 돌아올 수 있음
- 뒤로가기 버튼으로 메인화면으로 돌아가기 가능

- 출금 화면 UI 에서 누르는 버튼 금액에 따라서 잔액은 떨어지고 현금은 올라가게 함, 잔액이 출금희망 금액보다 적으면 잔액부족UI 띄움 Ok버튼을 누름으로 다시 돌아올 수 있음
- Input Field를 이용해서 출금희망금액 직접입력 가능, 숫자말고 다른 문자를 넣으면 "올바른 금액을 입력하세요" 팝업창 뜸 Ok버튼을 누름으로 다시 돌아올 수 있음
- 뒤로가기 버튼으로 메인화면으로 돌아가기 가능

### 느낀점
- 필수 구현 사항은 다 구현했는데 연동시키는 부분이 확실히 어려움.
- 작업 할 때 GitHub 자주 commit 하는걸 습관화 하기로 했는데 그 부분도 부족함.
