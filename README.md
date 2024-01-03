
# SUBWAY SUFFER 

Tiêu đề vắn tắt dự án

**Thành viên nhóm:**
Liệt kê thành viên nhóm phát triển dự án
# 1. Mô tả game
Mô tả cô đọng trong 5-10 dòng

## 1.1. Các kịch bản chơi game
* Game goal: Chạy, kiếm nhiều vàng để mở khóa tất cả nhân vật, mua các vật phẩm hỗ trợ để đạt được điểm càng cao càng tốt.
* Objectives:
  - Victory objective : không thực sự có (tự tạo cho bản thân 1 mục tiêu : mở khóa hết nhân vật; đạt điểm cao nhất thế giới;...)
  - Progression Objectives : các nhiệm vụ, thử thách, các dấu mốc nhỏ trong trò chơi.
  - Beneficial Objectives : ăn vàng hoặc hoàn thành nhiệm vụ, thử thách để có các vật phẩm giúp ích cho quá trình chơi.
  - Challenge Objectives : những thứ khó hoàn thành trong trò chơi.
* Các khu vực nhân vật chạy và khám phá:
  - Ai cập cổ: Cảnh quan với các kim tự tháp, sa mạc, và những di tích cổ xưa.
  - Ngoại ô thành phố: Khu vực ngoại ô với các nhà cửa, công viên và đường phố nhỏ.
  - Cầu: Chạy trên một chiếc cầu sắt bắc qua sông.
  - Nhà ga xe lửa: Gần các nhà ga với các đoạn đường tàu và tàu hỏa chạy qua.
  - Thành phố: Khu vực trung tâm với những tòa nhà cao tầng và xe bus.
  - Bãi biển: Cảnh đẹp với cát trắng, biển xanh.

