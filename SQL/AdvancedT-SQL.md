# Transaction

- 啟動 BEGIN TRANSACTION 之後就會對該資料觸發鎖定 (LOCK)，當其它的工作階段 (Session)要使用被鎖定的物件時
  必須等到原啟動 BEGIN TRANSACTION 執行 COMMIT TRANSACTION 或是 ROLLBACK TRANSACTION 才會有動作

- 儲存點 (SAVE POINT) 主要是在交昜的的區間中宣告可以復原的節點，取代整個交易復原
- 具名標記 (WITH MARK) 在使用交易記錄檔還原時，指定該具名標記

```
BEGIN { TRAN | TRANSACTION } 
    [ 
      { 交易名稱 | @交易名稱 } 
      [ WITH MARK ['description']] 
    ]

T-SQL

COMMIT TRANSACTION or ROLLBACK TRANSACTION
```

# IF ELSE 

- 判斷資料是否存在，若存在就執行 update ，否則就 insert

```
DECLARE @id int, @name varchar(30)
SET @id = 1
SET @name = 'LEWIS'

IF EXISTS(SELECT * FROM Students s WHERE s.myID = @id)   
	UPDATE Students SET myName = @name WHERE myID = @id 
ELSE
	INSERT INTO Students VALUES (@id, @name);
GO 
```

- 利用sys.tables 目錄檢視，判斷資料表是否存在，若存在就移除，否則就建立

```
IF EXISTS (SELECT * FROM sys.tables t WHERE t.name = 'Students')
	DROP TABLE Students
ELSE 
	CREATE TABLE Students
	(
		myID int NOT NULL PRIMARY KEY,
		myName varchar(30)
	)
GO 
```

- 判斷資料庫的筆數，決定回傳的資料結果

```
DECLARE @i int
SET @i = (SELECT COUNT(*) FROM AdventureWorks2012.Person.Person p)
IF @i > 10000
	SELECT N'員工數大於1萬人以上' AS '狀態', @i AS '筆數'
ELSE
	SELECT N'員工數小於1萬人' AS '狀態', @i AS '筆數'
GO 
```

- 可以寫巢狀式的判斷

```
DECLARE @i int
SET @i = 4999
IF @i > 10000
	SELECT N'數字大於1萬人以上' AS '狀態', @i AS '筆數'
ELSE IF @i > 5000
	SELECT N'數字大於5千人以上' AS '狀態', @i AS '筆數'
ELSE
	SELECT N'數字' AS '狀態', @i AS '筆數'
GO 
```

# BEGIN END

- 一般來說會搭配 IF ELSE、WHILE 使用

- 刪除不屬於 dbo 執行的資料行，判斷最近一段陳述式執行影響的筆數
- 有加 BEGIN END 的話會顯示 ` data was delete `
- 如果不加 BEGIN END 的話會執行 `SELECT 'Total Count', COUNT(*) FROM DatabaseLog dl`

```
DELETE FROM DatabaseLog WHERE DatabaseUser <> 'dbo'

IF @@rowcount = 0 
	PRINT ' No data was delete '
ELSE 
	BEGIN
		PRINT ' data was delete '
		SELECT 'Total Count', COUNT(*) FROM DatabaseLog dl
	END	
GO
```

# WHILE、BREAK、CONTINUE 

- 基本用方法

```
DECLARE @i int = 5, @j int = 1

WHILE @j <= @i
BEGIN
	SELECT @j
	SET @j = @j + 1
END
```

- 進階可以搭配資料指標 (CURSOR)，將資料以 Row-Based 的方式逐筆處理取代 Set-Based
- 可以搭配 Break 指令跳離迴圈

```
DECLARE @i int = 0

WHILE 1 = 1
BEGIN
	SET @i = @i + 1
	IF @i > 100 BREAK
END

SELECT @i
```

- 可以使用 CONTINUE 重新執行迴圈，並忽略掉在 CONTINUE 後的任何陳述式

```
-- 條件是平均單價小於 500 以內
WHILE (SELECT AVG(ListPrice) FROM Production.Product) < $500
BEGIN  
	-- 平均漲幅 10%
	UPDATE Production.Product SET ListPrice = ListPrice * 1.1
	-- 查詢最高單價
	SELECT MAX(ListPrice) FROM Production.Product 	
	-- 如果最高單價大於 4000 時中斷，否則就繼續
	IF (SELECT MAX(ListPrice) FROM Production.Product) > $4000
		BREAK
	ELSE	
		CONTINUE
END
```

# 使用 GOTO 會破壞程式的可讀性和結構，建議不要使用

# WAITFOR

- 強迫 T-SQL 必須等待指定的時間在繼續執行其它的陳述式
- 等待的時間最多可以是 24 小時
- 指定時間執行 `WAITFOR TIME '00:00'` 
- 指定延遲執行 `WAITFOR DELAY '00:00:05'`

