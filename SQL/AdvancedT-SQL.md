
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

