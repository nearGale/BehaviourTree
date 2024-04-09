## 目标


### 原理

# BehaviourTree

*C# 行为树*

*Unity 可放心食用*

### 包含基础节点
Action
Behavior
Composite
Condition
Decoreator
Filter
Monitor
Parallel
Selector
Sequence

### Action 节点
* ActionLog
* ActionWait - 等待x秒后，返回Succeed，过程中持续Running

### Condition 节点
* ConditionTrue
* ConditionFalse

### DecoratorNodes
* DecoratorRepeat - 装饰器节点：多次执行
* DecoratorInvert - 装饰器节点：取反

## BTreeBlackBoard 黑板
可记录环境信息、树内共享信息
* EnableRunningLog - 打印运行时log，便于跟踪运行情况

![image](https://github.com/nearGale/Unity_BehaviourTree/assets/48747051/e3321179-25fd-4dbb-8809-22f711752e77)

## 树的构造
![image](https://github.com/nearGale/Unity_BehaviourTree/assets/48747051/be31a8cf-ea03-4bc9-863c-7c58c0e75aaa)

## 行为树编辑器[Unity_BehaviourTreeEditor]
https://github.com/nearGale/Unity_BehaviourTreeEditor
![image](https://github.com/nearGale/Unity_BehaviourTree/assets/48747051/27bd9c53-abb5-4e5c-a214-728a2b665167)
