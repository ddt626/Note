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

  - LEN(資料行|字串)，計算字元數，亞洲字元一個字元算是一個字數
	
	- DATALENGTH(資料行|字串)：計算位元組數，亞洲字元，一個字元算是兩個位元組
		
	- RTRIM(資料行|字串)、LTRIM(資料行|字串)：針對指定的資料行與字串，從右邊或是左邊移除空白字元，回傳字元運算式
	
	- SUBSTRING(資料行|字串, 開始字元位置, 長度)：可以針對指字的字串，從開始字元位置，找出需要的字串
	
	- UNICODE(N'字元')：回傳輸入字元的 Unicode 定義整數值，使用上要注意加上 N 來表示 Unicode 的字元
	
	- NCHAR(Unicode 的定義整數碼)：根據 Unicode 的定義整數碼，回傳對應的 Unicode 字元
	
	- REPLICATE(重復的字元, 整數次數)：依據指定的次數重複顯示指定字元
	
	- SPACE(整數次數)：依據指定的次數重複顯示字白字元
	
	- REPLACE(資料行|字串, 需要更換字串, 新的取代字串)：根據指定新的取代字串，從資料行或是字串中，針對需要更換字串，進行置換
	
	- REVERSE(資料行|字串)：根據指定的資料行與字串，根據字元逐一反轉
	
	- QUOTENAME(資料行|字串, [分隔符號])：可以將輸出字串加上分隔符號
		- 符號可以是 單引號(')、左或右括號([]) 或 雙引號(")
		- 使用 單引號(') 時，要輸出一個單引號，要使用兩個單引號
	
	- SOUNDEX(資料行|字串)：傳回四個字元來顯示字串發音相似度
	
	- DIFFERENCE(資料行|字串)：傳回 0~4 的數值，顯示兩個字串的 SOUNDEX 值之間的差異
		- 0 表示相似度弱或沒有相似度，4 表示相似度強或值相同
	
	- `SOUNDEX`、`DIFFERENCE` 主要適用在 `Latin1_General` 英文相關的定序，針對中文 `Chinese_Taiwan` 相關的中文字序，無法正確辦識
	
	- STUFF(資料行|字串, 開始位置, 長度, 新的取代字串)：刪除指定字串並加入新的字元
	
	- STR(數值, [, 長度 [, 小數點右方的位數]])：傳回從數值資料轉換的字元資料
		- `SELECT STR(123.45, 6, 1)`



