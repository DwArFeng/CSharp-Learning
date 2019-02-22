using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpSamples.VariablesSample {

    class Program {

        static void Main(string[] args) {
            #region 定义var型变量
            var name = "DwArFeng";
            var age = 27;
            var isRabbit = false;
            #endregion
            #region 获取var型变量具体类型
            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();
            #endregion
            #region 在控制台输出变量的具体类型
            Console.WriteLine(String.Format("name is type {0}", nameType));
            Console.WriteLine(String.Format("age is type {0}", ageType));
            Console.WriteLine(String.Format("isRabbit is type {0}", isRabbitType));
            Console.ReadLine();
            #endregion
        }
    }
}
