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
## 2.1. Thêm nhân vật:
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
  
- Hình ảnh trong game
  
## 2.2. Thêm vật phẩm trong cửa hàng (mua key bằng vàng)
- \Assets\ResourcesGame\Prefabs\MessageUI\ListItemBuy là giao diện của cửa hàng
- Vào ListItemBuy\Content\ParentSingle: Thêm Object mới tên là Key, lấy thuộc tính của 1 vật phẩm đã có sẵn khác
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/2060b3f5-17c9-4211-81ca-2f6a8ea38d6d)
  
- Trong Key thêm component BuyItemController.cs đặt CodeItem = 1 (Key)
  
  ![image](https://github.com/Trangitg/se7.2/assets/148120250/0c6ca224-e714-4a09-9fc6-c3f0a99dea77)
  
- AllElements\BGAvatar\Avatar, trong Image SourceImage lấy hình ảnh IconKey
  AllElements\Name Trong Text đặt tên vật phẩm là Key
  AllElements\Cost\Value Trong phần Text nhập giá vật phẩm mong muốn
  AllElements\Note nhập miêu tả vật phẩm
  AllElements\ButBuy trong ButtonBuyItem.cs sửa CodeItem thành 1
- Thêm chức năng mua trong file script ButtonBuyItem.cs
  Tìm ButtonClick() sau đó thêm đoạn code sau vào vòng lặp codeItem == 1
  int cost = Modules.IntParseFast(textCost.text); //lấy giá tiền vật phẩm từ text textCost chuyển thành kiểu int để tính toán
            if (Modules.totalCoin >= cost)//Nếu đủ tiền
            {
                if (Modules.totalKey < 10000) // Đặt giới hạn số chìa khóa là 10000, nếu số chìa khóa đang có < 10000
                {
                    Modules.totalKey += 1;//số chìa khóa +1
                    Modules.SaveKey();
                    Modules.totalCoin -= cost;//Trừ số tiền hiện tại bằng giá tiền mua
                    Modules.SaveCoin();
                    if (Modules.containShopItem.activeSelf)
                        Camera.main.GetComponent<PageShopItems>().UpdateCoins();
                        textNote.text = AllLanguages.shopTotal[Modules.indexLanguage] + " " + Modules.totalKey.ToString();           
                    if (Modules.containShopItem.activeSelf)
                        Camera.main.GetComponent<PageShopItems>().UpdateKeys();
           // Cập nhật số tiền và số key hiện có trong Pageshop 
                }
                else//nếu vượt quá số lượng key giới hạn thì phần textNote in ra thông báo lỗi shopMaxNumber
                {
                    textNote.text = AllLanguages.shopMaxNumber[Modules.indexLanguage];
                    textNote.color = colorNotCoin;
                    Invoke("ReturnValueTotal", 1f);
                }
            }
            else//Nếu không đủ tiền thì phần textNote in ra thông báo lỗi shopNotEnough
            {
                textNote.text = AllLanguages.shopNotEnough[Modules.indexLanguage];
                textNote.color = colorNotCoin;
                Invoke("ReturnValueTotal", 1f);
            }

  ![image](https://github.com/Trangitg/se7.2/assets/148120250/4250e969-e935-4539-9ba3-5d2182773106)

- Hình ảnh trong game:

# 3. Hướng dẫn Khởi tạo dự án
## 3.1. Cài Unity bản từ 2022 trở đi
Đăng ký tài khoản Unity bằng account sinh viên để có thể tham gia chương trình Education License của Unity

## 3.2. Mở dự án trên Unity và chạy thử ngay trên Màn hình Unity Editor
Vào menu File-> Open Scene, chọn vào file Assets/Scene/LoadData.unity
Bấm nút Play của Unity để chạy thử

## 3.3. Build và chạy trên Android

Vào menu File -> Build Settings, chọn Platform là Android rồi nhấn "Switch Platform" để chuyển sang Android. Sau đó nhấn vào nút Build để thực hiện build ra file APK. Tham khảo trên Google search để biết cách cài đặt Build settings sao cho phù hợp

