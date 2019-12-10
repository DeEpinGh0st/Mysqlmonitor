# Mysql数据库执行监控  
## 代码参考自Seay源代码审计系统的Mysql监控插件  

### 1. 为什么造这个轮子？  
> 在新版本的mysql日志文件中,augments由原来的mediumtext变为mediumblob类型,导致原本的插件无法读取日志记录  
### 2. 此工具只适用于mysql日志中augments为BLOB类型的版本，不兼容老版本
### 3. 运行环境
> .Net Framework 4.5.2 or newer
### 4. Screenhost
![Screenhost](https://github.com/DeEpinGh0st/Mysqlmonitor/blob/master/20191210151554.png)