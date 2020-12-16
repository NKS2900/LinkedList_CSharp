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

        /// <summary>
        /// Find Position of Element Then Add 40 To After 30
        /// </summary>
        [TestMethod]
        public void FindPosition_ofElement_ThenAdd40ToAfter30()
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InserAtParticularPosition(3, 40);
            Node result = list.Search(40);
            Assert.AreEqual(40, result.data);

        }
    }
}
