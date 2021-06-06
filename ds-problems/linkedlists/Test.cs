using Xunit;

namespace ds_problems.linkedlists
{
    public class FindCircularLoop
    {
        [Fact]
        public void Test_Detect_Loop()
        {
            var detectLoopClass = new DetectLoop();
            detectLoopClass.Head = new Node(1);
            detectLoopClass.Head.next = new Node(2);
            detectLoopClass.Head.next.next = new Node(3);
            detectLoopClass.Head.next.next.next = new Node(4);
            detectLoopClass.Head.next.next.next.next = new Node(5);
            detectLoopClass.Head.next.next.next.next.next = detectLoopClass.Head.next.next;

            Assert.True(detectLoopClass.HasLoop(detectLoopClass.Head));
            Assert.True(detectLoopClass.HasLoop());
            Assert.Equal(detectLoopClass.detectAndFindFirstLoop(detectLoopClass.Head).data, 3);
        }

        [Fact]
        public void Test_FirstNodeInLoop()
        {
            var detectLoopClass = new DetectLoop();
            detectLoopClass.Head = new Node(1);
            detectLoopClass.Head.next = new Node(2);
            detectLoopClass.Head.next.next = new Node(3);
            detectLoopClass.Head.next.next.next = new Node(4);
            detectLoopClass.Head.next.next.next.next = new Node(5);
            detectLoopClass.Head.next.next.next.next.next = detectLoopClass.Head;

            Assert.Equal(detectLoopClass.detectAndFindFirstLoop(detectLoopClass.Head).data, 1);
        }

        [Fact]
        public void Test_FirstNodeInLoop2()
        {
            var detectLoopClass = new DetectLoop();
            detectLoopClass.Head = new Node(1);
            detectLoopClass.Head.next = new Node(2);
            detectLoopClass.Head.next.next = new Node(3);
            detectLoopClass.Head.next.next.next = new Node(4);
            detectLoopClass.Head.next.next.next.next = new Node(5);
            detectLoopClass.Head.next.next.next.next.next = detectLoopClass.Head.next;

            Assert.Equal(detectLoopClass.detectAndFindFirstLoop(detectLoopClass.Head).data, 2);
        }

        [Fact]
        public void Test_FirstNodeInLoop3()
        {
            var detectLoopClass = new DetectLoop();
            detectLoopClass.Head = new Node(1);
            detectLoopClass.Head.next = new Node(2);
            detectLoopClass.Head.next.next = new Node(3);
            detectLoopClass.Head.next.next.next = new Node(4);
            detectLoopClass.Head.next.next.next.next = new Node(5);
            detectLoopClass.Head.next.next.next.next.next = detectLoopClass.Head.next.next;

            Assert.Equal(detectLoopClass.detectAndFindFirstLoop(detectLoopClass.Head).data, 3);
        }

        [Fact]
        public void Test_FirstNodeInLoop4()
        {
            var detectLoopClass = new DetectLoop();
            detectLoopClass.Head = new Node(1);
            detectLoopClass.Head.next = new Node(2);
            detectLoopClass.Head.next.next = new Node(3);
            detectLoopClass.Head.next.next.next = new Node(4);
            detectLoopClass.Head.next.next.next.next = new Node(5);
            detectLoopClass.Head.next.next.next.next.next = detectLoopClass.Head.next.next.next;

            Assert.Equal(detectLoopClass.detectAndFindFirstLoop(detectLoopClass.Head).data, 4);
        }

        [Fact]
        public void Test_FirstNodeInLoop5()
        {
            var detectLoopClass = new DetectLoop();
            detectLoopClass.Head = new Node(1);
            detectLoopClass.Head.next = new Node(2);
            detectLoopClass.Head.next.next = new Node(3);
            detectLoopClass.Head.next.next.next = new Node(4);
            detectLoopClass.Head.next.next.next.next = new Node(5);
            detectLoopClass.Head.next.next.next.next.next = detectLoopClass.Head.next.next.next.next;

            Assert.Equal(detectLoopClass.detectAndFindFirstLoop(detectLoopClass.Head).data, 5);
        }
    }
}
