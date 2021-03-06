﻿using System.Linq;
using NUnit.Framework;

namespace CodeMetrics.Parsing.Tests
{
    /// <summary>
    /// learning tests for parsing the class Constructors
    /// </summary>
    [TestFixture]
    public class ConstructorExtractorTests : ExtractorsTestBase
    {
        [Test]
        public void Extract_FileWithSingleClassWithNoConstructor_ReturnNoConstructor()
        {
            var methods = ExtractSyntaxNodes(OneEmptyClass);

            Assert.That(methods, Is.Empty);
        }

        [Test]
        public void Extract_FileWithSingleClassWithParameterLessConstructor_ReturnsOneMethod()
        {
            const string fileCode = @"using System;
namespace MyNamespace
{
    public class MyClass
    {
        public MyClass()
        {
        }
    }
}";
            var methods = ExtractSyntaxNodes(fileCode);

            Assert.That(methods.Count(), Is.EqualTo(1));
        }

        [Test]
        public void Extract_FileWithSingleClassWithParameterConstructor_ReturnOneMethod()
        {
            const string fileCode = @"using System;
namespace MyNamespace
{
    public class MyClass
    {
        public MyClass(string constructorParam)
        {
        }
    }
}";
            var methods = ExtractSyntaxNodes(fileCode);

            Assert.That(methods.Count(), Is.EqualTo(1));
        }

        [Test]
        public void Extract_FileWithSingleClassWithTwoConstructors_ReturnTwoMethods()
        {
            const string fileCode = @"using System;
namespace MyNamespace
{
    public class MyClass
    {
        public MyClass(string constructorParam)
        {
        }

        public MyClass(int constructorParam)
        {
        }
    }
}";
            var methods = ExtractSyntaxNodes(fileCode);

            Assert.That(methods.Count(), Is.EqualTo(2));
        }

        [Test]
        public void Extract_FileWithSingleClassWithDerivedConstructor_ReturnOneMethod()
        {
            const string fileCode = @"using System;
namespace MyNamespace
{
    public class MyClass
    {
        public MyClass(string constructorParam) : base()
        {
        }
    }
}";
            var methods = ExtractSyntaxNodes(fileCode);

            Assert.That(methods.Count(), Is.EqualTo(1));
        }

        [Test]
        public void Extract_FileWithSingleClassWithReferencedConstructor_ReturnTwoMethods()
        {
            const string fileCode = @"using System;
namespace MyNamespace
{
    public class MyClass
    {
        public MyClass(string constructorParam) : this()
        {
        }

        public MyClass()
        {
        }
    }
}";
            var methods = ExtractSyntaxNodes(fileCode);

            Assert.That(methods.Count(), Is.EqualTo(2));
        }

        [Test]
        public void Extract_FileWithTwoClassesWithOneConstructor_ReturnTwoMethods()
        {
            const string fileCode = @"using System;
namespace MyNamespace
{
    public class MyClass
    {
        public MyClass()
        {
        }
    }

    public class MyClassB
    {
        public MyClassB()
        {
        }
    }
}";
            var methods = ExtractSyntaxNodes(fileCode);

            Assert.That(methods.Count(), Is.EqualTo(2));
        }

        [Test]
        public void Extract_FileWithNestedClassWithOneConstructor_ReturnTwoMethods()
        {
            const string fileCode = @"using System;
namespace MyNamespace
{
    public class MyClass
    {
        public MyClass()
        {
        }

        public class MyClassB
        {
            public MyClassB()
            {
            }
        }
    }
}";
            var methods = ExtractSyntaxNodes(fileCode);

            Assert.That(methods.Count(), Is.EqualTo(2));
        }

        [Test]
        public void Extract_FileWithOneClassWithInLineConstructor_ReturnOneMethod()
        {
            const string fileCode = @"using System;
namespace MyNamespace
{
    public class MyClass
    {
        public MyClass() {        }
    }
}";
            var methods = ExtractSyntaxNodes(fileCode);

            Assert.That(methods.Count(), Is.EqualTo(1));
        }
    }
}