## 1.2. Các usecase trong game
  **1. Chạy và né tránh:**
  - Mô tả: Nhân vật chạy liên tục trên các đoạn đường tàu điện ngầm, di chuyển qua các làn đường để tránh va chạm với các vật cản và tàu hỏa.
  - Hành động: Người chơi di chuyển nhân vật sang trái/phải hoặc nhảy để né tránh các chướng ngại vật.
    ![image](https://github.com/thoongnt/se7.3/assets/148628352/283fa726-23e3-4358-9aa6-01a795c3a34b)
  **2. Thu thập vàng và vật phẩm:**
  - Mô tả: Nhân vật phải thu thập vàng và các vật phẩm hỗ trợ như ván trượt, nam châm để giúp trong việc thu thập vàng hoặc vượt qua chướng ngại vật.
  - Hành động: Người chơi điều khiển nhân vật để nhặt vàng và các vật phẩm xuất hiện trên đường.
    ![image](https://github.com/thoongnt/se7.3/assets/148628352/efc6f726-eea2-4e64-a47d-14aed5a03181)
  **3. Mở Khóa Nhân Vật và Mua Vật Phẩm:**
  - Mô tả: Người chơi có thể sử dụng vàng để mở khóa nhân vật mới hoặc mua các vật phẩm hỗ trợ như ván trượt từ cửa hàng trong game.
  - Hành động: Người chơi sử dụng vàng tích lũy được để mua nhân vật hoặc vật phẩm từ cửa hàng.
    ![image](https://github.com/thoongnt/se7.3/assets/148628352/80c55c0f-6f1a-4cfb-9be2-89186277903a)
  **4. Cài Đặt và Tuỳ Chỉnh:**
  - Mô tả: Người chơi có thể điều chỉnh cài đặt như bật/tắt nhạc nền, âm thanh, thay đổi ngôn ngữ hoặc thay đổi độ nhạy của game.
  - Hành động: Người chơi thực hiện các tuỳ chọn trong phần cài đặt của game.
    ![image](https://github.com/thoongnt/se7.3/assets/148628352/1d3ae79d-2762-47ab-a961-324c33627b83)
  **5. Chơi Theo Nhóm và Đua Top Điểm:**
  - Mô tả: Có thể kết nối với bạn bè qua mạng xã hội để thách đấu với họ và cùng nhau chơi trong chế độ nhiều người chơi (online) hoặc so điểm.
  - Hành động: Người chơi kết nối với mạng xã hội hoặc chơi cùng bạn bè qua các chế độ nhiều người chơi.
    ![image](https://github.com/thoongnt/se7.3/assets/148628352/c45df068-4d7c-4c1b-92dd-a3f0cf56fdbe)



# 2. Các sửa đổi cho game
Mô tả chi tiết các sửa đổi trong game, bao gồm hình ảnh, thuyết minh, thuật toán hoặc các Class hay method thêm/sửa/xóa
## 2.1. Tắt box tìm đối thủ
  ![image](https://github.com/thoongnt/se7.3/assets/148628352/37f366b7-2775-4696-b03d-2c0c466d1a78)  
  Trong game, box tìm đối thủ được quản lý bởi một đối tượng gọi là AutoFindOpponentsBox. Trong AutoFindOpponentsBox, có một script được gọi là DeactiveMessageBox.cs, đây chịu trách nhiệm điều khiển hiển thị và ẩn đi box thông báo trạng thái.
  ![image](https://github.com/thoongnt/se7.3/assets/148628352/d6a6c1d4-1653-49a2-915b-4b17976b73f9) ![image](https://github.com/thoongnt/se7.3/assets/148628352/89909d0e-48b0-402d-ab2e-9aa6cb6fc11c)  
Để tắt box thông qua việc nhấn nút ButtonClose, ta cần thêm một hàm mới, chẳng hạn như ButtonCloseMessage(). Hàm này được liên kết với nút ButtonClose và khi được gọi, nó sẽ thực hiện hành động tắt box hiển thị trạng thái bằng cách tương tác với DeactiveMessageBox.cs. Điều này giúp người chơi đóng box một cách dễ dàng khi cần thiết.    
![image](https://github.com/thoongnt/se7.3/assets/148628352/dfb649dc-3957-4c6d-a359-b654587f536c) ![image](https://github.com/thoongnt/se7.3/assets/148628352/248fd586-4bc9-42d0-8172-8c13c6872ef5)  
Hàm này được kích hoạt khi người dùng nhấn vào nút đóng (ButtonClose) trên hộp thoại. Đầu tiên, nó chạy một âm thanh thông báo việc nhấn nút (Module.PlayAudioClipFree). Sau đó, nó sử dụng một Animator để chơi một trigger animation ("TriClose") trên đối tượng này. Điều này thường được sử dụng để kích hoạt một hoạt ảnh đóng hộp thoại.


## 2.2. Thêm chức năng nhập giftcode
  ![image](https://github.com/thoongnt/se7.3/assets/148628352/d990cd28-af4a-416a-8760-87448a641426)
  Trong game phần này được quản lý ở trong đối tượng là ViewAdsGetSkisBox. Trong ViewAdsGetSkisBox, có một script là CooldownSkis.cs chịu trách nhiệm phần hiện thị box và chứa đối tượng GiftCodeManager để xử lý phần nhập giftcode. Trong GiftCodeManager có InputField để nhập mã gift, Button để xác nhận và Text(FeedBackText) đưa ra thông báo về mã vừa nhập.
  ![image](https://github.com/thoongnt/se7.3/assets/148628352/2fa1322e-afae-40fe-803e-1a2785af000c)  
  
  File GiftCodeManager.cs dùng để xử lý quá trình nhập giftcode:  
  ![image](https://github.com/thoongnt/se7.3/assets/148628352/e9a048e8-4390-4268-99d7-6ca4a019dd0e)  
  Dùng để nhập mã gift, xác nhận và đưa ra thông báo.  

  ![image](https://github.com/thoongnt/se7.3/assets/148628352/989e22c4-cdb1-4be1-b6a2-813bf0d67584)  
  
  Dùng để lưu trữ mã giftcode và các mã giftcode đã được sử dụng. Tất cả các mã được lưu trữ ở trong một file txt. Mỗi mã một dòng chứa mã gift, số vàng và số key được ngăn cách bằng dấu ":"    
  ![image](https://github.com/thoongnt/se7.3/assets/148628352/2b2fec51-2182-4cf7-8bdd-41a6d8cc68d8)  

  Xử lý sự kiện khi người chơi gửi một mã quà.  
  Xác thực mã quà nhập với các mã đã lưu trữ:
  - Nếu mã quà hợp lệ và chưa sử dụng, nó sẽ trao thưởng tương ứng (vàng và chìa khóa) cho người chơi.
  - Nếu mã quà không hợp lệ hoặc đã được sử dụng, nó sẽ cung cấp phản hồi phù hợp cho người chơi.

  ![image](https://github.com/thoongnt/se7.3/assets/148628352/1e22e293-d294-4b18-9e6c-ea11a1847e65)  
  ShowFeedback(): Cập nhật văn bản phản hồi để hiển thị thông điệp dựa trên kết quả xác thực mã. ClearFeedbackText(): Xóa văn bản phản hồi sau một khoảng thời gian nhất định (3 giây trong trường hợp này).
## 2.3. Thêm hiệu ứng trời mưa và tuyết
Thêm hiệu ứng trời mưa tại các map C005, C006, C007, C008
Cách làm: 
1.Tạo file Effect trong Asset để lưu hiệu ứng và các thành phần của hiệu ứng.
2.Tạo hiệu ứng trong sence để chỉnh hiệu ứng.
3.Kéo xuống file Effect vừa tạo để lưu lại file hiệu ứng dạng prefab.
4.Thêm kéo hiệu ứng vào các map dạng prefab để lưu hiệu ứng.

## 2.4. Không cho phép sử dụng ván bay trước cửa hầm
Nếu như sử dụng ván bay trước cửa hầm thì sẽ bị bay xuyên nóc do ván bay bay theo đường chéo đi lên. Nếu như đã đi vào trong hầm, hoặc bên trên có mái che, một collider nào đấy thì cũng khóa lại ván bay. Phần này đã được sử lý ở hàm CheckCeintBlock() trong file HeroController.cs  
  ![image](https://github.com/thoongnt/se7.3/assets/148628352/1aaac298-8144-48db-abc8-a04abd46d66e)
Trước tiên, hàm kiểm tra xem trò chơi đang ở trạng thái chơi (StatusGame.play), không phải là trạng thái hướng dẫn (gameGuide không được đặt là "YES"), và không sử dụng bất kỳ bonus nào.  
Sử dụng Raycast để bắn một "tia" từ một điểm cụ thể lên phía trên. Nếu tia chạm vào một collider, điều này có nghĩa là có một vật thể nằm phía trên nhân vật. Hàm sẽ kiểm tra xem collider đó thuộc layer nào. Nếu không thuộc layer mặc định, hàm sẽ cấm việc sử dụng một tính năng sử dụng xe bay. Nếu tia không chạm vào bất kỳ collider nào phía trên, tức là không có vật thể nào chặn, hàm sẽ cho phép việc sử dụng xe bay.  
Nhưng đây là xử lý khi bên trên có vật cản, nếu như không có vật cản thì vẫn sử dụng được xe bay dẫn đến bay xuyên nóc. Cách sử lý ở đây là thêm một box vô hình ở trước cửa hầm, nếu như nhân vật đi vào trong box thì sẽ cấm không cho sử dụng xe bay. 
  ![image](https://github.com/thoongnt/se7.3/assets/148628352/5d77eeb0-99ab-46d0-83a3-3e67ac3375f5)  ![image](https://github.com/thoongnt/se7.3/assets/148628352/97a577e3-1225-4410-8c0f-3beb819aac8f)  
Ta viết thêm hàm OnTriggerStay(Collider collider) để kiểm tra nhân vật có còn ở trong khối startTunner hay không  
  ![image](https://github.com/thoongnt/se7.3/assets/148628352/3bc50848-60b3-407e-ad5d-1a8272f1b64d)  
Nếu như vẫn còn ở trong khối startTunner thì tiếp tục khóa xe bay, không cho sử dụng và ngược lại.

# 2.5. Fix bug đi lên dốc ở tàu
  ![image](https://github.com/thoongnt/se7.3/assets/148628352/7a6340df-ea82-4ff7-be01-43dec5202880)
  Nếu như barrier khác null thì gán collider để xử lý va chạm, không cho nhân vật đi xuyên dốc dẫn đến bug.

# 3. Hướng dẫn Khởi tạo dự án
## 3.1. Cài Unity bản từ 2022 trở đi
Đăng ký tài khoản Unity bằng account sinh viên để có thể tham gia chương trình Education License của Unity

## 3.2. Mở dự án trên Unity và chạy thử ngay trên Màn hình Unity Editor
Vào menu File-> Open Scene, chọn vào file Assets/Scene/LoadData.unity
Bấm nút Play của Unity để chạy thử

## 3.3. Build và chạy trên Android

Vào menu File -> Build Settings, chọn Platform là Android rồi nhấn "Switch Platform" để chuyển sang Android. Sau đó nhấn vào nút Build để thực hiện build ra file APK. Tham khảo trên Google search để biết cách cài đặt Build settings sao cho phù hợp
