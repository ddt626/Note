#使用 Select  的查詢方式，對DB造成的影響

- 提供給應用程式多餘的資料行，形成浪費。
- 因資料表的結構改變，造成應用程式抓取資料行次序錯誤。
- 造成資料庫引擎要先搜尋所有的資料行，再進行作業，浪費執行時間。
- 無法使用索引進行資料查詢，降低效能。
- 造成文件不清楚，解讀文件時無法從中得知明確資料行名稱。

#Like

- Like 'BR%' - 指定以 BR 開頭的任何字串
- Like 'Br%' - 指定以 Br 開頭的任何字串
- Like '%een' - 結尾是屬於 een 的任何字串
- Like '%en%' - 字串中間是屬於 en 的任何字串
- Like '_en' - 僅有三個字元的字串，第一個字元是任何字元
- Like '[S-V]ing' - 僅有三個字元的字串，指定第一個字元是 S 到 V 的其中一個字元 (S 、T、 U、 V )
- Like 'M[^C]%' - 指定第一個字元為 M，但是第二個字元不可以包含 C 的字串

#定序

- _CS 表示區分大小寫，_CI 表示不區分大小寫

#邏輯處理的先後次序

- NOT -> AND -> OR

#非必要不要使用 NOT BETWEEN、NOT IN 會造成系統執行效能的下降

#NULL

- 可以使用 is null 或是 is not null判斷
- 如果要使用 = null 的話，要設定 set ansi_nulls off 
- 可以使用 isnull() 轉換 null 值
- 如果資料同時有 null和空白需要判斷時，可以先把null 轉成空白在判斷。 isnull( 欄位, '')  ''

#except, intersect

- 使用時，兩個資料集的資料行數目與順序要相同，資料類型必須相容。
- a except b, 找出 a 裡面沒有 b 的
- a intersect b, 找出 a 和 b 相同的 

#TableSample

- 亂數抓取一定數量的資料列當成取樣
- 取樣可以是 數字或是百分比
- 取樣時，只會取出約略值，不是精準值
- 資料表越小的時候，回傳的筆數誤差越大
- 可以使用 top 取得比較精準的筆數

```
SELECT TOP 10 TransactionID, TransactionDate
FROM Production.TransactionHistory
TABLESAMPLE(2000 ROWS)
SELECT @@rowcount
```

- TableSample是根據資料分頁，連續性的掃描，抓取指定的筆數，所以資料會落入相近的資料分頁裡，
   如果需要不連續的資料可以使用 checksum() 和 newid()

```
SELECT TOP 10 TransactionID, TransactionDate, CHECKSUM(NEWID())
FROM Production.TransactionHistory
TABLESAMPLE(2000 ROWS)
ORDER BY CHECKSUM(NEWID())

SELECT @@rowcount
```

#Top

- 取出前面幾筆資料
- 可以使用百分比，回傳前% 的資料
- top n with ties 要有對應的order by，可以在order by 之後將與最後一筆資料具有相同值的資料一併列出

```
SELECT TOP 4 WITH TIES 
FROM my_tie mt
ORDER by my_price
```

#資料別名

- 利用 AS 或是在指定的資料行後面加上新的別名
- 如果資料別名有關鍵字或是空白的時候，可以使用' ' 或是 [ ]
- 資料行別名不可超過 128 字元

```
SELECT GETDATE(),
	   GETDATE() '現在時間',
	   GETDATE() AS '現在時間',
	   GETDATE() [現在時間],
	   GETDATE() 現在時間
```

# Order By

- Order By 中指定的資料行，可以是資料表的資料行或是資料別名

```
SELECT sod.SalesOrderID, sod.ProductID, 
		sod.UnitPrice * sod.LineTotal AS 'SubTotal'
FROM Sales.SalesOrderDetail sod 
ORDER BY SubTotal
```

- 可以指定 select_list 中的資料行位置數字，從1開始

```
SELECT sod.SalesOrderID, sod.ProductID, 
		sod.UnitPrice * sod.LineTotal AS 'SubTotal'
FROM Sales.SalesOrderDetail sod
ORDER BY 2 ASC, 3 DESC
```

- 不能使用在 ntext、text、image和xml
- 可以使用 collate 改變 char、varchar、nchar 和 nvarchar格式的排序方式

```
ORDER BY column_name
COLLATE Chinese_Taiwan_Bopomofo_CI_AS -- 按照 ㄅㄆㄇ 定序
COLLATE Chinese_Taiwan_Stroke_CI_AS -- 按照 筆劃 定序

```

- 可以使用 asc 遞增 和 desc 遞減
- 避免不必要或是過度複雜的排序，這樣會秏用更多的系統資源，降低查詢效能

# 字串組合

- 可以使用固定字串當成是額外的資料行

```
SELECT N'員工基本資料' AS '說明',
		e.BusinessEntityID AS '員工編號', 
		e.JobTitle AS '職稱', 
		e.HireDate AS '到職日'
FROM HumanResources.Employee e
```

- 可以將一筆資料輸出成單一筆字串，如果有非文字的欄位要使用到 convert 函數

```
SELECT N'員工基本資料' +
	   N'編號: ' + CONVERT(char(3), e.BusinessEntityID) +
	   N'職稱: ' + e.JobTitle + 
	   N'到職日: ' + CONVERT(char(10), e.HireDate, 111) 
FROM HumanResources.Employee e 
```

# 去除重複資料
- 可以使用 distinct 將重複的資料消除
- 也可以使用 group by 消除重複的資料

```
SELECT DISTINCT e.JobTitle FROM HumanResources.Employee e
```

#實例 - 使用select 實作字串累加技巧

- 原本返回7筆資料列

```
SELECT BusinessEntityID FROM HumanResources.Employee
WHERE BusinessEntityID BETWEEN 4 AND 10
```

- 利用變數作字串累加

```
DECLARE @s varchar(255) = ''
SELECT @s = @s + CAST(e.BusinessEntityID AS varchar(10)) + ', '
FROM HumanResources.Employee e
WHERE e.BusinessEntityID BETWEEN 4 AND 10

SELECT @s 'EmployeeList'
```

#實例 - 快速找出不連續的號碼與跳號

- 可以使用 except 比對資料表中的編號

```
DECLARE @t TABLE(tid int)
DECLARE @max int, @min int
-- 找出原有資料的最小和最大號碼
SET @min = (SELECT MIN(sid) FROM students s)
SET @max = (SELECT MAX(sid) FROM students s)
-- 利用 while 產生連續號碼
WHILE @min < @max 
BEGIN  
	INSERT INTO @t VALUES (@min)
	SET @min = @min + 1	
END
-- 使用 except 找出不連續編號
SELECT tid '不連續編號' 
FROM @t
EXCEPT
SELECT sid FROM students s
SET NOCOUNT OFF  
```
