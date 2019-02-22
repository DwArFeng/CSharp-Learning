using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpSamples.GetSetSample {

    class Program {

        /// <summary>
        /// <para>在读取TestValue的值时，用户可以发现读取出的值比实际的 _testValue 多了100，这是因为在 get 方法中，通过语句让获取的值比 _testValue大了100。</para>
        /// <para>在写入TestValue的值时，用户可以发现在值写入的同时，控制台多输出了 _testValue 被更改的信息，这是因为在 set 方法中，通过语句在控制台上输出了相应的语句。</para>
        /// </summary>
        static void Main(string[] args) {
            ValueTester valueTester = new ValueTester();
            Console.WriteLine(valueTester.TestValue);
            valueTester.TestValue = 100;
            Console.ReadLine();
        }
    }

    /// <summary>
    /// 该程序说明了C#中的get set的具体作用，以及如何影响对应的字段。
    /// </summary>
    class ValueTester {

        private int _testValue = 0;

        public int TestValue {
            get { return _testValue + 100; }
            set {
                Console.WriteLine(String.Format("私有字段 _testValue 被改变了，新的值是{0}!", value));
                _testValue = value;
            }
        }
    }
}
