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
* Mã nguồn gốc từ Bus và Subway (vẫn có trên Google Play Store), trò chơi là một game chạy vô tận được cung cấp trên nền tảng di động (Android, iOS, v.v.). Trong trò chơi, nhân vật chính sẽ cố chạy trốn thoát khỏi một sĩ quan cảnh sát, chạy trên những đường đua vô tận với nhiều chướng ngại vật khác nhau (như xe buýt , rào chắn ,...). Người chơi có thể rẽ trái hoặc phải , cúi , nhảy, nhảy đôi bằng cách sử dụng vật phẩm hoặc triệu hồi tàu lượn, nhận xu, phần thưởng và bùa lợi cũng như tài nguyên có thể mua bằng tiền thật.Trò chơi có đồ họa 2D đơn giản nhưng bắt mắt, với màu sắc tươi sáng và âm thanh sống động. Lối chơi trò chơi đơn giản nhưng hấp dẫn, đòi hỏi người chơi phải phản ứng nhanh và chính xác để vượt qua chướng ngại vật. Trò chơi có nhiều cấp độ khác nhau với độ khó tăng dần, phù hợp với mọi đối tượng người chơi.
## 1.1. Các kịch bản chơi game
Mô tả chi tiết các kịch bản chơi của game, vd Death war,  Civil war...

## 1.2. Các usecase trong game
Các usecase chính, nhân vật có thể chơi như nào. Cần có hình ảnh đi kèm..
* Các usecase của game Subway Surfers bao gồm:
    Chế độ chơi đơn: người chơi sẽ đóng vai một nghệ sĩ graffiti trẻ tuổi, chạy trốn qua các đường ray tàu điện ngầm, tránh các chướng ngại vật và cố gắng nhặt vàng và các vật phẩm giúp ích để đạt điểm cao.
    Bảng xếp hạng người chơi điểm cao.
    Cửa hàng để mua vật phẩm (key, coin, …) và mua các nhân vật khác.
    Chế độ nhiều người chơi (online).
    Kẻ thù : 1 ông cảnh sát truy đuổi.
    Nhiệm vụ : nhặt các item; thử thách : nhặt các chữ cái.
    Kết nối với Facebook để mời bạn bè chơi cùng, đua top điểm cùng bạn bè,…
    Đổi ngôn ngữ.
    Bật/tắt nhạc nền, âm thanh; điều chỉnh độ nhạy, mức độ các hiệu ứng; thoát game.
* Mục tiêu của game là kiếm nhiều vàng để mở khóa tất cả nhân vật, mua các vật phẩm hỗ trợ để đạt được điểm càng cao càng tốt. Trong game, người chơi có thể tự tạo cho mình mục tiêu chiến thắng như mở khóa hết nhân vật, đạt điểm cao nhất thế giới, hoặc các mục tiêu khác. Các nhiệm vụ, thử thách, các dấu mốc nhỏ trong trò chơi là các mục tiêu tiến trình. Người chơi có thể ăn vàng hoặc hoàn thành nhiệm vụ, thử thách để có các vật phẩm giúp ích cho quá trình chơi. Những thứ khó hoàn thành trong trò chơi là các mục tiêu thử thách.

* Game có hai scene chính: LoadData và Gameplay. Khi vào game, sẽ hiển thị một màn hình chờ để khởi tạo tài nguyên game. Màn hình chờ được thiết kế bằng đồ hoạ 2D nằm trong canvas. Các tài nguyên, script được load trong scene ListResource, Poolterrain, Poolother. Poolterrain gồm các đối tượng khung cảnh, môi trường trong game như cây cối, toà nhà, đường phố,… mà nhân vật chạy. Poolother gồm các coin mà nhân vật nhặt được. ListResource gồm nhân vật, audio,kẻ thù. Các lớp trên thực chất là khởi tạo các đối tượng cần sử dụng nên rất tốn thời gian và tài nguyên. Chúng đều có Dontdestroyonload(mội phương thức của class Objects trong unity giúp các đối tượng không bị loại bỏ khi tải scene) để tiếp tục sử dụng trong scene gameplay.

# 2. Các sửa đổi cho game
Mô tả chi tiết các sửa đổi trong game, bao gồm hình ảnh, thuyết minh, thuật toán hoặc các Class hay method thêm/sửa/xóa
## 2.1 Fix map
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
## 2.2. Thêm features
#### Random tips for players on beginning loading screen
+ Providing a small tip for player at the beginning
+ Currently include 4 permanent tips that generate randomly each time you boot up the game
+ Include some animations
![Alt text](image.png)
+ The tips randomly generate using the TipRandom.cs file :
    - `public class TipRandom : MonoBehaviour`
+ In TipRandom we have an Enumerator function to display different tips:
    - `IEnumerator tipTracker(){
        while(true){
        randNum = Random.Range(1,4);
        if(randNum ==1){
            tipDisplay.GetComponentInChildren<Text>().text = " Remember to upgrade your items !";
        }
        if(randNum ==2){
            tipDisplay.GetComponentInChildren<Text>().text = " Daily rewards resets every 24 hours !";
        }
        if(randNum ==3){
            tipDisplay.GetComponentInChildren<Text>().text = " There are secret areas filled with treasures !";
        }
        if(randNum ==4){
            tipDisplay.GetComponentInChildren<Text>().text = " If you trip twice , the officer will catch up to you !";
        }
        tipDisplay.GetComponent<Animator>().Play("Tips");
        yield return new WaitForSeconds(6);
        genhint = false;
        }
        `
    + When we begin this coroutine, Unity display the randomized number in the inspector and the tip in the UI with the Text GameObject.
    ![Alt text](image-1.png)
+ When displaying the tip, an animation will play every 60 frames, simply appearing and disappearing.
+ The animation is stored in TextTip.anim
    ![Alt text](image-2.png)
#### Daily Reward system
+ You can receive a 500 coins reward every 24 hours in real time
+ Added new button to receive daily reward : 
![Alt text](image-3.png)
+ Daily reward panel :
![Alt text](image-4.png)
+ After claiming reward , the claim button turns gray and cannot be clicked until time limit ends.
  

# 3. Hướng dẫn Khởi tạo dự án
## 3.1. Cài Unity bản từ 2022 trở đi
Đăng ký tài khoản Unity bằng account sinh viên để có thể tham gia chương trình Education License của Unity

## 3.2. Mở dự án trên Unity và chạy thử ngay trên Màn hình Unity Editor
Vào menu File-> Open Scene, chọn vào file Assets/Scene/LoadData.unity
Bấm nút Play của Unity để chạy thử

## 3.3. Build và chạy trên Android
Vào menu File -> Build Settings, chọn Platform là Android rồi nhấn "Switch Platform" để chuyển sang Android. Sau đó nhấn vào nút Build để thực hiện build ra file APK. Tham khảo trên Google search để biết cách cài đặt Build settings sao cho phù hợp
