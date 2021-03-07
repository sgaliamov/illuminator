namespace Illuminator.Tests
{
    public sealed class TestClass
    {
        private int _a;

        public TestClass(int a, out int b)
        {
            _a = a;
            b = _a + 1;
        }

        public int Foo(int a, out int b)
        {
            _a += a;
            b = _a + 1;

            return _a + b;
        }
    }
}