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




