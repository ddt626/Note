 使用 Select  的查詢方式，對DB造成的影響

1. 提供給應用程式多餘的資料行，形成浪費。
2. 因資料表的結構改變，造成應用程式抓取資料行次序錯誤。
3. 造成資料庫引擎要先搜尋所有的資料行，再進行作業，浪費執行時間。
4. 無法使用索引進行資料查詢，降低效能。
5. 造成文件不清楚，解讀文件時無法從中得知明確資料行名稱。

Like

1. Like 'BR%' - 指定以 BR 開頭的任何字串
2. Like 'Br%' - 指定以 Br 開頭的任何字串
3. Like '%een' - 結尾是屬於 een 的任何字串
4. Like '%en%' - 字串中間是屬於 en 的任何字串
5. Like '_en' - 僅有三個字元的字串，第一個字元是任何字元
6. Like '[S-V]ing' - 僅有三個字元的字串，指定第一個字元是 S 到 V 的其中一個字元 (S 、T、 U、 V )
7. Like 'M[^C]%' - 指定第一個字元為 M，但是第二個字元不可以包含 C 的字串

 定序 -  _CS 表示區分大小寫，_CI 表示不區分大小寫

 邏輯處理的先後次序 - NOT  AND  OR

 非必要不要使用 NOT BETWEEN、NOT IN，會造成系統執行效能的下降

 NULL

1. 可以使用 is null 或是 is not null判斷
2. 如果要使用 = null 的話，要設定 set ansi_nulls off 
3. 可以使用 isnull() 轉換 null 值
4. 如果資料同時有 null和空白需要判斷時，可以先把null 轉成空白在判斷。 isnull( 欄位, '')  ''

 except, intersect

1. 使用時，兩個資料集的資料行數目與順序要相同，資料類型必須相容。
2. a except b, 找出 a 裡面沒有 b 的
3. a intersect b, 找出 a 和 b 相同的 

 TableSample
1. 亂數抓取一定數量的資料列當成取樣
2. 取樣可以是 數字或是百分比
3. 取樣時，只會取出約略值，不是精準值
4. 資料表越小的時候，回傳的筆數誤差越大
5. 可以使用 top 取得比較精準的筆數

    SELECT TOP 10 TransactionID, TransactionDate
    FROM Production.TransactionHistory
    TABLESAMPLE(2000 ROWS)
    
    SELECT @@rowcount

6. TableSample是根據資料分頁，連續性的掃描，抓取指定的筆數，所以資料會落入相近的資料分頁裡，
如果需要不連續的資料可以使用 checksum() 和 newid()

    SELECT TOP 10 TransactionID, TransactionDate, CHECKSUM(NEWID())
    FROM Production.TransactionHistory
    TABLESAMPLE(2000 ROWS)
    ORDER BY CHECKSUM(NEWID())
    
    SELECT @@rowcount

 Top
1. 取出前面幾筆資料
2. 可以使用百分比，回傳前% 的資料
3. top n with ties 要有對應的order by，可以在order by 之後將與最後一筆資料具有相同值的資料一併列出

    SELECT TOP 4 WITH TIES 
    FROM my_tie mt
    ORDER by my_price
