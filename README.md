# YarpProject
![License: MIT](https://img.shields.io/github/license/raokun/YarpProject)

基于Yarp.ReverseProxy的反向代理项目，实现ChatGPT代理

## 1.项目信息

Yarp.ReverseProxy 是一个 .NET Core 平台下的反向代理库，它提供了一组 API，可以让 .NET 开发人员轻松地实现反向代理功能

## 2.项目配置

转发配置在appsettings.json

```json
"ReverseProxy": {
    "Routes": {
      "route1": {
        "ClusterId": "chatcluster",
        "Match": {
          "Path": "/v1/{**catch-all}"
        }
      }
    },
    "Clusters": {
      "chatcluster": {
        "Destinations": {
          "chatdestination": {
            "Address": "https://api.openai.com/"
          }
        }
      }
    }
  }
```

这个配置文件定义了一个名称叫“chatcluster”的代理路由，它可以“匹配”来自客户端的 RESTful API 请求，并将它们代理到一个名为“chatdestination”的目标位置。代理目标的地址是“[https://api.openai.com/](https://api.openai.com/)”。

## TODO

* 目前项目只是简单的实践，后续会加入验证和过滤条件



项目构建和Docker发布可参考我个人博客的相关文章

[www.raokun.top](www.raokun.top)

欢迎加群讨论：592463354
