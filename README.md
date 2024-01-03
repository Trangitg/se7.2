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
 Các khu vực nhân vật chạy và khám phá:
  - Ai cập cổ: Cảnh quan với các kim tự tháp, sa mạc, và những di tích cổ xưa.
  - Ngoại ô thành phố: Khu vực ngoại ô với các nhà cửa, công viên và đường phố nhỏ.
  - Cầu: Chạy trên một chiếc cầu sắt bắc qua sông.
  - Nhà ga xe lửa: Gần các nhà ga với các đoạn đường tàu và tàu hỏa chạy qua.
  - Thành phố: Khu vực trung tâm với những tòa nhà cao tầng và xe bus.
  - Bãi biển: Cảnh đẹp với cát trắng, biển xanh.

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
* Scene LoadData: Khi vào game sẽ hiển thị một màn hình chờ để khởi tạo tài nguyên game. Màn hình chờ được thiết kế bằng đồ hoạ 2D nằm trong canvas. Các tài nguyên, script được load trong scene ListResource, Poolterrain, Poolother.
  - Poolterrain gồm các đối tượng khung cảnh, môi trường trong game như cây cối, toà nhà, đường phố,... mà nhân vật chạy.
  - Poolother gồm các coin mà nhân vật nhặt được.
  - ListResource gồm nhân vật, audio,kẻ thù.
  Các lớp trên thực chất là khởi tạo các đối tượng cần sử dụng nên rất tốn thời gian và tài nguyên. Chúng đều có Dontdestroyonload(mội phương thức của class Objects trong unity giúp các đối tượng không bị loại bỏ khi tải scene) để tiếp tục sử dụng trong scene gameplay.
  ![image](https://user-images.githubusercontent.com/91232320/219077884-4ebaf451-8526-4ad0-8f8f-2fb2ba7c4dab.png)
  ![image](https://user-images.githubusercontent.com/91232320/219078084-d31c35a5-48a7-4d9e-a9e7-68a4cee02027.png)
  ![image](https://user-images.githubusercontent.com/91232320/219078398-64f23e67-c665-451c-913b-1945
* Ui trong unity được thiết kế bằng canvas. Mọi unity thì đều nằm trong lớp canvas và unity hỗ trợ rất tốt Ui bằng nhiều chức năng, lựa chọn thiết kế cho người dùng. Trong game có một vài Ui quan trọng như màn hình loadgame(đã nói ở trên), màn hình menu trong scene maingame(FormGameMenu), FormGameplay, FormGameMenu, ContainAchievement, ContainShopItem, ...
* Ui FormGameMenu: Menu hiện thị tất cả các feature của game. Người chơi có thể lựa chọn nhân vật, mua item trong shop, kiểm tra nhiệm vụ, chỉnh sửa một số cài đặt game,...
![image](https://user-images.githubusercontent.com/91232320/219078791-4c994307-4651-41d9-9ff1-993cbe5d6405.png)
* Ui FormGamePlay: Một Ui hiển thị trong màn hình chơi game. Ui này hiển thị vật phẩm có thể dùng, số vàng kiểm được, số điểm hiện tại, phím dừng game, ...
![image](https://user-images.githubusercontent.com/91232320/219078940-be9439a4-246d-4d1f-bd15-8f269ed17cfa.png)
* Ui ContainAchievement: Hiển thị bảng điểm sau khi thua bao gổm điểm số chơi được, vàng kiếm được,... và một hoạt ảnh nhân vật thua game. Tuy nhiên do đã bỏ phần facebook và chplay cùng một số tính năng thưởng khác liên quan đến quảng cáo nên phần này chỉ đơn giản là xử lí điểm số và nhân vật.
![image](https://user-images.githubusercontent.com/91232320/219079293-78a69969-39a2-4b9b-8713-0172348b7a4b.png)
* Nhân vật có thể trườn, nhảy, tránh né bằng cách di chuyển sang bên trái và phải.
    ![11](https://github.com/Trangitg/se7.2/assets/119964656/b9110525-afe2-4fc8-b062-4485224873f1)
    Nhân vật chỉ được di chuyển trong 3 lane như hình. Lúc xuất phát, nhân vật luôn xuất phát ở lane giữa
    Một số chướng ngại vật mà người chơi sẽ gặp phải:
    ![22](https://github.com/Trangitg/se7.2/assets/119964656/a685278c-3cfe-41b0-94ee-a7ae6f549b66)
    ![33](https://github.com/Trangitg/se7.2/assets/119964656/3963259d-a012-4600-b553-1b74e6d65e0e)
    ![44](https://github.com/Trangitg/se7.2/assets/119964656/8371c650-9604-4234-bc7c-2df9dc4c028c)
    ![55](https://github.com/Trangitg/se7.2/assets/119964656/35c2f62b-6845-4309-89dd-d4729c2e53c0)
    Từ đầu game, người chơi sẽ bị một security rượt đuổi. Nếu người chơi đâm vào đầu tàu, barie hay bị bảo vệ bắt được sẽ ngay lập tức dừng màn chơi lại. Một hộp lựa chọn sẽ hiện ra
    ![66](https://github.com/Trangitg/se7.2/assets/119964656/316397a7-a70a-4cc6-8979-9cd120cc7be2)
    Người chơi có quyền sử dụng chìa khóa để hồi sinh, hoặc share video quá trình mình chơi lên các nền tảng mạng xã hội. Hết thời gian chờ, bảng Top Run hiện lên show số điểm, số coin thu được và số hạng trong bảng xếp hạng
    Người chơi có thể gặp các vật phẩm đặc biệt nằm trên đường chạy, như chùm bong bóng, ván trượt, thanh nam châm,…
    Có 6 vật phẩm nhặt giữa đường chạy mà chúng ta có thể nâng cấp:  
    
    ![77](https://github.com/Trangitg/se7.2/assets/119964656/a06866ac-f608-4090-9cd8-962ac6a918b5)
    Nếu nhân vật chết hay trạng thái showScorePlay thì tạo một clone nhân vật. Clone này không có rigid body với model là arrested để hiện thị trạng thái thua game.
 Nếu được mở ở màn hình menu thì chuyển animation nhân vật sang idleMenu và hiển thị điểm số cao nhất của người chơi.
 Nếu ấn play thì tạo trận chơi mới.
 ![image](https://user-images.githubusercontent.com/91232320/219079528-3cb11e5f-923d-4c7e-ab80-5145df866b1e.png)

* Kẻ thù trong game được thiết kế trong file EnemyCOntrollers.cs.
 - Một số đặc tính của kẻ thù:
   - Không bị ảnh hưởng bởi thanh chắn như nhân vật.
   - Sẽ đi theo và nhại theo hoạt ảnh nhảy của nhân vật.
   - Sử dụng hàm update để xử lí khi người chơi tạo ra các sự kiện:
     - Khi khởi đầu game từ màn hình menu sẽ có trạng thái nghỉ(idle) và hiện hoạt ảnh tuy nhiên camera chính không chiếu vào nên người chơi sẽ không thấy. khi ấn nút start kẻ thù sẽ mặc định tiến gần tới nhân vật(gọi hàm MoveNearFarFollow)
     - Sẽ chạy chậm hơn nhân vật một khoảng và sau khi chạy một thời gian mà người chơi không vấp phải các chướng ngại nhỏ hay bị va đập với tường khi người chơi cố tình hay vô ý lướt quá sang trái hay phải khi đừng cạnh rìa, sẽ lùi xa một khoảng(gọi đến hàm RunMoveNearFarFollow) và rơi vào trạng thái nghỉ(idle) và ẩn hoạt ảnh.
     - Khi người chơi bị vấp phải các chướng ngại nhỏ sẽ tiến gần vào nhân vật(gọi đến hàm MoveNearFarFollow) và nếu người chơi vấp tiếp vào các chướng ngại nhỏ thì người chơi sẽ thua, sẽ có thêm hoạt ảnh "attack" bắt nhân vật.
    ![image](https://user-images.githubusercontent.com/91232320/219077465-b4835e52-f046-469b-a75d-9f3cc93d0ff0.png)


* Mua vật phẩm và nâng cấp item trong ShopItem: class PageShopItems.cs

    - Mua vật phẩm: 
        + Mua Coin:
       ![image](https://user-images.githubusercontent.com/117577336/219059497-290d418a-aabc-460f-ab02-99186f64261c.png)

        + Mua Keys:
        ![image](https://user-images.githubusercontent.com/117577336/219059581-39159a06-1210-4996-ac6c-d9d435ae7f67.png)

        + Mua vật phẩm sử dụng 1 lần:
        ![image](https://user-images.githubusercontent.com/117577336/219059704-f87d0586-0782-4448-b261-85b1ff370e01.png)


  Class BuyItemController.cs: để lấy ra số lượng item đang có rồi gán số lượng ra Text Total để hiển thị cho người dùng số lượng item đang có bằng các ngôn ngữ khác nhau. Code item là: 0 coin, 1 key, 2 skis, 3 mysteryBox, 4 headStart, 5 scoreBooster
            ![image](https://user-images.githubusercontent.com/117577336/219060192-9a1e4531-a7f6-41c3-9602-2fd459e7ffa1.png)
            ![image](https://user-images.githubusercontent.com/117577336/219060344-62cd37b1-44a4-4981-9800-70e50fae81d3.png)

  Class ButtonBuyItem.cs: Xử lý mua vật phẩm khi click mua. 
   Code item là: 0 coin, 1 key, 2 skis, 3 mysteryBox, 4 headStart, 5 scoreBooster.
   ![image](https://user-images.githubusercontent.com/117577336/219060652-081a8f5c-310d-4b3d-8353-8ff6e7ebd2dc.png)
Biến textCost: lấy giá tiền của vật phẩm được tạo ở giao diện để thực hiện mua item, 
![image](https://user-images.githubusercontent.com/117577336/219060901-3cf00b45-a14d-44ed-a6d9-469daebd7754.png)
biến textNote: để trả lại số lượng vật phẩm sau khi mua, 
![image](https://user-images.githubusercontent.com/117577336/219060990-777d7038-6927-4369-8ad1-3e7aa962cb84.png)
biến textCoin: để trả lại số lượng coin còn lại sau khi mua.
![image](https://user-images.githubusercontent.com/117577336/219061112-c3d3f5c1-37f0-4dfa-b63c-8c3d8dbfdaa5.png)
 Nếu Code item là: 0 coin, 1 key thì xử lý trong app purchase
                
Nếu Code item là: 2 skis, 4 headStart, 5 scoreBooster: 
![image](https://user-images.githubusercontent.com/117577336/219061363-a2580a11-7b14-4ebb-80dc-8897653b7650.png)

                    Nếu số tiền hiện tại > giá tiền vật phẩm
                        Nếu số lượng item hiện tại < số lượng item tối đa(Trong Modules.cs: maxHoverboard = 9999; maxHeadstart = 10; maxScorebooster = 7;)
                            Số lượng item hiện có + 1
                            Trừ số coin hiện tại bằng textCost và trả lại giá trị coin hiện tại là textCoin
                            Trả lại số lượng item hiện có textNote
                        Nếu số lượng item hiện tại = số lượng item tối đa
                            textNote in ra thông báo lỗi maximumNumber 
                    Nếu không đủ tiền 
                        textNote in ra thông báo lỗi không đủ tiền
Nếu Code item là: 3 mysteryBox
![image](https://user-images.githubusercontent.com/117577336/219061450-ea175dec-dda6-4ca5-9c28-5378c28d8195.png)

                    Nếu số tiền hiện tại > giá tiền vật phẩm
                        Trừ số coin hiện tại bằng textCost và trả lại giá trị coin hiện tại là textCoin
                        Di chuyển đến PageOpenBox hoạt ảnh mở hộp   
                    Nếu không đủ tiền 
                        textNote in ra thông báo lỗi không đủ tiền
![image](https://user-images.githubusercontent.com/117577336/219061352-e47c83c3-f03b-47d2-9984-e4a7c37dd991.png)

- Nâng cấp item (Tăng thời gian sử dụng item): 
 Class UpgradesController.cs: để tính giá tiền để nâng cấp item của mỗi level rồi in ra textCost. Code item là: 0 rocket, 1 power, 2 magnet, 3 2x, 4 cable, 5 skis. 
![image](https://user-images.githubusercontent.com/117577336/219061740-ad1f79aa-95c9-4b4a-9e3e-f061d68344fb.png)
![image](https://user-images.githubusercontent.com/117577336/219061853-01d1eb0e-f0f6-4f77-85c3-8dd6c70dc92f.png)

                Giá tiền được tính bằng: money = 250 * Mathf.Pow(2, (level item + 1))
                Nếu giá tiền hiện tại > 256000 thì giá tiền = 256000

 Class ButtonUpgradesItem.cs: Xử lý mua vật phẩm khi click mua. 
Code item là: 0 rocket, 1 power, 2 magnet, 3 2x, 4 cable, 5 skis
    ![image](https://user-images.githubusercontent.com/117577336/219062013-fb8b4827-7a27-4c5a-ae71-d819db14ebef.png)

         Biến progressBox: để hiển thị hình ảnh thanh level của item, biến textCost: lấy giá tiền của vật phẩm được tạo ở giao diện để thực hiện mua nâng cấp,
![image](https://user-images.githubusercontent.com/117577336/219062721-b64bebdc-edf8-4f91-ba20-3ea2157bc532.png)

        biến textNote: in ra thông báo nếu lỗi, 
![image](https://user-images.githubusercontent.com/117577336/219062872-826d152a-90d8-4e99-8369-a710b90877b9.png)
 
        biến textCoin: để trả lại số lượng coin còn lại sau khi mua.
![image](https://user-images.githubusercontent.com/117577336/219062954-6e54d9a1-dcc2-4a13-80fc-3915f5ebbb32.png)

                    Nếu số tiền hiện tại > giá tiền nâng cấp
                        Nếu level item hiện tại < level item item tối đa(Trong Modules.cs: maxLevelItem = 10)
                            Tăng level item lên 1
                            Trừ số coin hiện tại bằng textCost và trả lại giá trị coin hiện tại là textCoin
                            Update lại giá tiền nâng cấp item trong UpgradesController.cs
                        Nếu level item hiện tại = level item item tối đa
                            textNote in ra thông báo lỗi shopMaxLevel 
                    Nếu không đủ tiền 
                        textNote in ra thông báo lỗi không đủ tiền
![image](https://user-images.githubusercontent.com/117577336/219063251-75832f40-e1bd-4517-9eab-cf1f66587887.png)

                

* Mua Hero và Skis:
![image](https://user-images.githubusercontent.com/117577336/219064482-1029ee1e-239b-46c6-9f77-02e6b02e53fa.png)

    - Class ListCharacterUse.cs: danh sách các nhân vật và ván trượt trước khi load game
![image](https://user-images.githubusercontent.com/117577336/219064618-40febce4-5a9e-45f6-91e3-5747549f7b76.png)
![image](https://user-images.githubusercontent.com/117577336/219064718-e6e38e17-5592-43d6-b059-ea3f61085b3e.png)

    - Class ChangeImageClick.cs: Hiệu ứng chiễu đền và tạo ra các clone khi click vào nhân vật trong List nhân vật
    ![image](https://user-images.githubusercontent.com/117577336/219065373-76880fa6-5087-4361-9b6c-8b4d43c0a925.png)

    - Class HeroConstruct.cs: Tạo thanh cuộn danh sách các nhân vật và ván trượt tuần tự để người chơi chọn. 
    ![image](https://user-images.githubusercontent.com/117577336/219065497-f8fe6182-789b-477d-b779-fe2be0c9a865.png)

        Phương thức ButtonCoinHeroClick() để mua nhân vật: 
        ![image](https://user-images.githubusercontent.com/117577336/219066005-8728acb5-5ba7-4db9-9f32-3f7475f4d5f8.png)

            Nếu nhân vật được chọn chưa unlock:
                Nếu số tiền hiện tại > giá tiền mua nhân vật
                    Trừ số coin hiện tại bằng giá tiền nhân vật và trả lại giá trị coin hiện tại là textCoin
                    Text giá tiền chuyển thành SELECTED
                    Thêm nhân vật vào danh sách nhan vật đã unlock
                    Nhân vật sử dụng hiện tại chuyển thành nhân vật đã chọn
                Nếu không đủ tiền 
                    In ra thông báo lỗi không đủ tiền
            Nếu nhân vật được chọn đã unlock:
                Text giá tiền chuyển thành SELECTED  
                Nhân vật sử dụng hiện tại chuyển thành nhân vật đã chọn

        Phương thức ButtonCoinSkisClick() để mua ván trượt: 
        ![image](https://user-images.githubusercontent.com/117577336/219066056-846240a5-74e6-4293-8453-2fed1fc70ce9.png)

            Nếu ván trượt được chọn chưa unlock:
                Nếu số tiền hiện tại > giá tiền mua ván trượt
                    Trừ số coin hiện tại bằng giá tiền ván trượt và trả lại giá trị coin hiện tại là textCoin
                    Text giá tiền chuyển thành SELECTED
                    Thêm ván trượt vào danh sách ván trượt đã unlock
                    Ván trượt sử dụng hiện tại chuyển thành ván trượt đã chọn
                Nếu không đủ tiền 
                    In ra thông báo lỗi không đủ tiền
            Nếu ván trượt được chọn đã unlock:
                Text giá tiền chuyển thành SELECTED  
                Ván trượt sử dụng hiện tại chuyển thành ván trượt đã chọn
        

* Xử lý nếu va chạm items
    - Nếu là đồng xu
        + Tăng coin thêm 1
     ![image](https://user-images.githubusercontent.com/117577336/219072403-4c60de81-87bb-4e68-9a05-3b2bc7ffa342.png)

    - Nếu là key
        + Tăng key thêm 1
        ![image](https://user-images.githubusercontent.com/117577336/219072686-9e61e2f3-6291-4dbd-8eba-fef0e4a05c2e.png)

        
    - Nếu là skis
    ![image](https://user-images.githubusercontent.com/117577336/219072854-3235a21e-b329-4dba-9bdc-6e211874de41.png)

        + Tăng skis thêm 1
            Nếu tổng số Skis hiện tại > maxHoverboard = 10
                số Skis hiện tại = maxHoverboard = 10;
    
    - Nếu là giày
    - ![image](https://user-images.githubusercontent.com/117577336/219072978-b710fe4f-6094-4cd9-962e-f89a26094c16.png)
        + Nếu chưa sử dụng giày
            Set Model sử dụng giày trên nhân vật
        + Sử dụng giày thành true
        + Thêm bảng hiển thị thời gian sử dụng item
      ![image](https://user-images.githubusercontent.com/117577336/219073325-7a121ffc-3128-4bab-adb3-1ca0f1501a69.png)

        
    - Nếu là headStart
     ![image](https://user-images.githubusercontent.com/117577336/219073474-aad3b0ae-023b-4003-9810-0eab6328ead2.png)
        + Tăng headStart thêm 1
            Nếu tổng số headStart hiện tại > maxHeadstart = 10
                số headStart hiện tại = maxHeadstart = 10;
    
    - Nếu là mysteryBox
     ![image](https://user-images.githubusercontent.com/117577336/219073598-1dd5dd49-612e-40e0-8f3f-d00c45d9a2ad.png)
        + Tăng mysteryBox thêm 1
        
    - Nếu là nam châm
    ![image](https://user-images.githubusercontent.com/117577336/219073914-07f1965c-9457-4693-a268-18d2f5a1eee3.png)

        + Nếu chưa sử dụng nam châm 
            thêm model sử dụng nam châm trên nhân vật
            ![image](https://user-images.githubusercontent.com/117577336/219074221-d8f9e063-49ad-448f-b17f-fbe786aea112.png)
        + Thêm bảng hiển thị thời gian sử dụng item
![image](https://user-images.githubusercontent.com/117577336/219074333-3e06c6a4-d293-429d-bd7e-88a30aaed61e.png)

        + Sử dụng nam châm thành true 
        + SetAniAddMagnet(): Set các loại di chuyển khi ăn nam châm :
            Nếu đang chạy thường: chuyển kiểu chạy thành runMagnet; 
![image](https://user-images.githubusercontent.com/117577336/219074221-d8f9e063-49ad-448f-b17f-fbe786aea112.png)
            Nếu đang trượt ván:  chuyển kiểu chạy thành runSkisMagnet; 
![image](https://user-images.githubusercontent.com/117577336/219075112-7fa9654d-5d72-4cda-9f40-e0b8e1d56a0b.png)
            Nếu đang bay tên lửa:  chuyển kiểu chạy thành runRocketMagnet; 
![image](https://user-images.githubusercontent.com/117577336/219075913-c225499d-514a-4615-8eaa-f4562eaeaffa.png)
            Nếu đang bay cable: chuyển kiểu chạy thành runCableMagnet; 
![image](https://user-images.githubusercontent.com/117577336/219076663-5a2f7410-1c54-43ab-a157-9e28a824ee97.png)

    - Nếu là rocket
        + Nếu chưa sử dụng rocket 
![image](https://user-images.githubusercontent.com/117577336/219076781-3360363a-ed86-4055-97f6-962c8190a866.png)

            thêm model sử dụng rocket trên nhân vật
        + Khoảng cách với Enemy = 2 
        + Sử dụng rocket thành true  
        + Thêm bảng hiển thị thời gian sử dụng item  
![image](https://user-images.githubusercontent.com/117577336/219076820-6b630f18-72d0-49ff-b786-1a1ece84d303.png)
        + Kích hoạt hiệu ứng của item bay trên không;
        + SetAniAddRocket(): 
       Nếu đang sử dụng cable: Sử dụng Cable = false;
       Nếu đang jumper: Sử dụng Jumper = false;
       Nếu đang sử dụng nam châm chuyển kiểu chạy thành runRocketMagnet;
![image](https://user-images.githubusercontent.com/117577336/219075913-c225499d-514a-4615-8eaa-f4562eaeaffa.png)
            Những trường hợp còn lại chuyển kiểu chạy thành runRocket;
![image](https://user-images.githubusercontent.com/117577336/219076781-3360363a-ed86-4055-97f6-962c8190a866.png)
             

    - Nếu là jumper
        + Khoảng cách với Enemy = 2 
        + Sử dụng jumper thành true  
![image](https://user-images.githubusercontent.com/117577336/219084247-bde88b39-dc23-4d94-b3aa-58fb43df0c7e.png)

        + Kích hoạt hiệu ứng của item bay trên không;
        + SetAniAddJumper(): 
            Remove Progress sử dụng jetpack
            Remove Progress sử dụng hoverbike
            Ẩn đối tượng Skis khi sử dụng item jumper
            Nếu đang sử dụng cable
                RemoveCableItem(false)
            Nếu đang sử dụng cable
                RemoveJumperItem(false);
           

    - Nếu là cable
        + Nếu chưa sử dụng cable: thêm model sử dụng cable trên Hero
        + Khoảng cách với Enemy = 2 
            Sử dụng Cable = true;
        + Kích hoạt hiệu ứng của item bay trên không;
  ![image](https://user-images.githubusercontent.com/117577336/219084652-e0438746-2712-4585-a6cd-e85c7f6795b3.png)

        + SetAniAddCable()  
            Remove Progress của item jetpack
            Ẩn đối tượng Skis khi sử dụng item cable
            Nếu đang sử dụng rocket 
                Sử dụng Rocket = false;
            Nếu đang sử dụng jumper
                Sử dụng Jumper = false;
            Nếu đang sử dụng nam châm: chuyển kiểu chạy thành runCableMagnet;
![image](https://user-images.githubusercontent.com/117577336/219085065-b06c2657-31fc-4d46-a382-509d33a1f7b5.png)
            Những trường hợp còn lại:  chuyển kiểu chạy thành runCable;
 ![image](https://user-images.githubusercontent.com/117577336/219084652-e0438746-2712-4585-a6cd-e85c7f6795b3.png)
         

    - Nếu là balloon
    ![image](https://user-images.githubusercontent.com/117577336/219078045-f06677a9-de2c-4f8c-b508-b46a7dc02b17.png)

        + Remove hiệu ứng item bay
        + Thiết lập lại trang thái:không thể di chuyển sang trái phải
        ![image](https://user-images.githubusercontent.com/117577336/219078303-87294b82-fce0-4181-9c47-46a0e8aeb23c.png)

        + Khoảng cách với Enemy = 2 
        + SetAniAddBalloon():
            Remove Progress của item jetpack
            Remove Progress của item hoverbike
            Ẩn đối tượng Skis khi sử dụng item Skis
            Nếu đang sử dụng cable
                Sử dụng Cable = false;
            Nếu đang sử dụng rocket 
                Sử dụng Rocket = false;
            Nếu đang sử dụng jumper
                Sử dụng Jumper = false;
        + SetAniAfterFall(): sau khi tiếp đất 
![image](https://user-images.githubusercontent.com/117577336/219079093-345914a5-cd71-467e-b35b-887ac067f29d.png)

            Nếu đang sử dụng skis
                Nếu đang sử dụng nam châm
                chuyển kiểu chạy thành runSkisMagnet;
![image](https://user-images.githubusercontent.com/117577336/219079254-b8a7b66a-fae1-4e89-bd0e-a41ce63badb0.png)

                Nếu không sử dụng nam châm
                chuyển kiểu chạy thành runSkis;
![image](https://user-images.githubusercontent.com/117577336/219079631-975ab5de-145b-4f76-98a9-ada8ac616432.png)

            Những trường hợp còn lại: 
            Nếu đang sử dụng nam châm
            chuyển kiểu chạy thành runMagnet;
![image](https://user-images.githubusercontent.com/117577336/219079815-8f96fbab-8d41-4d0e-8e88-43458c129220.png)

            Nếu không sử dụng nam châm
              chuyển kiểu chạy thành runNormal;  
![image](https://user-images.githubusercontent.com/117577336/219079407-5062e654-fd6e-452c-9b63-9c8e0293cb1b.png)

            + Hủy bỏ sử dụng Animation sử dụng balloon 
        + Reset lại toàn bộ item trên map    
    
    - Nếu là scoreBooster
![image](https://user-images.githubusercontent.com/117577336/219077735-460b8e74-1c6b-4902-a7e5-1170b96cefc0.png)

        + số ScoreBooster hiện tại +1
        + Nếu số ScoreBooster hiện tại > maxScorebooster = 7
            thì số ScoreBooster hiện tại  = maxScorebooster = 7
*  Bật/tắt nhạc nền, âm thanh; điều chỉnh độ nhạy, mức độ các hiệu ứng; thoát game:
    - Trong các lớp xử lý công việc liên quan đến âm thanh, thường có hàm PlayAudioClipFree() để xử lý dãn cách âm thanh, ko cho âm thanh chạy quá sát.
    ![image](https://user-images.githubusercontent.com/30952488/219052724-bce1c8ed-38d5-4931-bf7f-ce013d30a3b9.png)
    - Lớp MessageSetting.cs gọi hàm StartShowMessage() để hiện ra bảng setting.
    ![image](https://user-images.githubusercontent.com/30952488/219054450-e6ea9bad-27dd-4841-8d14-26b366744b54.png)
    ![image](https://user-images.githubusercontent.com/30952488/219052940-a64258c3-d29f-4be9-9e03-9d2727e831d0.png)
    - Bật tắt nhạc nền: 
        + ButtonVolumeBGClick() được gọi khi ta ấn vào nút:
            Thay đổi giá trị volumeBackground từ 0 thành 1 hoặc từ 1 thành 0 tùy thuộc vào giá trị ban đầu. Song song đó là đổi chữ "On" thành "Off" hoặc "Off" thành "On"
            Sau đó, vẫn cho chơi nhạc bằng hàm PlayAudioLoop() nhưng tùy vào vomlumeBackground mà ta sẽ nghe thấy nhạc hoặc không. Và lưu lại cài đặt bằng SaveSettingValue()
            ![image](https://user-images.githubusercontent.com/30952488/219053102-cd1b0b10-4a52-412e-acdb-397229a650c7.png)
    - Bật tắt âm thanh khi nhấn nút :
        + ButtonVolumeATClick() được gọi khi ta ấn nút: 
            Tương tự như bật tắt nhạc nền nhưng ko cho chơi nhạc bằng hàm PlayAudioLoop().
            ![image](https://user-images.githubusercontent.com/30952488/219053229-55d6a384-9344-4435-be10-6ceaa4dc166f.png)
    - Điều chỉnh mức độ các hiệu ứng:
        + ButtonReducedEffect() được gọi khi ta ấn nút:   
            Thay đổi giá trị reducedEffect từ 2 thành 1 hoặc 1 thành 0 hoặc 0 thành 2 và đổi giá trị text tương ứng High->Medium,Medium->Low,Low->High. Lưu lại cài đặt bằng SaveSettingValue().
            ![image](https://user-images.githubusercontent.com/30952488/219053285-c24fc108-f41d-417d-8a54-4965243a72d4.png)
    - Điều chỉnh độ nhạy:
        + SliderSensivity() được gọi khi ta di chuyển thanh:
            gọi hàm UpdateValueSensivity() trong lớp Modules để chỉnh độ nhạy. Và lưu lại cài đặt bằng hàm SaveSettingValue().
            ![image](https://user-images.githubusercontent.com/30952488/219053348-2e152148-945f-41de-8579-40489b6da56e.png)
    - Thoát game: 
        + gọi đến hàm ButtonQuitGame() khi ta nhấn nút "Quit Game":
            thoát khỏi ứng dụng bằng lệnh Application.Quit().
            ![image](https://user-images.githubusercontent.com/30952488/219053431-266ce639-ad53-4985-95c5-8eb566a01ff7.png)

* Đổi ngôn ngữ : 
    - Khi nhấn nút thì lớp MessageListLanguage sẽ gọi hàm StartShowMessage() để hiện lên bảng thông báo các ngôn ngữ có thể đổi và cờ của các nước như là nút ấn.
    ![image](https://user-images.githubusercontent.com/30952488/219054234-ce42beb7-9d4a-40ea-86da-91ba1b628b79.png)
    - Nếu muốn thay đổi thì chọn cờ nước tương ứng, khi đó ta sẽ gọi hàm ChangeLanguage() với tham số là số nguyên biểu diễn ngôn ngữ mà ta đã chọn :
            public void ChangeLanguage(int indexLang)
        {
            Modules.indexLanguage = indexLang;
            Modules.SaveSettingValue();  
            settingBox.GetComponent<MessageSetting>().StartShowMessage();
            pauseBox.GetComponent<MessagePauseGame>().UpdateLanguages();
            Camera.main.GetComponent<PageMainGame>().ChangeAllLanguage();
            CloseListLanguage();
        }
    - Đầu tiên, biến chứa ngôn ngữ mặc định trong Modules sẽ được thay bằng ngôn ngữ ta nhập. Sau đó, được lưu lại bằng hàm SaveSettingValue(). Và settingBox sẽ được hiện lên lại với câu lệnh settingBox.GetComponent<MessageSetting>().StartShowMessage() với ngôn ngữ mới. Tiếp đến là hộp thoại pause game khi đang chơi được cập nhật ngôn ngữ mới. Và cuối cùng là các thành phần còn lại (các cửa sổ, các màn hình khác,... ) được cập nhật ngôn ngữ mới.
    
    
* Xử lý va chạm
    - Nếu đang sử dụng Jumper, Rocket, Cable: thì không bị va chạm
    ![image](https://user-images.githubusercontent.com/117577336/219069376-8f0cd6a6-2202-4fa2-9d40-deef0510cf62.png)

    - Va chạm với vật cản đằng trước
        + Xử lý nếu có ván trượt thì không chết
            Nếu đang sử dụng skis: Thực hiện xóa tất cả vật cản xung quanh khu vực này này
    ![image](https://user-images.githubusercontent.com/117577336/219069701-50cf07a5-b374-4211-acbf-12d736cdfb23.png)

        + Nếu không sử dụng skis: Bị chết do va chạm với vật cản typeFalling
  ![image](https://user-images.githubusercontent.com/117577336/219069866-acfea101-b557-4c9c-9dc5-ec1258fbbc96.png)

    - Va chạm trái phải
        + Va chạm không bật lại 
            Nếu đang sử dụng skis: Thực hiện xóa tất cả vật cản xung quanh khu vực này này
    ![image](https://user-images.githubusercontent.com/117577336/219069701-50cf07a5-b374-4211-acbf-12d736cdfb23.png)
            Nếu không sử dụng skis: Bị chết do backScene
    ![image](https://user-images.githubusercontent.com/117577336/219070071-5b30a154-0fc2-4d78-a503-e1956e3abb5d.png)

            
        + Xử lý va chạm với vật cản đẩy lại:(Nếu đang ở bên trái rồi đi sang trái, Nếu đang ở bên phải rồi đi sang phải)
    ![image](https://user-images.githubusercontent.com/117577336/219070393-aa4ddcda-d369-439b-8c7c-3d230a036349.png)

            ColliderObjectSlowSpeed():
                Khoảng cách enemy -1
    ![image](https://user-images.githubusercontent.com/117577336/219070509-a8f575c0-febe-4f84-a766-99efadbe8f38.png)

                Nếu khoảng cách enemy = 0 -> bị tóm
                    Nếu đang sử dụng skis
                        Khoảng cách enemy = 2;
                        Trạng thái hero chuyển thành run;
    ![image](https://user-images.githubusercontent.com/117577336/219070808-4ee22b91-4592-47ce-be77-b800cafd97c1.png)

                    Nếu không sử dụng skis
                        Bị chết do cảnh sát tóm
    ![image](https://user-images.githubusercontent.com/117577336/219071107-90569aa7-51e6-489c-8319-91e9999973bc.png)

                Nếu khoảng cách enemy > 0
                    Nếu đang không sử dụng Jumper, Rocket, Cable
                        tốc độ nhân vật chậm lại

    - Xử lý va chạm vật cản (typeCollider == TypeCollider.slower)
        + gọi hàm ColliderObjectSlowSpeed():
            Khoảng cách enemy -1
            Nếu khoảng cách enemy = 0 -> bị tóm
                Nếu đang sử dụng skis
                    Khoảng cách enemy = 2;
                    Trạng thái hero chuyển thành run;
                Nếu không sử dụng skis
                    Bị chết do cảnh sát tóm 
            Nếu khoảng cách enemy > 0
                Nếu đang không sử dụng Jumper, Rocket, Cable
                    tốc độ nhân vật chậm lại

 


# 2. Các sửa đổi cho game
Mô tả chi tiết các sửa đổi trong game, bao gồm hình ảnh, thuyết minh, thuật toán hoặc các Class hay method thêm/sửa/xóa
## 2.1. Thay đổi 1: Tắt box tìm đối thủ
  ![Screenshot (186)](https://github.com/Trangitg/se7.2/assets/119964656/b8f5d23f-6fdd-4f75-a0c1-b88980fec243)
  Trong game, box tìm đối thủ được quản lý bởi một đối tượng gọi là AutoFindOpponentsBox. Trong AutoFindOpponentsBox, có một script được gọi là DeactiveMessageBox.cs, đây chịu trách nhiệm điều khiển hiển thị và ẩn đi box thông báo trạng thái.
  ![Screenshot (187)](https://github.com/Trangitg/se7.2/assets/119964656/71e43747-3bb3-4ee0-89b4-d404f0671217)
  Để tắt box thông qua việc nhấn nút ButtonClose, ta cần thêm một hàm mới, chẳng hạn như ButtonCloseMessage(). Hàm này được liên kết với nút ButtonClose và khi được gọi, nó sẽ thực hiện hành động tắt box hiển thị trạng thái bằng cách tương tác với DeactiveMessageBox.cs. Điều này giúp người chơi đóng box một cách dễ dàng khi cần thiết.    
  ![Screenshot (188)](https://github.com/Trangitg/se7.2/assets/119964656/dc9e4a20-cb78-4eef-bc8d-74c759a2bfb4)
  Hàm này được kích hoạt khi người dùng nhấn vào nút đóng (ButtonClose) trên hộp thoại. Đầu tiên, nó chạy một âm thanh thông báo việc nhấn nút (Module.PlayAudioClipFree). Sau đó, nó sử dụng một Animator để chơi một trigger animation ("TriClose") trên đối tượng này. Điều này thường được sử dụng để kích hoạt một hoạt ảnh đóng hộp thoại.
  Sau đó vào Assets\Scenes\GameMain.unity
    Trong phần Hierarchy, Vào GameMain\ContainGameMain\Canvas\FormGameMenu\MessageBox\AutoFindOpponentBox\AllContents\ButtonClose
    Tại Component Button, Thêm Script AutoFindOpponentBox vào hàm On Click () và chọn function ButtonCloseMessage()
    ![Screenshot 2024-01-03 003905](https://github.com/Trangitg/se7.2/assets/93517130/e45ddf1d-2024-4cd3-ad05-91dbaecafaf3)

## 2.2. Thay đổi 2: Thêm vật phẩm Ball 
 - Download 1 model vật phẩm mới
 - Click chọn file trong unity, trong phần Inspector chọn vào Materials, phần Textures chọn Extract Textures để trích xuất màu của model
    ![88](https://github.com/Trangitg/se7.2/assets/119964656/c3d3920e-9fe4-4ce3-a821-b49a9c16d031)
 - Kéo file vật phẩm mới vào trong scene, Kéo object vật phẩm vào từ Hierachy vào phần project để chuyển thành file prefab
- Mở file ván trượt prefab: chỉnh Tranform của vật phẩm cho phù hợp với nhân vật
    ![Screenshot (189)](https://github.com/Trangitg/se7.2/assets/119964656/40fc7d32-58b0-4a3b-8322-221e6c32606b)

 - Dạng ăn item được trên đường: vào các file và thêm các thuộc tính TypeItems mới
 - ItemInfomation.cs: thêm 1 enum mới (tên là ball) mới ở TypeItems
    ![Screenshot (191)](https://github.com/Trangitg/se7.2/assets/119964656/cb38a81b-f807-4bde-bf65-4c07ad773bde)
 - Module.cs: Thêm 1 game GameObject mới (tên là itemBall)
    ![Screenshot (192)](https://github.com/Trangitg/se7.2/assets/119964656/e3feda11-cb2f-44d5-9223-d9fb01d85ca3)
 - PageMainGame.cs: Thêm 1 GameObject mới (tên là itemBall), ở hàm Awake() thêm : Modules.itemBall = itemBall ;
    ![Screenshot (193)](https://github.com/Trangitg/se7.2/assets/119964656/6385b9ff-086d-4024-ad32-b8d939fbc35b)
    ![Screenshot (194)](https://github.com/Trangitg/se7.2/assets/119964656/c4c6e302-2527-452c-8ca3-58c2cb4e254c)
 - Thêm component BoxCollider
 - Thêm component ItemInfomation.cs
 - TypeItem :chọn Type item vừa thêm ở ItemInfomation.cs : Ball
 - MeshShow: kéo Object model của item vào
     ![Screenshot (195)](https://github.com/Trangitg/se7.2/assets/119964656/7b8ac3cb-9ca8-4faa-9214-c95173d55898)
 - Thêm hình ảnh trên nhân vật thêm vào sau khi ăn item: ItemAddHero.cs
 - HeroController.cs: Có hàm xử ý va chạm item RunFunctionItem() thêm câu lệnh để set nhân vật sử dụng vật phẩm:

        else if (codeItem == TypeItems.ball)
        {
        Modules.SetModelUseItem(transform, codeBody, Modules.itemBall, "");
    ![Screenshot (196)](https://github.com/Trangitg/se7.2/assets/119964656/c8cea46c-29a8-4d33-b6e4-64fc218c28c1)
## 2.3. Thay đổi 3: Thêm thư viện Recorder
 - Vào Asset Strore tải thư viện Record mà bạn mong muốn sau đó download và import thư viện này vào project của mình.
   ![Screenshot (197)](https://github.com/Trangitg/se7.2/assets/119964656/166d5461-daa2-4a55-9b06-701d31562b74)
 - Tìm mainCamera và add component như sau:
  ![Screenshot (198)](https://github.com/Trangitg/se7.2/assets/119964656/07579353-c5f5-4a0f-8e48-34875f0c3222)
    ![Screenshot (199)](https://github.com/Trangitg/se7.2/assets/119964656/b55effa7-f127-4981-b280-36f42db48e79)
- Sau đó sử dụng đoạn code sau để thay đoạn code dùng everyplay trong file Recorder.cs:
    * using UnityEngine; 
        using UnityEngine.Rendering; 
        using pmjo.NextGenRecorder; 
        [RequireComponent(typeof(Camera))] 
        public class OffScreenCameraRecorder : Recorder.VideoRecorderBase 
        { 
        public int videoWidth = 640; 
        public int videoHeight = 480; 
        private RenderTexture m_RenderTexture; 
        private Camera m_Camera; 
        private CommandBuffer m_CommandBuffer; 
        void Awake() 
        { 
                m_RenderTexture = new RenderTexture(videoWidth, videoHeight, 24, RenderTextureFormat.Default); 
                m_RenderTexture.Create(); 
                m_Camera = GetComponent<Camera>(); 
                m_Camera.targetTexture = m_RenderTexture; 
        } 
        }
        if (!Recorder.IsSupported) 
        { 
        Debug.LogWarning("Next Gen Recorder not supported on this platform"); 
        return; 
        } 
        RecordingTexture = m_RenderTexture; 
                m_CommandBuffer = new CommandBuffer(); 
        CommandBufferBlitRecordingTexture(m_CommandBuffer); 
                m_Camera.AddCommandBuffer(CameraEvent.AfterEverything, m_CommandBuffer);
## 2.4. Thay đổi 4: Random tips for players on beginning loading screen
+ Providing a small tip for player at the beginning
+ Currently include 4 permanent tips that generate randomly each time you boot up the game
+ Include some animations
![LoadingPageTips](https://github.com/Trangitg/se7.2/assets/118301761/e8d5b72c-d0b3-4d04-a112-69b9fafb5f8e)
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
    ![TipSettingInUnity](https://github.com/Trangitg/se7.2/assets/118301761/9a0ff48a-afa8-41f4-9689-b70213c3fa50)
+ When displaying the tip, an animation will play every 60 frames, simply appearing and disappearing.
+ The animation is stored in TextTip.anim
    ![TipAnimation](https://github.com/Trangitg/se7.2/assets/118301761/2613d9ec-8aea-4a21-8cd4-57c914154ea6)
## 2.5.Thay đổi 5: Daily Reward system
+ You can receive a 500 coins reward every 24 hours in real time
+ Added new button to receive daily reward : 
![DailyRewardButton](https://github.com/Trangitg/se7.2/assets/118301761/f98809c1-82ca-4c05-b200-fa2855fae818)
+ Daily reward panel :
![DailyRewardPanel](https://github.com/Trangitg/se7.2/assets/118301761/3a78685b-883a-492f-8590-930d75e4ae03)
+ After claiming reward , the claim button turns gray and cannot be clicked until time limit ends.
## 2.6.Thay đổi 6:  Thêm nhân vật:
- Download model định dạng .fbx (mixamo.com,...)

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/5b09797b-9268-4e36-8286-734c9ae2aec1)
  
- Import model vào folder Characters, mở model trong unity, trong phần Inspector chọn vào Materials -> Textures -> Extract Textures để trích xuất màu model

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/3aca200e-3ec0-46b3-b86f-fb78429c9d46)
  
- Chọn Rig -> Animation Type -> Legacy
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/d3f64dee-21c6-4523-a83b-2c9b6506a3a8)
  
- Chọn Model -> thiết lập như ảnh
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/d9f59f4f-8ece-4bed-8f60-65289ff18981)
  
- Kéo model vào trong tab Scene, rồi từ tab Hierarchy kéo model vào folder Prefab ở tab Project để chuyển thành file prefab
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/e6f72dec-35e3-432e-82a6-0713f9bb0c87)
  
- Copy các component Animation, Rigidbody, HeroController(Script), ShadowFixed(Script) của nhân vật có sẵn vào nhân vật mới
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/e9e3680e-34e0-4b79-ad40-115ad7ea40d9)
  
- Copy các objects: PointRaycast, Collider, PointShow, Right Sneakers Control, Left Sneakers Control, Hover Bike control, Hover Board Control, Bip001 Neck, Bip001 R Hand
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/cd693434-cff8-4ce1-bf18-ad09b18c4986)
  
- Trong class Alllanguages.cs: List<List> heroInfoHero là text miêu tả thông tin nhân vật. Tạo List() mới với thông tin miêu tả 11 ngôn ngữ của nhân vật
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/698ba794-98f9-4c37-8225-9147bf7e37a0)
  
- Trong HeroController(Script):
  + IdHero: 008 (chọn Id không trùng với Id của những nhân vật có sẵn)
    
  + CostHero: 100000 (Giá tiền để unlock ván trượt)
    
  + NoteHero: 7 (tương ứng với List<List> heroInfoHero vừa tạo)
    
  + AniHero: Kéo file nhân vật prefab vào
    
    ![image](https://github.com/Trangitg/se7.2/assets/148120250/d48f8589-f843-42bd-bbf1-41a22b455456)
    
  + PoinCheckRay: Object PointRaycast
    
    PointShowHero: Object PointShow
    
    MyCollider: Object Collider
    
    ShadowFixed(Script): Point Raycast: Mở file Prefab nhân vật kéo phần body gốc của file vào
    
    ![image](https://github.com/Trangitg/se7.2/assets/148120250/3b401868-f99c-4626-97ad-27d2df37c35b)
    
- Trong ListResources, trong component ListCharacterUse(Script): có ListHeroUse là danh sách các nhân vật đang được sử dụng, thêm nhân vật mới vào danh sách các nhân vật
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/19350459-fb7b-4135-8508-7768b20165d7)
  
- Thiết lập tương tự với các file animation model tải được trên mixamo, sau đó lấy các animation clip của các model đó áp vào model gốc, ta được 1 nhân vật có thể chuyển động
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/e286ba0e-ed09-4070-a0d6-cf71c3aa57a9)
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/0d3a8034-7965-449b-849c-ecfd9043ebb1)
  
- Hình ảnh trong game:
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/50c13463-07c8-4f02-9620-64cc38d41951)

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/47a386fa-68ea-4371-857a-e242da0a0436)

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/108bf90c-3569-4cb0-a7be-26d98a9478f2)

  
## 2.7.Thay đổi 7: Thêm vật phẩm trong cửa hàng (mua key bằng vàng)
- \Assets\ResourcesGame\Prefabs\MessageUI\ListItemBuy là giao diện của cửa hàng
- Vào ListItemBuy\Content\ParentSingle: Thêm Object mới tên là Key, lấy thuộc tính của 1 vật phẩm đã có sẵn khác
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/2060b3f5-17c9-4211-81ca-2f6a8ea38d6d)
  
- Trong Key thêm component BuyItemController.cs đặt CodeItem = 1 (Key)
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/0c6ca224-e714-4a09-9fc6-c3f0a99dea77)
  
- AllElements\BGAvatar\Avatar, trong Image SourceImage lấy hình ảnh IconKey
- 
  AllElements\Name Trong Text đặt tên vật phẩm là Key
  
  AllElements\Cost\Value Trong phần Text nhập giá vật phẩm mong muốn
  
  AllElements\Note nhập miêu tả vật phẩm
  
  AllElements\ButBuy trong ButtonBuyItem.cs sửa CodeItem thành 1
  
- Thêm chức năng mua trong file script ButtonBuyItem.cs
  
  Tìm ButtonClick() sau đó thêm đoạn code sau vào vòng lặp codeItem == 1

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/4250e969-e935-4539-9ba3-5d2182773106)

- Hình ảnh trong game:

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/d145c96d-bd15-485d-accc-071d9c9808e8)
  

## 2.8.Thay đổi 8: Thêm ván trượt 
- Download model .fbx hình ván trượt

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/e3c0944c-6b9c-40db-b7c1-35305afc2e16)

- Mở model trong unity, trong phần Inspector setting như hình để trích xuất màu model

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/795335ea-effc-41a7-9ea9-269dc5fd7c7a)

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/f22aea7e-4ab1-4893-ab12-93238b4e04b5)

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/c49bc88e-0c31-49d7-879e-a61b88e7fd3e)

- Copy các component ItemAddHero(Script), SkisController(Script), MagnetController(Script), PlaySparksSkis(Script) của ván trượt có sẵn vào ván mới, setting như hình

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/8e9e14ed-6b7a-4baf-8528-f5a8eb609cf1)

- Kéo model vào trong tab Scene, rồi từ tab Hierarchy kéo model vào folder Prefab ở tab Project để chuyển thành file prefab

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/e04c6184-0f19-4fca-98f4-79ee82e95e40)

- Trong class AllLanguages.cs: List heroInfoHoverboard là text miêu tả thông tin nhân vật. Tạo List() mới với thông tin miêu tả 11 ngôn ngữ của ván trượt

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/e3d30dcb-3b46-41f5-a5bc-e287fcff45eb)

- Trong ListResources, trong componrnt ListCharacterUse(Script): có ListSkisUse là danh sách các ván trượt đang được sử dụng, thêm ván trượt mới vào danh sách các nhân vật

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/3541f7c4-4c04-46a1-a9cb-6b5e127f40ea)

- Chỉnh lại kích thước trong Transform cho phù hợp

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/f79632df-cb1a-4412-abf9-eaae87e19790)

- Hình ảnh trong game

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/c7cf6132-c51c-4cb9-9e5e-2bf80b568021)

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/926c7368-67dd-4a8f-9860-06b2cf7c4994)
## 2.9. Thay đổi 9: Fix map
- Nhân vật rơi khỏi thế giới khi đi lên đường hầm
Vào Assets\ResourcesGame\Prefabs\Terrains tìm những terrains có đường đi lên hầm (B005, B007, C005, C008, D013, D016) có những object là RoadCM
Thêm component BarrielInfomation.cs vào RoadCM với các settings:

SuportSkis : true

TypeBarriel : NevelFall

TypeFalling : Back

NeverDestroy : true
![Screenshot 2024-01-03 002339](https://github.com/Trangitg/se7.2/assets/93517130/0415fc4f-8511-40e3-89b4-d25b92e460c1)
## 2.10.Thêm các script Facebook
    - Import Package Facebook SDK chính thức của Meta (https://developers.facebook.com/docs/unity?locale=vi_VN) vào Unity
    - Tạo một app trên Meta for Developers và thiết lập các cài đặt cơ bản, lấy App ID và Client Token điền vào tab Edit settings của Facebook SDK

![1LV](https://github.com/Trangitg/se7.2/assets/119964656/8959d06c-c8df-4197-b885-628082b89653)
![2LV](https://github.com/Trangitg/se7.2/assets/119964656/e5e4f93b-fb80-4489-90fe-83dd18746593)
![3LV](https://github.com/Trangitg/se7.2/assets/119964656/b9893864-1c1b-4ceb-b8b8-faf1165ec819)


    - Thêm Script FacebookController.cs vào Assets\Scripts\General với các hàm:
    1. *Awake()*
    - Hàm này được gọi khi script được khởi tạo.
    - Khởi tạo và kích hoạt ứng dụng Facebook, cũng như đảm bảo rằng đối tượng này sẽ không bị hủy khi chuyển giữa các scene trong Unity.

    2. *OnApplicationPause(bool pauseStatus)*
    - Hàm được gọi khi ứng dụng tạm dừng hoặc quay lại chạy.
    - Kích hoạt lại ứng dụng Facebook khi ứng dụng của chúng ta quay lại chạy.

    3. *SetInit()*
    - Gọi sau khi khởi tạo Facebook, đối phó với menu Facebook dựa trên việc người dùng đã đăng nhập hay chưa.

    4. *FBlogin()*
    - Bắt đầu quá trình đăng nhập Facebook với các quyền đọc cụ thể.

    5. *AuthCallback(IResult result)*
    - Hàm gọi lại sau mỗi lần đăng nhập.
    - Nếu đăng nhập thành công, cập nhật thông tin người chơi và xử lý nhiệm vụ bổ sung như thưởng xu.

    6. *DealWithFBMenus(bool isLoggedIn)*
    - Xử lý menu Facebook dựa trên việc người chơi đã đăng nhập hay chưa.

    7. *DisplayUsername(IResult result)*
    - Hàm gọi lại sau khi lấy tên người chơi từ Facebook.
    - Cập nhật Modules.fbName với tên đầu tiên của người chơi.

    8. *DisplayProfilePic(IGraphResult result)*
    - Hàm gọi lại sau khi lấy hình đại diện của người chơi từ Facebook.
    - Tạo một Sprite từ texture hình đại diện và đặt nó vào Modules.fbMyAvatar.

    9. *ShareWithFriends()*
    - Gọi API Facebook để chia sẻ nội dung (feed) với bạn bè.

    10. *InviteFriends()*
        - Mời bạn bè tham gia trò chơi sử dụng API AppRequest của Facebook.

    11. *TakeScreenshot()*
        - Coroutine để chụp ảnh màn hình và đăng lên Facebook.

    12. *OnPostScreenShot(IGraphResult result)*
        - Hàm gọi lại sau khi đăng ảnh lên Facebook.

    13. *PostScore(bool check)*
        - Đăng điểm của người chơi lên Facebook nếu check là false, ngược lại lấy điểm từ Facebook sử dụng GetScores().

    14. *OnPostScore(IGraphResult result)*
        - Hàm gọi lại sau khi đăng điểm của người chơi lên Facebook.

    15. *GetScores()*
        - Lấy điểm từ Facebook sử dụng Graph API.

    16. *OnGetScore(IGraphResult result)*
        - Hàm gọi lại sau khi thành công lấy thông tin điểm từ Facebook.
        - Tạo một panel hiển thị điểm bạn bè.

    17. *DeserializeScores(string response)*
        - Giải mã phản hồi từ cuộc gọi API Facebook để lấy điểm.

    18. *GetPictureURL(string facebookID, int? width, int? height, string type)*
        - Tạo URL để lấy ảnh đại diện của người chơi từ Facebook với các tham số như chiều rộng, chiều cao và loại ảnh.
# 3. Hướng dẫn Khởi tạo dự án
## 3.1. Cài Unity bản từ 2022 trở đi
Đăng ký tài khoản Unity bằng account sinh viên để có thể tham gia chương trình Education License của Unity

## 3.2. Mở dự án trên Unity và chạy thử ngay trên Màn hình Unity Editor
Vào menu File-> Open Scene, chọn vào file Assets/Scene/LoadData.unity
Bấm nút Play của Unity để chạy thử

## 3.3. Build và chạy trên Android
Vào menu File -> Build Settings, chọn Platform là Android rồi nhấn "Switch Platform" để chuyển sang Android. Sau đó nhấn vào nút Build để thực hiện build ra file APK. Tham khảo trên Google search để biết cách cài đặt Build settings sao cho phù hợp

