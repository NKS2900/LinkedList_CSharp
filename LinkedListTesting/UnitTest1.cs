using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList_CSharp;
namespace LinkedListTesting
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the value when30 then search the node.
        /// </summary>
        [TestMethod]
        public void GivenValue_When30_ThenSearchTheNode()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            Node node = linkedList.Search(30);
            Assert.AreEqual(30, node.data);
        }
    }
}
