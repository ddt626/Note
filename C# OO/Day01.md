# 基本概念

- oop 就是`襌學`、`頓悟`

- 充分運用 oop 的架構、特性、優點

- 思考 => 思想 + 佐證，類似研究一樣要先搜集資料在證明
  - 什麼方法是可能的，是不是合用
  - 所有的設計都要把`情境`考慮進去
  - 要找資料去佐證自已所想的
  - 看自已以前寫的 code 才會進步
  - 設計架構思考是一種直覺，一看就知道程式碼有問題的直覺
  
# 物件導向的世界

- 物件是什麼 ? 
  - 物件是外界真實事物的抽象定義

- 物件的特性
  - 物件必須有一個資料結構來存放資料：欄位
  - 物件有狀態和行為：屬性，方法
  - 物件要能被識別：變數
  - 物件可以被創造及消滅：記憶體裡面的位置，不用時可以被回收
  - 物件有生命週期：會被創造和回收
  
- 類別與物件
  - 外界的真實事物都有其相似或相同性質的地方
  - 類的形成即是透過`分類`的過程將一群類似的物件`抽象化`成一個概念
    => 類別是在定義物件的概念
  
- 人的思考跟判斷事物的模式就是物件導向
  人腦裡面對所有的事物都有模糊的概念
  ex：小時候看到類似的東西都覺得一樣

- 在程式碼上，抽象是具象的 => 在程式碼上，抽象是可以看的到

- 抽象化 => 分類的基礎技巧
  - 抽象化就是找出關鍵性的特徵並加以描述
  - 分類是必須的，但方式並非是絕對的
    - 不同情境的方式是不同 (設計要考慮情境)
    
# oop 的三大特性：封裝、繼承、多型 
  
- 封裝
  - 隱藏不必要為外界所知的資訊
  - 隱藏行為的變化
  - 只可以透過特定公開介面與外界互動

- 繼承
  - 繼承者會擁有被繼承者的型別特徵
  - c# - 可以繼承一個上層的類別，可以實作多個介面

- 多型
  - 廣義多型 (universal polymorphism) 
    - 繼承式多型 (inclusion)
      - 一般所說的多型
    - 參數式多型 (parametric)
      - 以參數的型式讓類別可以達到動態變化的方法，c# 中的泛型就是
      - 泛型 => 朕說你是什麼就是什麼
      - List<T>，真正的泛型是 角括號，T 叫作型別參數
  - 特設多型 (ad hoc polymorphism)  
    - 多載 (overloading)
      - 程序多載，使用同一個名稱但不同的參數清單定義多個版本的程序，就是 運算子多載
    - 強制同型 (coercions)
      - int 跟 double 相加時，int 會強制轉成 double
   
# 型別與變數

- string 是參考型別
- int 和 System.Int32 有什麼不同：
  - 基本上在 compiler 之後會是一樣的
  - int 定義在 c# 語言裡 
  - System.Int32 定義在 .net framework 裡
  - c# 不一定是用 .net framework compiler
  - 如果是用 .net framework 作 compiler 時，.net framework 會把 int 定義在 System.Int32 上
  - 建議還是用 c# 語言的寫法，至少比較好寫和好打

- 型別
  - 資料型別 Primitive Type => 定義在 c#
  - 參考型別 Reference Type
  - 實值型別 Value Type

- 參考型別 vs 實值型別 1
  - 從變數內容來看
    - 實值型別變數內容就是物件本身
      - 實值型別的變數和物件是綁在一起的
    - 參考型別的變數內容是儲存指向物件的參考 (指標)  
      - 參考型別的變數和物件是分開的
  - 從記憶體分配來看
    - 實值型別的物件存在 Stack
    - 參考型別的物件在在 Heap
 
- 參考型別 vs 實值型別 2
  - 實值型別 
    - Instance fields
  - 參考型別 
    - Type Object Pointer
    - Sync block index
    - Instance fields  

- 所有的型別被使用的時候，會產生一個 Type Object 型別物件

```
public class MyRefClass
{ 
  public int x; 
}

public struct MyValStruct
{ 
  public int x; 
}

private void CreatInstance()
{
  MyRefClass v1 = new MyRefClass();
  MyValStruct v2 = new MyValStruct();
  v1.x = 10;
  v2.x = 20;
}
```

