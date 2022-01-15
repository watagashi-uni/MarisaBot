# QQBOT

> QQ机器人（试作型）

## 功能

### 舞萌 DX

命令前缀为 `舞萌`/`maimai`/`mai`

| 功能     | 子命令                            | 参数               | 功能                                              |
|:-------|:-------------------------------|:-----------------|-------------------------------------------------|
| 查分     | `查分`/`b40`                     | [名字]             |                                                 |
| 查歌 | `search`/`song`/`搜索` | 名字/id/`id`+id    |                                                 | 
| list   | `list base/定数`                 | 定数1[-定数2]        | 定数随歌, 列出区间 `[定数1,定数2]` 的歌 <br/>（定数2可忽略，默认等于定数1） |
|        | `list bpm`                     | bpm1[-bpm2]      | 与 base 参数类似，只不过是筛选 bpm                          |
|        | `list level/lv/等级`             | 乐曲等级             | 选择等于 `乐曲等级` 的歌                                  |
|        | `list charter`                 | 谱师               | 选择该谱师的歌                                         |
| 随机     | `random`/`rand`/`随机`...        |                  | 参数和 list 指令一致，只不过从结果中随机选择一个                     |
| 猜曲     | `猜曲`/`猜歌`                      |                  | 开启猜曲模式，可以发送 `答案` 或 `结束猜曲` 来关闭会话                 |
|        | `猜曲`/`猜歌`                      | `v2`             | 开启猜曲模式，不过是听歌而不是猜封面                              |
|        | `猜曲`/`猜歌`                      | `排名`             | 查看猜曲排名                                         |
| 别名     | `alias get`                    | 乐曲 (别) 名         | 获取歌曲的所有别名                                       |
|        | `alias set`                    | 乐曲**原名**`$>`新的别名 | 添加别名                                            |

**注**: 
- 该功能的所有命令均大小写**不**敏感
- 猜曲功能仅群中使用

---

### Arcaea


命令前缀为 `arcaea`/`arc`/`阿卡伊`

| 功能     | 子命令                   | 参数               | 功能                              |
|:-------|:----------------------|:-----------------|---------------------------------|
| 查歌（名字） | `search`/`song`/`搜索`  | 名字               |                                 | 
| 猜曲     | `猜曲`/`猜歌`             |                  | 开启猜曲模式，可以发送 `答案` 或 `结束猜曲` 来关闭会话 |
|        | `猜曲`/`猜歌`             | `排名`              | 查看猜曲排名                          |
| 别名     | `alias get`           | 乐曲 (别) 名         | 获取歌曲的所有别名                       |
|        | `alias set`           | 乐曲**原名**`$>`新的别名 | 添加别名                            |

**注**: 
- 该功能的所有命令均大小写**不**敏感，~~不提供查分功能，SB616谁爱伺候谁伺候~~
- 猜曲功能仅群中使用

---

### Ping

> 测试 bot 是否存活

  触发：`:ping`

**注**: 该功能的所有命令均大小写**敏感**

---

### 吃啥

> 这是一个用来解决「中午吃什么」这一被人类公认排在人生 N 大难题前列的问题的功能

触发条件：`吃什么` 或 `吃啥` 字符串

---

### Select

> 解决选择困难症的功能

触发条件：`(动词)(A)还是(B)`

从 `A` `B` 随机选一个

---

### Peek

> 偷窥作者屏幕（？

触发：`:peek`

作者可以使用 `:peek0/1` 禁止/允许偷窥

---

### 五兆亿

> 生成 `五兆亿` 图片

触发：生成top/bottom

---

### 今日运势

> 字面义

触发：`今日运势`/`jrys`

---

### 随机图片

> 从作者的图库中随机抽取一张图片（应该是有一点色图的）

触发1：`抽图`/`ct`
触发2：`看看`/`kk`图库名

---

### 帮助

> 获取 bot 的使用文档

命令前缀为 `帮助/help`

---

### 

## 部署

<details>
<summary> 展开 </summary>

1. 部署 mcl
2. 在 mcl 里登陆 bot
3. 改 App.config
4. 修改图库插件的路径
5. 配置数据库 (entity framework标准操作)
6. 运行，命令行参数如下（顺序敏感）：
   1. [Mirai-API-http](https://github.com/project-mirai/mirai-api-http) 的服务地址，如 `http://127.0.0.1:8080`
   2. bot 的账号，如 `123456789`
   3. Mirai-API-http 的认证密钥，如 <https://github.com/project-mirai/mirai-api-http#settingyml%E6%A8%A1%E6%9D%BF> 中的 `verifyKey`

</details>
