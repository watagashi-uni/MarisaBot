# QQBOT

> QQ机器人（试作型）

## 功能

### 舞萌 DX

命令前缀为 `舞萌`/`maimai`/`mai`

| 功能 | 子命令 | 参数 | 功能 |
|:----| :--- | :--- | ---- |
| 查分 |  `查分`/`b40` | [名字] | |
| 查歌（名字） | `search`/`song`/<br/>`搜索`/`搜歌`/`查歌` | 名字 | | 
| 查歌（ID） | `id` | id（一串数字） | |
| 查歌（名字） | `name` | 名字 | 获取歌曲信息，仅获取歌曲名和艺术家（方便复制）|
| list | `list base` | 定数1[-定数2] |  定数随歌, 列出区间 `[定数1,定数2]` 的歌 <br/>（定数2可忽略，默认等于定数1） |
|  | `list bpm` | bpm1[-bpm2] | 与 base 参数类似，只不过是筛选 bpm |
|  | `list level` | 乐曲等级 | 选择等于 `乐曲等级` 的歌 |
|  | `list charter` | 谱师 | 选择该谱师的歌 |
| 随机 | `random`/`rand`/<br/>`随机`/`随歌` ... | | 参数和 list 指令一致，只不过从结果中随机选择一个 |
| 猜曲 | `猜曲`/`猜歌` | | 开启猜曲模式，可以发送 `答案` 或 `结束猜曲` 来关闭会话 |

**注**: 该功能的所有命令均大小写**不**敏感

---

### Ping

> 测试 bot 是否存活

- 群组中：`@bot ping`
- 私聊：`:ping`

**注**: 该功能的所有命令均大小写**敏感**

---

### 帮助

> 获取 bot 的使用文档

命令前缀为 `帮助/help/h`

- 群组中：`@bot 前缀`
- 私聊：`前缀`

**注**: 该功能的所有命令均大小写**不**敏感

---

### Timer

> 计时器

仅私聊使用

|命令|参数|功能|
|---|---|---|
| :ts | [timer-name] | 启动一个计时器 |
| :te | [timer-name] | 停止一个计时器 |

---

### 吃啥

> 这是一个用来解决「中午吃什么」这一被人类公认排在人生 N 大难题前列的问题的功能

触发条件：`吃什么` 或 `吃啥` 字符串

---

### Select

> 解决选择困难症的功能

触发条件：`(动词)(A)还是不?(动词)?(B)`

从 `A` `B` 随机选一个

---

### Peek

> 偷窥作者屏幕（？

- 群组中：`@bot :peek`
- 私聊：`:peek`

---

## 部署

<details>
<summary> 展开 </summary>

1. 部署 mcl
2. 在 mcl 里登陆 bot
3. 改 App.config
   1. `LogPath` 日志地址（目前还没用到）
4. 配置数据库 (entity framework标准操作)
5. 运行，命令行参数如下（顺序敏感）：
   1. [Mirai-API-http](https://github.com/project-mirai/mirai-api-http) 的服务地址，如 `http://127.0.0.1:8080`
   2. bot 的账号，如 `123456789`
   3. Mirai-API-http 的认证密钥，如 <https://github.com/project-mirai/mirai-api-http#settingyml%E6%A8%A1%E6%9D%BF> 中的 `verifyKey`

</details>
