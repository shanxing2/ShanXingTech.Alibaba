# ShanXingTech.Alibaba
跟阿里（天猫、淘宝）相关的各种库

框架版本 .NET 4.6.1

# 引用
	NuGet  
		1.Install-Package System.ValueTuple -Version 4.5.0    
	第三方库  
		1.shanxinglib.dll(https://github.com/shanxing2/shanxinglib)  

# 错误
	1.无法获取密钥文件“ShanXingTech.pfx”的 MD5 校验和。未能找到文件“*\ShanXingTech.pfx”。  
	解决方法：  
	右键项目——属性——签名，去掉勾选 “为程序集签名(A)”，或者选择（或创建）你自己的强名称密钥文件。  


