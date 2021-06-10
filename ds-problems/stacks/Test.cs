using Xunit;

namespace ds_problems.stacks
{
    public class TestReverseAStack
    {
        [Fact]
        public void Test_Stack_Reverse()
        {
            var stack = new ReverseAStack();
            stack.Stack.Push(1);
            stack.Stack.Push(2);
            stack.Stack.Push(3);
            stack.Stack.Push(4);
            stack.Stack.Push(5);
            stack.Reverse();
            Assert.Equal(1, stack.Stack.Pop());
            Assert.Equal(2, stack.Stack.Pop());
            Assert.Equal(3, stack.Stack.Pop());
            Assert.Equal(4, stack.Stack.Pop());
            Assert.Equal(5, stack.Stack.Pop());
        }

        [Fact]
        public void Test_Expression_Eval()
        {
            var exp = new ExpressionEval();
            Assert.Equal(0, exp.Eval(""));
            Assert.Equal(3, exp.Eval("1+2"));
            Assert.Equal(16, exp.Eval("(4*4)"));
            Assert.Equal(13, exp.Eval("1+2*6"));
        }


        [Fact]
        public void Test_String_Reverse()
        {
            var helper = new InfixToPrefix();
            Assert.Equal("olleh", helper.Reverse("hello"));
            Assert.Equal("taknev", helper.Reverse("venkat"));
        }
    }
}
