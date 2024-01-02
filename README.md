# se7.2
Lập trình game với Unity #3

# SUBWAY SUFFER 
Lập trình game casual thể loại subway surfers.

**Thành viên nhóm:**
1.Nguyễn Mai Phương  21000200
2.Lò Thị Trang       21001592 (Leader)
3.Bùi Minh Vũ        21001600
4.Lê Minh Vũ         21001601
# 1. Mô tả game
Mô tả cô đọng trong 5-10 dòng

## 1.1. Các kịch bản chơi game
Mô tả chi tiết các kịch bản chơi của game, vd Death war,  Civil war...

## 1.2. Các usecase trong game
Các usecase chính, nhân vật có thể chơi như nào. Cần có hình ảnh đi kèm..

# 2. Các sửa đổi cho game
Mô tả chi tiết các sửa đổi trong game, bao gồm hình ảnh, thuyết minh, thuật toán hoặc các Class hay method thêm/sửa/xóa
## 2.3. Thay đổi 1
## 2.4. Sửa lỗi
- Nhân vật rơi khỏi thế giới khi đi lên đường hầm
Vào Assets\ResourcesGame\Prefabs\Terrains tìm những terrains có đường đi lên hầm (B005, B007, C005, C008, D013, D016) có những object là RoadCM
Thêm component BarrielInfomation.cs vào RoadCM với các settings:

SuportSkis : true

TypeBarriel : NevelFall

TypeFalling : Back

NeverDestroy : true

![Screenshot 2024-01-03 002339](https://github.com/Trangitg/se7.2/assets/93517130/0415fc4f-8511-40e3-89b4-d25b92e460c1)

- Lỗi không tắt được box Find Opponent
Vào Assets\Scripts\OtherPage\DeactivateMessageBox.cs và thêm hàm ButtonCloseMessage()
![Screenshot 2024-01-03 003532](https://github.com/Trangitg/se7.2/assets/93517130/cc18a8fb-8ac5-40d4-afc6-e1e7989c9705)

Sau đó vào Assets\Scenes\GameMain.unity
Trong phần Hierarchy, Vào GameMain\ContainGameMain\Canvas\FormGameMenu\MessageBox\AutoFindOpponentBox\AllContents\ButtonClose
Tại Component Button, Thêm Script AutoFindOpponentBox vào hàm On Click () và chọn function ButtonCloseMessage()
![Screenshot 2024-01-03 003905](https://github.com/Trangitg/se7.2/assets/93517130/e45ddf1d-2024-4cd3-ad05-91dbaecafaf3)

# 3. Hướng dẫn Khởi tạo dự án
## 3.1. Cài Unity bản từ 2022 trở đi
Đăng ký tài khoản Unity bằng account sinh viên để có thể tham gia chương trình Education License của Unity

## 3.2. Mở dự án trên Unity và chạy thử ngay trên Màn hình Unity Editor
Vào menu File-> Open Scene, chọn vào file Assets/Scene/LoadData.unity
Bấm nút Play của Unity để chạy thử

## 3.3. Build và chạy trên Android

Vào menu File -> Build Settings, chọn Platform là Android rồi nhấn "Switch Platform" để chuyển sang Android. Sau đó nhấn vào nút Build để thực hiện build ra file APK. Tham khảo trên Google search để biết cách cài đặt Build settings sao cho phù hợp

