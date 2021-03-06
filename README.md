# 动画技术文档
## 整体框架
- 1:导入csv资源
- 2:解析csv资源
- 3:搭建ui
- 4:使用状态机修改播放动画
- 5:读取csv文件实现相应功能并测试

## 目录结构

```
├── Readme.md              #技术文档                    
├── config                     
│   ├── SimpleScence       #场景
├── internal
│   ├── GameModelManager   #读取配置文件
│   ├── PlayerPrefab       #自己
│   ├── EnemyPrefab        #敌人
│   ├── canvans	
│   |    ├── PlayerSlider  #自己血条
│   |    ├── EnemySlider   #敌人血条


```

## 预制物
- 1:敌人
- 2：玩家
- 3:箭

## 第三方库
- 1： ParseCSV:解析CSA数据



##代码结构
| 需要的脚本       |     实现的功能 |
| ------ | ------                |
| 数据读取脚本 |  读取并解析CSV数据   |
| 人物基类脚本 |  敌人和玩家共同拥有的信息   |
| 动画控制脚本   |  控制玩家敌人和箭的动画   |
| 血条控制脚本 |  控制血条的移动和数值变化  |


![动画](https://user-images.githubusercontent.com/92706401/140639393-27be165a-3eee-484b-9f80-998e0244e740.png)