![參考型別和實值型別.png](https://raw.githubusercontent.com/cashwu/Note/master/C%23%20OO/%E5%8F%83%E8%80%83%E5%9E%8B%E5%88%A5%E5%92%8C%E5%AF%A6%E5%80%BC%E5%9E%8B%E5%88%A5.png)

- var 
  - 強型別
  - 隱含型別
  - 右(後)決議型別，由等號右邊決定型別 ( = string )
  - 只能做為宣告區域變數使用
  - 一定要使用 var 的情況
    - linq 使用 select new 的時候
  - 只能做為宣告區域變數使用
  - 編譯時沒有影響，所以不會影響效能

```
string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
var newwords = words.Select((w) 
                            => new { Upper = w.ToUpper(), 
                                     Lower = w.ToLower() });
```

- 觀念
  - 參考型別物件(執行個體)與變數的關系
    - 變數裡面會有指標指向物件
  
  - 參考型別物件的型別和變數一定要相同嗎?
    - 不用，ex：`Object x = new String()` 

# 實值型別

- 特徵
  - 一定會繼承 System.ValueType 
  - 以結構或列舉的形式存在
    - struct
      - Int32 是一個結構
    - enum
      - enum 的好處，可以用看的懂的字去替代數值
  - 變數與物件是一對一的關係
  - 實值型別物件沒有 Type object pointer 和 Sync block index
    - 當實質型別需要 Type object pointer 和 Sync block index 時會 boxing
  
- boxing 無所不在
  - GetType 定義在 object，所以呼叫 GetType 時會 boxing 
  - 實值型別轉型成 interface 時一定會 boxing
  - 避免用 ArrayList 處理實值型別，因為會 boxing

# 類別

- 類別成員
  - 常數
  - 欄位
  - 屬性
  - 方法
  - 事件
  - 建構式
  
- 屬性跟事件 在 IL Code 裡面定義都是 方法
- 所有的型別物件，都是 Type Object 的執行個體

- 型別物件 vs 執行個體物件
  - 型別物件
    - Type Object Pointer
    - Sync block index
    - Static fields
    - Method table
  - 執行個體物件
    - Type Object Pointer
    - Sync block index
    - Instance fields

- 成員修飾詞
  - abstract
    - 為抽象成員，在其衍生類別中必須實做其內容 
  - sealed
    - 其衍生類別將無法再覆寫此成員
    - 當套用至成員時，sealed 必須和 override 搭配使用
  - virtual
    - 允許在衍生類別中覆寫此成員 
  - new
    - 明確隱藏繼承自基底類別的成員，或稱為遮蔽
  - override
    - 覆寫基底類別的虛擬 (virtual) 成員

- 常數
  - 編譯時期就會把所有常數值取代掉
    - 編譯時期的值就是死的
  - 執行時期無法變更

- 欄位
  - 在 .net 中，將定義於類別層級的變數稱為欄位
  - 是一個任意型別的變數
  - 一般情境下的存取層級很少是 public 
    - readonly 時才會使用 public

- 屬性
  - 提供讀取、寫入或計算私用 (private) 欄位值之彈性機制的成員 
  - 方法的變形
  - 使用屬性取代欄位成為公開介面
  - 自動實做實性
    - ` public int day { get; set; }`

```
//方法的變形
public class Class1
{
  private int _x = 0;
  public int GetX()
  { 
    return _x; 
  }
  
  public void SetX(int value)
  { 
    _x = value; 
  }
}

public class Class2
{
  private int _x = 0;
  public int X
  {
    get 
    { 
      return _x; 
    }
    set 
    { 
      _x = value; 
    }
  }
}
```

- 屬性唯讀/唯寫
  - 只宣告 get/set 存取子其中之一 => 比較不好的做法
  - 將要隱藏的存取子的存取層級降低 => 比較好的做法

- 方法
  - 包含一系列陳述式 (statement) 的程式碼區塊，程式會呼叫 (calling) 方法並
    指定所有必要的方法引數，藉以執行陳述式
  - 重要的關鍵字
    - ref
    - out
    - params
  
- 傳值與傳址
  - 傳值跟傳址時的主詞是`變數`，一切以變數為主
  - out 跟 ref 其實一樣，只是 out 強迫一定要在 mehtod 裡面給值

- 實質型別的變數
  - `int x = 0;` 
  - 變數 x 在記憶體中佔有一個位址 (ex：0xFF80)
  - 變數 x 的型別是 int
  - 變數 x 儲存的內容值是 0
  
- 實值型別傳值
```
static void Main(string[] args)
{
  int x = 0;    
  int y = ChangeX(x);
}
//取出 main 方法中的 x 的值複製一份到 ChangeX 方法中的 x
//兩個 x 的變數位址不同
private static int ChangeX(int x)
{
}
```

- 實值型別傳址
```
static void Main(string[] args)
{
  int x = 0;    
  int y = ChangeX(ref x);
}
//取出 main 方法中的 x 的位址傳遞給 ChangeX 方法中的 x
//兩個 x 的變數位址相同
private static int ChangeX(ref int x)
{
}
```

- 參考型別的變數
  - `Object x = new TestClass();`
  - 變數 x 在記憶體中佔有一個位址 (ex：0xAA77)
  - 變數 x 的型別是 Object
  - 變數 x 儲存的內容值是一個 TestClass 型別的物件位址 (0x1200) ====> 型別 TestClass 的 Instance，位址：0x1200
  - 此時記憶體中有兩個東西
    - 變數 x
    - TestClass 所產生的實體

- Tuple
  - 傳兩個不太相關的東西，又不想寫在同一個類別的時候

- 覆寫和遮蔽
  - 覆寫，執行個體的型別的方式
  - 遮蔽，用變數的型別來決定方法
  - 遮蔽的時候可以改變參數
  - 俢改 lib 內的方法時可以用遮蔽，這時就完全依賴實作不依賴介面
  - interface 用 new 時不是改變行為，而是擴展，為了可讀性的考量

- 委派
  - 是一個型別，用 delegate 宣告時，是在宣告一個型別，其父類別是 MulticastDelegate
  - 宣告簽章，所指向的方法也要符合簽章
  - 委派型別宣告出來的變數是參考型別
  - 委派可以當 method 的參數傳

- Action Func
  - Action 沒有回傳值
  - Func 有回傳值 TResult
  
- 事件就是藉由委派在傳遞
  - 定閱者，發行者
  - 事件是固定的，事件委派函式是可以變動的

- 建構式
  - 預設隱含呼叫父類別無參數的建構式
  - 衍生類別必須要明確呼叫基底類別建構式
  - 不要在建構式裡面呼叫虛擬方法，避免 null exception





