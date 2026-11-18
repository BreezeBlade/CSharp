using System;

class Program
{
    // 编译时常量
    const double Pi = 3.14159;

    // 只读字段
    readonly DateTime createdAt;

    // 在构造函数中初始化 readonly 字段
    public Program()
    {
        createdAt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
    }

    static void Main()
    {
        Program obj = new Program();

        Console.WriteLine("圆周率：" + Pi);
        Console.WriteLine(
            "创建日期：" + obj.createdAt.ToString("yyyy-MM-dd")
        );
    }
}