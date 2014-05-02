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

  - ASCII，參數是字元，傳回指定字元的 ASCII 編號
  - `SELECT ASCII('a') AS 'a', ASCII('A') AS 'A'`



