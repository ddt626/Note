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

- 日期與時間函數
	- 指定日期時間的資料，需要在前後加上單引號
	- 指定日期時間的過程，如果沒有指定時間就會以 '00:00:00' 取代
	- 日期時間的指定格式與 SET DATEFORMAT 有關系
	- 日期時間的輸出結果與 SET LANGUAGE 有關系
	
	- SYSDATETIME()：現在時間，SYSUTCDATETIME()：現在UTC時間，SYSDATETIMEOFFSET()：現在時間與時區
	
	- SWITCHOFFSET()：運用在計算不同時區的現在時間，需要使用 datetimeoffset 的資料類型
		- `SELECT SWITCHOFFSET(SYSDATETIMEOFFSET(), '+08:00')`

	- GETUTCDATE()：格林威治標準時間，GETDATE()：目前日期和時間，CURRENT_TIMESTAMP：目前日期和時間
	
	- DATEADD(日期的部份, 數字, 日期時間值)，DATEDIFF(日期的部份, 開始日期, 結束日期)
		- yyyy 年、mm 月、dd 日、hh 小時、mi 分、ss 秒、ms 毫秒...
		- `SELECT DATEADD(mm, 12, '2009/01/10'), DATEDIFF(dd, '2009/01/10', '2007/09/05')`
	
	- DATEPART(日期的部份, 日期時間值)，DATENAME(日期部份, 日期時間值)
		- DATEPART 回傳的是數字，DATENAME 回傳的是文字
		- 會根據執行階段的語系讓結果有所不同
		- `SELECT DATEPART(dw, '2009/01/15'), DATENAME(dw, '2009/01/15')`
	
	- YEAR(日期時間值)、MONTH(日期時間值)、DAY(日期時間值)
		- 等同使用 DATEPART(yyyy, 日期時間值)、DATEPART(mm, 日期時間值)、DATEPART(dd, 日期時間值)
