# ResourcesToolTempletAndDemo
资源加载工具模板（内有使用Demo）

特点介绍：

1、使用 Enum 来保存资源的文件目录；

2、通过 Enum 的对应资源名称即可加载对应的资源，而且 Enum 的类型不受限制；

3、可以加载返回任何类型的资源；

4、资源工具是单例，无需挂载，直接使用；

使用方法：

1、把需要的资源分门别类放到 Unity 工程的 Resources 文件夹下；

2、对应修改添加对应的资源枚举值到 EnumResourcePath 文件里；

3、对应的根据枚举类型，来处理 ResourecesTool 脚本的 switch Case 资源路径；

4、在需要加载资源的地方，直接调用 ResourcesTool.Instance.ResourceLoad<T>(EnumValue) 即可加载资源;
