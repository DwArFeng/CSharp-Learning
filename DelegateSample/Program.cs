using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpSamples.DelegateSample {

    /*
     * C#的委托机制在java中并不存在。
     * 个人理解：java中并不需要实现委托机制，其实委托机制中的几乎所有内容都可以通过接口实现。
     *     然而，C#继承了一部分C语言的特性，其中包括函数指针。个人感觉C#的委托和C语言的函数指针十分相似。
     */
    class Program {

        static void Main(string[] args) {

            /*
             * 定义Run代理的一个实例 run。
             * 代理就像类那样，需要有一个实例来运行。
             */
            Run run;

            /**
             * Run拥有含有一个参数的构造器方法，参数的类型是方法。
             * 符合要求的方法可以直接被传入。
             */
            run = new Run(showMessage);
            run();

            /**
             * 在使用委托的时候，可以使用Lambda标签，而不用新建方法。
             * Lambda标签对于简单的方法特别方便。
             */
            run = new Run(() => { Console.WriteLine("Lambda 1: Hello World!"); });
            run();


            /**
             * Run的实例化可以省略 new Run()，只使用
             * Lambda标签对于简单的方法特别方便。
             */
            run = () => { Console.WriteLine("Lambda 2: Hello World!"); };
            run();

            Console.ReadLine();
        }

        /// <summary>
        /// <para>定义了一个委托的run方法，不返回值，没有参数。</para>
        /// <para>在java中，定义了Runnable接口，功能与该委托类似。</para>
        /// <para>由于委托定义类似于类的定义，因此需要符合Pascal规则。</para>
        /// </summary>
        public delegate void Run();

        /// <summary>
        /// <para>定义一个方法，不返回值，没有参数。</para>
        /// <para>该方法与Run代理的要求一致，可以用于构造Run实例。</para>
        /// </summary>
        public static void showMessage() {
            Console.WriteLine("Method 1: Hello World!");
        }
    }
}