```
SELECT GETDATE()

-- 等待 5 秒
WAITFOR DELAY '00:00:05'

SELECT COUNT(*) FROM sys.tables t

SELECT GETDATE()
```

# CASE

- 可以在集合基礎 (Set-Based) 的指令下，處理 Row-Based 的作業

```
SELECT BusinessEntityID, Gender,
	   CASE Gender WHEN 'M' THEN 'Man'
	               WHEN 'F' THEN 'Woman'
				   ELSE 'Unknown'
	   END 
FROM HumanResources.Employee
```

- 可以搭配建立資料表的過程，產生計算資料行

```
CREATE TABLE EmpSalary
(
	empId int NOT NULL PRIMARY KEY,
	empName varchar(30) NOT NULL,
	salary int NOT NULL,
	grade AS CASE salary / 30000
			WHEN 0 THEN 'A'
			WHEN 1 THEN 'B'
			WHEN 2 THEN 'C'
			ELSE 'D'
		END
)
GO 
```

# RETURN 、RAISERROR

- RETURN 可以無條件的中斷任何陳述式

```
SELECT 1
RETURN -- 以下陳述式不會執行
SELECT 2
```

- RAISERROR 僅會將執行的錯誤訊息回傳給前端應用程式，不會中斷執行

```
SELECT 1
RAISERROR ('bY CASH', 16, 1) -- 以下陳述式還是會執行
SELECT 2
```

# @@ERROR

- 可以用來抓取最近一行陳述式引發的錯誤
- 錯誤發生時可以抓到錯誤的號碼，但是不提供警告機制

```
DECLARE @i int = 0
SELECT 100 / @i
PRINT @@error
```
```
訊息 8134，層級 16，狀態 1，行 4
發現除以零的錯誤。
8134
```

- 可以搭配 RAISERERROR，進行錯誤代碼的抓取

```
RAISERROR('By Cash', 16, 1)
PRINT @@error
```
```
訊息 50000，層級 16，狀態 1，行 1
By Cash
50000
```

# TRY CATCH

- 需使用 BEGIN END

```
BEGIN TRY
	DECLARE @i int = 0
	SELECT 100 / @i
END TRY
BEGIN CATCH
	PRINT @@error
END CATCH
```

- ERROR_MESSAGE()   傳回造成執行 try 陳述式中的 錯誤號碼
- ERROR_SEVERITY()  傳回造成執行 try 陳述式中的 嚴重性
- ERROR_STATE()     傳回造成執行 try 陳述式中的 錯誤狀態碼
- ERROR_MESSAGE()   傳回造成執行 try 陳述式中的 錯誤訊息文字
- ERROR_LINE()      傳回發生錯誤造成執行 try 陳述式中程式的 行號
- ERROR_PROCEDURE() 傳回發生錯誤造成執行 try 的預存程序或觸發程式的名稱

- 無法抓取語法錯誤的異常

```
BEGIN TRY
	SELECT ** FROM sys.objects o
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE() ErrorMessage
END CATCH
```

- 無法處理編譯錯誤，例如物件名稱延緩解析錯誤

```
BEGIN TRY
	SELECT * FROM sys.object o
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE() ErrorMessage
END CATCH
```

- 錯誤層級低於 10 以下不會進入 catch 處理區

- 不可跨超過一個批次處理

```
BEGIN TRY
	SELECT 1/ 0;
END TRY
GO
BEGIN CATCH
	SELECT ERROR_MESSAGE() ErrorMessage
END CATCH
GO
```

# 實例 - 使用變數決定 T-SQL 執行內容

```
BEGIN TRY
	DECLARE @db nvarchar(255)
	DECLARE @tab nvarchar(255)
	SET @db = N'AdventureWorks2012'
	SET @tab = N'HumanResources.Employee'
	EXECUTE ('SELECT * FROM ' + @db + '.' + @tab)
END TRY
BEGIN CATCH
	SELECT ERROR_NUMBER(), ERROR_SEVERITY(), ERROR_STATE(),
	       ERROR_MESSAGE(), ERROR_LINE(), ERROR_PROCEDURE()
END CATCH
```

# 實例 - 利用 TRY CATCH 技巧讓程式自動中斷與 SQL Server 連線

- 使用 WITH LOG 時，該錯誤訊息會自動記錄在 OS 應用程式的事件檢視器裡面

```
BEGIN TRY
	RAISERROR('Disconnect SQL Server', 20, 1) WITH LOG
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE()
END CATCH
```
```
訊息 2745，層級 16，狀態 2，行 2
處理序識別碼 54 引發使用者錯誤 50000，嚴重性 20。SQL Server 正在結束這個處理序。
訊息 50000，層級 20，狀態 1，行 2
Disconnect SQL Server
訊息 0，層級 20，狀態 0，行 0
在目前的命令上發生嚴重錯誤。如果有任何結果，都必須捨棄。
```
