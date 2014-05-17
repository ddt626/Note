# 命名空間

- 公開的愈少，狀況愈少
- 命名空間
  - 使用命名空間組識其多種類別
  - 善用命名空間可以有效的管理程式

# 設計模式

- 用來解決特定的需求
- 在不重新設計下進行改變
  - 不改變用原有所寫好的程式
  - 原本固定好的就不要改變它，要擴充它
  - 設計之初就要考慮清楚
- 組合多種設計模式
- 見招拆招
- 抽象不固定的話，設計一定會有錯，抽象只會擴展，不會修改

# 繼承
- 繼承
  - 繼承是侵入性的
    - b 繼承 a ，b就有a的特性，a就侵入b
  - 強耦和的
  - 最多就是三層 interface不算  

- 聚合
  - Is-it -> has-it 
  - Superclass裡面有 兩個 class的東西
    human 和 bmi，這兩個就叫聚合
  - 優先考慮聚合 再 耦和 

# SOLID 六大原則

- 原則是目標，有的時候也會有矛盾
- 單一職責原則
  - SRP
  - interface 上儘量要求 
  - 職責的意義
    - 庫存 => 加 跟 減

- 里式替換原則
  - 抽象的概念要相同
  - 用的時候會不會改變原有的抽像概念
  - a <- b <- c 當 b跟 c 違反里式替換原則時
  - 要變成 a <- b , ab 和 ac 不能違反
             <- c

- 倚賴倒置原則

- 介面隔離原則

- 開閉原則 (重要)
  - 對擴展開放，對修改封閉

- 最少知識原則 (六大才有它)
  - 迪米特法則
  - 跟介面隔離很像
  
# IoC 控制反轉

- 實現低偶合的最佳設計方式
- 相依於抽象而不倚賴於實作
- 實作是怎麼產生的

# Dependency Injection

- 注入
  - 讓一個類別認識另外一個類別
  - 把一個類別注入一個類別

- Interface Injection
- Constructor Injection
- Setter Injection
- 兩個由什麼方式認識的..

# 單例模式

- 單一獨佔性的操作

# 反射

- Assembly
  - Assembly.Load
    - by AssemblyName
    - by Assembly nam String
    - by Assembly byte[]
    
- 建立執行個體
  - object or ObjecHendler

- GetMember
- GetMethod
- Property
- Interface

- Activator

- 使用反射建立泛型實體
- clr 啟動，產生appdomain，load 參考 => 自排
- 反射 => 手排

- 反射最大的問題是 型別安全，反射的東西是弱型別

# Attribute







