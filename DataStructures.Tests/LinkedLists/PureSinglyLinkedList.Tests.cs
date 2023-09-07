using DataStructures.SinglyLinkedLists;
using Newtonsoft.Json.Linq;

namespace DataStructures.Tests.LinkedLists
{
    public class PureSinglyLinkedList
    {
        public static TheoryData<object> TypeTestData => new()
        {
        42,
        "Hello",
        3.14,
        true,
        new List<string>(),
        new Dictionary<int,string>()
        };
        public static PureSinglyLinkedList<object> EmptyList => new();

        [Fact]
        public void InitializeEmptyList()
        {
            PureSinglyLinkedList<int> list = new();
            Assert.Empty(list);
        }

        [Theory]
        [InlineData(1)]
        [InlineData("kati")]
        public void AddHead_ToEmptyList_AddsNodeToHeadOfList<T>(T input)
        {
            // Arrange
            var list = new PureSinglyLinkedList<T>();
            var node = new SinglyLinkedListNode<T>(input);

            // Act
            list.AddHead(node);

            // Assert
            Assert.Equal(node.Value, list.Head);
            Assert.Equal(node.Value, list.Tail);
        }

        [Theory]
        [InlineData(0)] // Test adding to an empty list
        [InlineData(3)] // Test adding to a populated list
        [InlineData(3323)] // Test adding to a populated list
        public void AddHead_ShouldSetHeadAndTail(int listLength)
        {
            // Arrange
            PureSinglyLinkedList<int> list = new PureSinglyLinkedList<int>();
            SinglyLinkedListNode<int> newNode = new SinglyLinkedListNode<int>(42);

            // only executes if the scenario is a full list
            if(listLength > 0)
            {
                for (int i = 0; i < listLength; i++)
                {
                    var setupNode = new SinglyLinkedListNode<int>(i);
                    list.AddHead(setupNode);
                }
            }
            else
            {

            }
            // if (!isEmptyList)
            // {
            //     list.AddHead(firstNode);
            //     list.AddHead(secondNode);
            //     list.AddHead(thirdNode);
            // }

            // Act
            list.AddHead(newNode);

            // Assert
            Assert.Equal(newNode.Value, list.Head);
            // only executes if the scenario is a full list
            // if (!isEmptyList)
            // {
            //     Assert.Equal(firstNode.Value, list.Tail);
            // }
        }
    }
}
