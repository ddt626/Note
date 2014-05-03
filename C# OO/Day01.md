
- 襌學，頓悟

- oop 架構、特性、優點

- 思考，想 + 考證
  - 什麼方法是可能的，是不是合用
  - 所有的設計都要觀乎情境
  - 找資料去佐證
  - 看自已以前寫的code
  - 設計架構思考是一種直覺，一看就知道有問題
  
- 物件是什麼 ? 
  - 物件是外界真實事物的抽象定義

- 物件的特性
  - 物件必須有一個資料結構來存放資料：欄位
  - 物件有狀態和行為：屬性，方法
  - 變數
  - 記憶體裡面的位置，不用時可以被回收
  - 會被創造和回收
  
  - 程序和資料要分開
  
- 類別在定義物件的概念
  
- 人的思考跟判斷事物的模式就是物件導向，人腦裡面有模糊的概念

- 在程式碼上，抽象是具象的

- 分類的基礎技巧 => 抽象化
  - 抽象化，找出關鍵性的特徵並加以描述
  - 分類是必須的，但方式並非是絕對的
    - 不同情境的方式是不同
    - 設計要關乎情境
    
- oop 三大特性：繼承、封裝、多型 
  
- 多型
  - 繼承式多型
  - 參數式多型：泛型 (正說你是什麼就是什麼)
    - List<T>，T 型別參數
    
  - 強制同型：int 跟 double 相加時，int 轉成 double
  
# 型別與變數

- string 是參考型別
- int 和 Int32 有什麼不同：在compliar 之後會是一樣的
  - int 定義在 C# 裡 
  - Int32 定義在 .net framework 裡
  - Primitvie Type 定義在 C# 裡
  - C# 不定於 .net framework
  - complart 時，會把 int 定義在 Int32

- 型別
  - Primitive Type 
  - 參考型別 Reference Type
  - 實值型別 Value Type

- 實值型別的變數和物件是綁在一起的
- 參考型別是分開的

- 實值型別 - Instance fields
- 參考型別 
  - Type Object Pointer
  - Sync block index
  
- 所有的型別被使用的時候，就會產生一個 Type Object 型別物件

- var 
  - 強型別
  - 右決議型別 = string
  - linq 使用 select new 的時候，一定要使用 var 的情況
  - 編譯時沒有影響，所以不會影響效能
  
- 參考型別物件與變數的關系：變數裡面會有指標指向物件
- 參考型別物件的型別和變數一定要相同嗎?
  - 不用。`Object x = new String()` 

- 實值型別
  - Int32 是一個結構
  - 當實質型別需要 Type object pointer 和 Sync block index 時會 boxing
  - enum的好處，可以用看的懂的字去替代數值

- boxing 無所不在
  - GetType 定義在 object，所以 GetType 時會 boxing 
  - 實值型別轉型成 interface 時一定會 boxing
  - 避免用 ArrayList 處理實值型別
  
- 屬性跟事件 在IL Code 裡面定義都是 method
- 所有的型別物件，都是 Type Object 的執行個體

- 常數
  - 編譯時，會把所有值取代掉
  - 編譯時期的值就是死的

- 欄位
  - readonly 時才會使用 public

- 屬性
  - 方法的變形

- 方法
  - 傳值與傳址
  - 傳值跟傳址時主詞是變數
  - 











