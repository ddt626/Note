# 函數分類

- 系統函數
  - 純量函數 Scalar
  - 資料列集函數 Rowset
  - 彙總函數 Aggregate
  - 排名函數 Ranking
- 使用者自訂函數

- 根據屬性與特質會區分成
  - 決定性 deterministic
    - 任何時候以特定的輸入值呼叫，回傳的結果一徑相同
  - 不決定性 nondeterministic
    - 每次以相同的輸入值呼叫，結果可能會不同

# 純量函數

- 字串函數

  - ASCII()，參數是字元，傳回指定字元的 ASCII 編號
    - `SELECT ASCII('a') AS 'a', ASCII('A') AS 'A'`
  
  - CHAR()，參數是 ASCII 編號，該函數是對應 ASCII 的函數，
    主要是根據 ASCII 碼回傳字元。
    - `SELECT 'Line1..' + CHAR(10) + 'Line2..' -- 產生換行`
  
  - CHARINDEX(運算式, 資料行|字串[,初始搜尋位置])，找尋運算式在字元字串中的起始位置
    - null 表示該資料行內容為 null，0 表示找不到
    - `SELECT d.DocumentNode, CHARINDEX('Adventure', d.DocumentSummary) FROM Production.Document d`

  - PATINDEX('%pattern%', 運算式)，指定運算式中根據字元字串，利用萬用字元，找尋起始位置。
    - null 表示該資料行內容為 null，0 表示找不到
    - `SELECT PATINDEX('%you%', d.DocumentSummary) FROM Production.Document d`

  - LOWER()、UPPER()，回傳轉成小寫與大寫的字元資料
    - `SELECT LOWER('Cash');`
    - `SELECT UPPER('Cash');`

  - RIGHT(資料行|字串,整數)、LEFT(資料行|字串,整數)，針對指定的資料行與字串，從右邊或是左邊找出指定字數的部份字串
    ``` 
    SELECT pod.PurchaseOrderID, pod.OrderQty, 
		'00000'+ CONVERT(varchar(5), pod.OrderQty) AS '轉字串',
		RIGHT('00000' + CONVERT(varchar(5), pod.OrderQty),5) '取五碼' 
    FROM Purchasing.PurchaseOrderDetail pod
    ```


